using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grubb_B.Models
{
    public class Work_history
    {
        public int Work_ID { get; set; }
        public string Company { get; set; }
        public string Work_position { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public string Work_duties { get; set; }
    }
}