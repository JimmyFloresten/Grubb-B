using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grubb_B.Models
{
    public class Education
    {
        public int Education_ID { get; set; }
        public string School_name { get; set; }
        public DateTime Education_date { get; set; }
        public string Subject { get; set; }
        public string Education_degree { get; set; }
    }
}