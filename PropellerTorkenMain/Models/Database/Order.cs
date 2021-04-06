using System;

#nullable disable

namespace PropellerTorkenMain.Models.Database
{
    public partial class Order
    {
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public int OrderSum { get; set; }
        public int OurCustomer { get; set; }
        public int OurProduct { get; set; }


        public virtual Customer _customer { get; set; }
        public virtual Order _order { get; set; }
    }
}