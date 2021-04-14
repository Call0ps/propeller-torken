using PropellerTorkenMain.Models;
using PropellerTorkenMain.Models.Database;
using System;
using System.Collections.Generic;

namespace PropellerTorkenMain.Services
{
    public class CartService
    {
        private readonly CustomerService customerService = new();
        private readonly OrderService orderService = new();

        public CartService(Cart cart)
        {
            CartSum = cart.CartSum;
            Cart = cart;
        }

        public Cart Cart { get; set; }
        public int CartSum { get; set; }

        public int CreateOrder()
        {
            if (Cart.CustomerId != 0)
            {
                return CreateOrder(Cart.Products, Cart.CustomerId);
            }
            else
            {
                return CreateOrder(Cart.Products, Cart.Customer);
            }
        }

        public int CreateOrder(List<Product> products, int CustomerId)
        {
            PropellerDataContext ctx = new();
            OrderService os = new();
            int orderNumber = os.AddOrder(CustomerId, CartSum);
            if (orderNumber != 0)
            {
                foreach (var prod in products)
                {
                    var newRel = new ProductsInOrder()
                    {
                        ProductId = prod.Id,
                        OrderId = orderNumber,
                        Amount = prod.Qty
                    };
                    ctx.ProductsInOrders.Add(newRel);
                }
                ctx.SaveChanges();
            }
            else
            {
                return 0;
            }
            return orderNumber;
        }

        public int CreateOrder(List<Product> products, DummyCustomer dummy)
        {
            PropellerDataContext ctx = new();
            Cart.CustomerId = customerService.AddCustomer(dummy);
            int orderId = orderService.AddOrder(Cart.CustomerId, CartSum);
            foreach (var prod in products)
            {
                var newRel = new ProductsInOrder
                {
                    ProductId = prod.Id,
                    OrderId = orderId,
                    Amount = prod.Qty
                };
                ctx.ProductsInOrders.Add(newRel);
            }
            ctx.SaveChanges();

            return orderId;
        }
    }
}