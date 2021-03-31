using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropellerTorkenMain.Models;

namespace PropellerTorkenMain.Models
{
    public class Orders
    {
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public Customer OurCustomer { get; set; }
        public List<Products> OurProduct { get; set; }

    }
}
