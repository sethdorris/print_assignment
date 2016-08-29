using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace print.Models.OrderConfirm
{
    public class OrderCustomer
    {
        public string firstName { get; set; }
        public object lastName { get; set; }
        public object companyName { get; set; }
        public object address1 { get; set; }
        public object address2 { get; set; }
        public object city { get; set; }
        public string state { get; set; }
        public object postalCode { get; set; }
        public string countryCode { get; set; }
        public string email { get; set; }
        public object phone { get; set; }
    }
}
