using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propeller_torken.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }


        public Customer()
        {

        }
    }
}
