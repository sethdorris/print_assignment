using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace print.Models
{
    public class OrderRoot
    {
        public string partnerOrderReference { get; set; }
        public OrderCustomer orderCustomer { get; set; }
        public List<Item> items { get; set; }
        public List<Shipment> shipments { get; set; }
        public List<Payment> payments { get; set; }
        public List<ItemShipment> itemShipments { get; set; }
        public List<Webhook> webhooks { get; set; }
        public List<BillingVariable> billingVariables { get; set; }

        public OrderRoot()
        {
            items = new List<Item>();
            shipments = new List<Shipment>();
            payments = new List<Payment>();
            itemShipments = new List<ItemShipment>();
            webhooks = new List<Webhook>();
            billingVariables = new List<BillingVariable>();
        }
    }
}
