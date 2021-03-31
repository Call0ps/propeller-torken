using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropellerTorkenMain.Models;
using PropellerTorkenMain.Services;

namespace PropellerTorkenMain.Services
{
    public class CombinedViewModelsService
    {
        public List<Orders> myOrders = new List<Orders>() {
                new Orders{Id = 1, OurCustomer = new Customer(){ FirstName = "Carl", LastName = "Bajs", Address = "Bajsgatan 1", City = "Malmö", ZipCode = 12345, Email = "InteBajs@gmail.com", PhoneNr = "070812345678"},
                    Date = DateTime.Now, OurProduct = new List<Products>{ new Products() { ID = 1, Name = "PropellerKeps1", Price = 150 } } },
                new Orders{Id = 2, OurCustomer = new Customer() { FirstName = "Anton", LastName = "Fitness", Address = "LundVägen 37", City = "Lund", ZipCode = 11223, Email = "AntonFitness@gmail.com", PhoneNr = "07089996633"},
                    Date = DateTime.Now, OurProduct = new List<Products>{ new Products() { ID = 2, Name = "Torktumlare", Price = 1500 } }}
            };
        


        


    }
}
