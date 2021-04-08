using PropellerTorkenMain.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropellerTorkenMain.Models
{
    public class Cart
    {
        public List<Product> products { get; set; }
        public Customer customer { get; set; }

        public Cart()
        {
            products = new List<Product>();
        }

    }
}
