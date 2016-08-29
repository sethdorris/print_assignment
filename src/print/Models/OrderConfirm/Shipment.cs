using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace print.Models.OrderConfirm
{
    public class Shipment
    {
        public int shipmentSequenceNumber { get; set; }
        public object firstName { get; set; }
        public object lastName { get; set; }
        public object companyName { get; set; }
        public object address1 { get; set; }
        public object address2 { get; set; }
        public object city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string countryCode { get; set; }
        public object phone { get; set; }
        public object shippingMethod { get; set; }
        public object returnAddress { get; set; }
        public object description { get; set; }
        public object imbSerialNumber { get; set; }
    }
}
