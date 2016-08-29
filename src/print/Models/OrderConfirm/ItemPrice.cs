using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace print.Models
{
    public class ItemPrice
    {
        public double envelopePrice { get; set; }
        public double mailingPrice { get; set; }
        public double printingCostEach { get; set; }
        public double printPrice { get; set; }
        public double promotionalDiscount { get; set; }
        public object retailFulfillmentPrice { get; set; }
        public object retailPrintPrice { get; set; }
        public object retailReimbursementPrice { get; set; }
        public object retailRushPrice { get; set; }
        public object retailShippingPrice { get; set; }
        public double rushPrice { get; set; }
        public double secondSheetPrice { get; set; }
        public double shipPrice { get; set; }
        public double totalPrice { get; set; }
        public double totalPrintingPrice { get; set; }
    }
}
