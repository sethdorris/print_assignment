using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace print.Models
{
    public class DeliveredPrice
    {
        public string deliveryMethodCode { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string created { get; set; }
        public string locationType { get; set; }
        public bool isDefault { get; set; }
    }
}
