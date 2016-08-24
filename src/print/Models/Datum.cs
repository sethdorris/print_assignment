using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace print.Models
{
    public class Datum
    {
        public int id { get; set; }
        public int productID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string imageURL { get; set; }
        public int quantityDefault { get; set; }
        public int quantityMinimum { get; set; }
        public int? quantityMaximum { get; set; }
        public int? quantityIncrement { get; set; }
        public string shippingMethodDefault { get; set; }
        public bool hasTemplate { get; set; }
        public object emailTemplateId { get; set; }
        public object lastUpdated { get; set; }
        public List<object> customValues { get; set; }
        public List<DeliveredPrice> deliveredPrices { get; set; }
        public List<ProductionSpeed> productionSpeeds { get; set; }
    }
}
