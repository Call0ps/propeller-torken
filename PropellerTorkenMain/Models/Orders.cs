using PropellerTorkenMain.Models.Database;
using System;
using System.Collections.Generic;

namespace PropellerTorkenMain.Models
{
    public class Orders
    {
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public int OrderSum { get; set; }
        public Customer OurCustomer { get; set; }
        public List<Product> OurProduct { get; set; }
    }
}