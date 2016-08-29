using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace print.Models
{
    public class OrderPrices
    {
            public double bundleCouponAmount { get; set; }
            public double envelopeTotalPrice { get; set; }
            public double mailingPriceTotal { get; set; }
            public double orderTotalPrice { get; set; }
            public double printPriceTotal { get; set; }
            public double rushTotalPrice { get; set; }
            public double secondSheetTotal { get; set; }
            public double shipPriceTotal { get; set; }
    }
}
