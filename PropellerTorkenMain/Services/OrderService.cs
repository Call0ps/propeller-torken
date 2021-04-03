using PropellerTorkenMain.Models;
using PropellerTorkenMain.Models.Database;
using System.Collections.Generic;

namespace PropellerTorkenMain.Services
{
    public class OrderService
    {
        private PropellerDataContext ctx = new PropellerDataContext();

        public OrderService()
        {
            //Products myProducts = new Products() { ID = 1, Name = "PropellerKeps1", Price = 150 };
            //Customer myCustomer = new Customer() { FirstName = "Carl", LastName = "Bajs", Address = "Bajsgatan 1", City = "Malmö", ZipCode = 12345, Email = "InteBajs@gmail.com", PhoneNr = "070812345678" };
            //Products myProducts2 = new Products() { ID = 2, Name = "Torktumlare", Price = 1500 };
            //Customer myCustomer2 = new Customer() { FirstName = "Anton", LastName = "Fitness", Address = "LundVägen 37", City = "Lund", ZipCode = 11223, Email = "AntonFitness@gmail.com", PhoneNr = "07089996633" };

            //CurrentOrderList = new List<Orders>()
            //{
            //    new Orders{Id = 1, OurCustomer = myCustomer, Date = DateTime.Now, OurProduct = new List<Products>{myProducts } },
            //    new Orders{Id = 2, OurCustomer = myCustomer2, Date = DateTime.Now, OurProduct = new List<Products>{myProducts2}}
            //};

            //SentOrderList = new List<Orders>();
        }

        public List<Orders> CurrentOrderList { get; set; }
        public List<Orders> SentOrderList { get; set; }

        public IEnumerable<Order> GetOrders()
        {
            return ctx.Orders;
        }

        public void RemoveItemFromList()
        {
        }
    }
}