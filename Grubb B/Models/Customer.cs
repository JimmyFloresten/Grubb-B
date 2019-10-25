using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grubb_B.Models
{
    public class Customer
    {
        public int Customer_id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Customer_password { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}