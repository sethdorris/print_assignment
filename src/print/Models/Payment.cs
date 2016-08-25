using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace print.Models
{
    public class Payment
    {
        public string paymentMethod { get; set; }
        public string paymentID { get; set; }
        public double paymentAmount { get; set; }
    }
}
