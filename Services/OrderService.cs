using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using propeller_torken.Models;

namespace propeller_torken.Services
{
    public class OrderService
    {


        public List<Orders> CurrentOrderList { get; set; }
            //{
            //    new Orders{Id = 1, OurCustomer = new Customer(){ FirstName = "Carl", LastName = "Bajs", Address = "Bajsgatan 1", City = "Malmö", ZipCode = 12345, Email = "InteBajs@gmail.com", PhoneNr = "070812345678"},
            //        Date = DateTime.Now, OurProduct = new List<Products>{ new Products() { ID = 1, Name = "PropellerKeps1", Price = 150 } } },
            //    new Orders{Id = 2, OurCustomer = new Customer() { FirstName = "Anton", LastName = "Fitness", Address = "LundVägen 37", City = "Lund", ZipCode = 11223, Email = "AntonFitness@gmail.com", PhoneNr = "07089996633"},
            //        Date = DateTime.Now, OurProduct = new List<Products>{ new Products() { ID = 2, Name = "Torktumlare", Price = 1500 } }}
            //};
        //public List<Orders> SentOrderList { get; set; }

        public OrderService()
        {
            Products myProducts = new Products() { ID = 1, Name = "PropellerKeps1", Price = 150 };
            Customer myCustomer = new Customer() { FirstName = "Carl", LastName = "Bajs", Address = "Bajsgatan 1", City = "Malmö", ZipCode = 12345, Email = "InteBajs@gmail.com", PhoneNr = "070812345678" };
            Products myProducts2 = new Products() { ID = 2, Name = "Torktumlare", Price = 1500 };
            Customer myCustomer2 = new Customer() { FirstName = "Anton", LastName = "Fitness", Address = "LundVägen 37", City = "Lund", ZipCode = 11223, Email = "AntonFitness@gmail.com", PhoneNr = "07089996633" };

            CurrentOrderList = new List<Orders>()
            {
                new Orders{Id = 1, OurCustomer = myCustomer, Date = DateTime.Now, OurProduct = new List<Products>{myProducts } },
                new Orders{Id = 2, OurCustomer = myCustomer2, Date = DateTime.Now, OurProduct = new List<Products>{myProducts2}}
            };

        }

        public void RemoveItemFromList()
        {

        }

    }
}
