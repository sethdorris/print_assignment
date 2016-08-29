using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace print.Models.OrderConfirm
{
    public class Item
    {
        public int itemSequenceNumber { get; set; }
        public int productID { get; set; }
        public int quantity { get; set; }
        public object itemFile { get; set; }
        public object templateData { get; set; }
        public int itemID { get; set; }
        public object partnerItemReference { get; set; }
        public ItemPrice itemPrice { get; set; }
        public int productionDays { get; set; }
    }
}
