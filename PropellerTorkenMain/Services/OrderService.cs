using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PropellerTorkenMain.Models.Database;

namespace PropellerTorkenMain.Services
{
    public class OrderService
    {


        public List<Order> CurrentOrderList { get; set; }
        public List<Order> SentOrderList { get; set; }
        public List<Product> productList { get; set; }

        PropellerDataContext pdc = new PropellerDataContext();
        


        public OrderService()
        {
            

        }

        public IEnumerable<Order> Get()
        {
            return pdc.Orders.ToList();
        }

        public IEnumerable<Order> GetOrderById(int id)
        {
            if (int.Equals(id,0))
            {
                return pdc.Orders.ToList();
            }
            else
            {
                return pdc.Orders.Where(o => o.Id == id).ToList();
            }
            
        }

        public string DeleteOrder(int id)
        {
            var orderToRemove = pdc.Orders.Where(o => o.Id == id).Single<Order>();
            pdc.Orders.Remove(orderToRemove);
            pdc.SaveChanges();
            return "Order successfully removed";
        }

        public string AddOrder(int customerId, int productId, int orderSum)
        {
           
            
            pdc.Orders.Add(new Order
            {
                Date = DateTime.Now,
                OurCustomer = customerId,
                OurProduct = productId,
                OrderSum = orderSum,
                
                
            });
            pdc.SaveChanges();
            return "Order successfully created";
        }

    }
}
