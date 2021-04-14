using PropellerTorkenMain.Models.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PropellerTorkenMain.Services
{
    public class OrderService
    {
        public PropellerDataContext ctx = new PropellerDataContext();

        public OrderService()
        {
        }

        public List<Order> CurrentOrderList { get; set; }
        public Order Order { get; set; }
        public List<Order> SentOrderList { get; set; }

        public int AddOrder(int customerId, int orderSum)
        {
            var returnValue = ctx.Orders.Add(new Order
            {
                Date = DateTime.Now,
                OurCustomer = customerId,
                OrderSum = orderSum
            });

            ctx.SaveChanges();
            return returnValue.Entity.Id;
        }

        public string DeleteOrder(int id)
        {
            var orderToRemove = ctx.Orders.Where(o => o.Id == id).Single<Order>();
            ctx.Orders.Remove(orderToRemove);
            ctx.SaveChanges();
            return "Order successfully removed";
        }

        public IEnumerable<Order> Get()
        {
            return ctx.Orders.AsEnumerable();
        }

        public IEnumerable<Order> GetOrderById(int id)
        {
            if (int.Equals(id, 0))
            {
                return ctx.Orders.ToList();
            }
            else
            {
                return ctx.Orders.Where(o => o.Id == id).ToList();
            }
        }

        public IEnumerable<Order> GetOrders(string orderStatus = null)
        {
            var orders = ctx.Orders.Where(o => o.OrderStatus == orderStatus).Include(o => o.OurCustomerNavigation).Include(o => o.ProductsInOrders)
                .Include(o => o.ProductsInOrders);

            IEnumerable<Order> result = orders.ToList();

            foreach (var order in result)
            {
                order.OurCustomerNavigation = ctx.Customers.FirstOrDefault(c => c.CustomerId == order.OurCustomer);
                order.ProductsInOrders = ctx.ProductsInOrders.Where(o => o.OrderId == order.Id).Include(o => o.Product).ToList();
                foreach (var product in order.ProductsInOrders)
                {
                    product.Product = ctx.Products.FirstOrDefault(p => p.Id == product.ProductId);
                }
            }

            return result;
        }

        public void RemoveItemFromList(int id)
        {
            var listItemFromOrder = ctx.ProductsInOrders.Where(p => p.OrderId == id);
            foreach (var items in listItemFromOrder)
            {
                ctx.ProductsInOrders.Remove(items);
            }
            ctx.SaveChanges();

            var listItemToRemove = ctx.Orders.FirstOrDefault(p => p.Id == id);
            ctx.Orders.Remove(listItemToRemove);
            ctx.SaveChanges();
        }

        public void SetStatusToSent(int id)
        {
            var sentItem = ctx.Orders.FirstOrDefault(x => x.Id == id);
            sentItem.OrderStatus = "SENT";
            ctx.SaveChanges();
        }
    }
}