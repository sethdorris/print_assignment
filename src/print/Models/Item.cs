using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace print.Models
{
    public class Item
    {
        public int itemSequenceNumber { get; set; }
        public int productID { get; set; }
        public int quantity { get; set; }
        public int productionDays { get; set; }
        public string partnerItemReference { get; set; }
        public string itemFile { get; set; }
    }
}
