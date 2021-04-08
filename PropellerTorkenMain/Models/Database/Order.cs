using System;
using System.Collections.Generic;

#nullable disable

namespace PropellerTorkenMain.Models.Database
{
    public partial class Order
    {
        public Order()
        {
            ProductsInOrders = new HashSet<ProductsInOrder>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int OrderSum { get; set; }
        public int OurCustomer { get; set; }
        public string OrderStatus { get; set; }

        public virtual Customer OurCustomerNavigation { get; set; }
        public virtual ICollection<ProductsInOrder> ProductsInOrders { get; set; }
    }
}
