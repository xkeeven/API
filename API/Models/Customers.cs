using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Customers
    {
        public long ID { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public int Phone_Number { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
