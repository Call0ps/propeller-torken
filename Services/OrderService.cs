using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using propeller_torken.Models;

namespace propeller_torken.Services
{
    public class OrderService
    {
        public List<Orders> CurrentOrderList { get; set; }
        //public List<Orders> SentOrderList { get; set; }

        public OrderService()
        {
            Products myProducts = new Products() { ID = 1, Name = "PropellerKeps1", Price = 150 };
            
            Customer myCustomer = new Customer() { FirstName = "Carl", LastName = "Bajs", Address = "Bajsgatan 1", City = "Malmö", ZipCode = 12345, Email = "InteBajs@gmail.com", PhoneNr = "070812345678" };

            CurrentOrderList = new List<Orders>()
            {
                new Orders{Id = 1, OurCustomer = myCustomer, Date = DateTime.Now, OurProduct = new List<Products>{myProducts } }
            };



        }

    }
}
