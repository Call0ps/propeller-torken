using System;
using System.Collections.Generic;

#nullable disable

namespace PropellerTorkenMain.Models.Database
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
