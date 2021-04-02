using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropellerTorkenMain.Models;
using PropellerTorkenMain.Models.Database;

namespace PropellerTorkenMain.Models
{
    public class Orders
    {
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public Customer OurCustomer { get; set; }
        public List<Product> OurProduct { get; set; }
        public int OrderSum { get; set; }

    }
}
