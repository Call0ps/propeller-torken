using System;
using System.Collections.Generic;

#nullable disable

namespace PropellerTorkenMain.Models.Database
{
    public partial class Order
    {
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public int OurCustomer { get; set; }
        public int OurProduct { get; set; }
        public int OrderSum { get; set; }

        public virtual Customer OurCustomerNavigation { get; set; }
        public virtual Product OurProductNavigation { get; set; }
    }
}
