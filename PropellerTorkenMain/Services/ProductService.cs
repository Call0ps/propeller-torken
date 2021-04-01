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

        public IEnumerable<Product> GetProductsByName(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return pdc.Products.ToList();
            }
            else
            {
                return pdc.Products.Where(p => p.Name.ToLower().Contains(s)).ToList();
            }
        }

    }
}
