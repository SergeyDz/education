using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.API.Samples.Host.Models
{
    public class FactorialResult
    {
        public int N { get; set; }
        public float F { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Elapsed { get; set; }
    }
}