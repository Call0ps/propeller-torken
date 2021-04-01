using PropellerTorkenMain.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropellerTorkenMain.Services
{
    public class ProductService
    {

        public List<Product> productList { get; set; }
        PropellerDataContext pdc = new PropellerDataContext();


        public ProductService()
        {

        }

        public IEnumerable<Product> GetAllProducts()
        {
            return pdc.Products.ToList();
        }

    }
}
