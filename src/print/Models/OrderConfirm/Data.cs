using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace print.Models.OrderConfirm
{
    public class Data
    {
        public string orderNumber { get; set; }
        public object partnerOrderReference { get; set; }
        public OrderCustomer orderCustomer { get; set; }
        public List<Item> items { get; set; }
        public List<Shipment> shipments { get; set; }
        public object mailings { get; set; }
        public List<object> payments { get; set; }
        public List<object> itemShipments { get; set; }
        public List<object> webhooks { get; set; }
        public OrderPrices orderPrices { get; set; }
        public List<object> billingVariables { get; set; }
    }
}
