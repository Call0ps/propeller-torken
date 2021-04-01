using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropellerTorkenMain.Models;
using PropellerTorkenMain.Models.Database;

namespace PropellerTorkenMain.Services
{
    public class OrderService
    {

        PropellerDataContext pdc = new PropellerDataContext();
        public List<Order> CurrentOrderList { get; set; }
        public List<Order> SentOrderList { get; set; }

        public OrderService()
        {
            Product myProducts = new Product() { Id = 1, Name = "PropellerKeps1", Price = 150 };
            Customer myCustomer = new Customer() { Firstname = "Carl", Lastname = "Bajs", Address = "Bajsgatan 1", City = "Malmö", Zipcode = 12345, Email = "InteBajs@gmail.com", PhoneNr = "070812345678" };
            Product myProducts2 = new Product() { Id = 2, Name = "Torktumlare", Price = 1500 };
            Customer myCustomer2 = new Customer() { Firstname = "Anton", Lastname = "Fitness", Address = "LundVägen 37", City = "Lund", Zipcode = 11223, Email = "AntonFitness@gmail.com", PhoneNr = "07089996633" };

            CurrentOrderList = new List<Order>()
            {
                new Order{Id = 1, OurCustomer = myCustomer.CustomerId, Date = DateTime.Now, OurProduct = myProducts.Id},
                new Order{Id = 2, OurCustomer = myCustomer2.CustomerId, Date = DateTime.Now, OurProduct = myProducts2.Id}
            };

            SentOrderList = new List<Order>();

            

        }

        public void RemoveItemFromList()
        {

        }

        public IEnumerable<Order> GetAllOrders()
        {
            return pdc.Orders.ToList();
        }



        
    }
}
