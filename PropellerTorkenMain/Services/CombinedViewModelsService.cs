using PropellerTorkenMain.Models.Database;
using System.Collections.Generic;

namespace PropellerTorkenMain.Services
{
    public class CombinedViewModelsService
    {
        public PropellerDataContext ctx = new PropellerDataContext();

        public CombinedViewModelsService()
        {
        }

        //public List<Orders> myOrders = new List<Orders>() {
        //        new Orders{Id = 1, OurCustomer = new Customer(){ FirstName = "Carl", LastName = "Bajs", Address = "Bajsgatan 1", City = "Malmö", ZipCode = 12345, Email = "InteBajs@gmail.com", PhoneNr = "070812345678"},
        //            Date = DateTime.Now, OurProduct = new List<Products>{ new Products() { ID = 1, Name = "PropellerKeps1", Price = 150 } } },
        //        new Orders{Id = 2, OurCustomer = new Customer() { FirstName = "Anton", LastName = "Fitness", Address = "LundVägen 37", City = "Lund", ZipCode = 11223, Email = "AntonFitness@gmail.com", PhoneNr = "07089996633"},
        //            Date = DateTime.Now, OurProduct = new List<Products>{ new Products() { ID = 2, Name = "Torktumlare", Price = 1500 } }}
        //    };
        public CombinedViewModelsService(List<Models.Database.Customer> custList, List<Models.Database.Product> prodList, List<Models.Database.Order> ordList)
        {
            this._Customer = custList;
            this._Product = prodList;
            this._Order = ordList;
        }

        public List<Models.Database.Customer> _Customer { get; set; }
        public List<Models.Database.Order> _Order { get; set; }
        public List<Models.Database.Product> _Product { get; set; }
        //public IEnumerable<CombinedViewModelsService> GetAllDetails()
        //{
        //}
    }
}