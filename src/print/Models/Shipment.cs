﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace print.Models
{
    public class Shipment
    {
        public int shipmentSequenceNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string companyName { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string countryCode { get; set; }
        public string phone { get; set; }
        public string shippingMethod { get; set; }
        public string IMBSerialNumber { get; set; }
    }
}
