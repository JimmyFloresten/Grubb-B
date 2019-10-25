using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grubb_B.Models
{
    public class Freelancer
    {
        public int Freelancer_ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Freelancer_Password { get; set; }
        public string Address { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string BirthCity { get; set; }
        public string Nationality { get; set; }
        public bool Drivers_license { get; set; }
        public string Profile_text { get; set; }
    }
}