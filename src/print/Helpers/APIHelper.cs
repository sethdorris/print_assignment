using Newtonsoft.Json;
using print.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace print.Helpers
{
    public class APIHelper
    {
        private string BaseURL { get; set; }
        private string APIKey { get; set; }
        private string EndPoint { get; set; }
        private HttpClient Client { get; set; }
        private string RequestUrl { get; set; }
        public APIHelper()
        {
            BaseURL = "https://testapi.pfl.com";
            APIKey = "?apikey=136085";
            Client = new HttpClient();
        }
        public APIHelper(string endpoint)
        {
            BaseURL = "https://testapi.pfl.com";
            APIKey = "?apikey=136085";
            Client = new HttpClient();
            EndPoint = endpoint;

            RequestUrl = $"{BaseURL}/{EndPoint}{APIKey}";
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Client.DefaultRequestHeaders.Add("Authorization", "Basic bWluaXByb2plY3Q6UHIhbnQxMjM=");
        }

        public async Task<RootObject> GetProducts()
        {
            string response = await Client.GetStringAsync(RequestUrl);
            RootObject deserialized = JsonConvert.DeserializeObject<RootObject>(response);
            return deserialized;
        }

        public async Task<Datum> GetProduct(int pid)
        {
            string response = await Client.GetStringAsync(RequestUrl);
            RootObject deserialized = JsonConvert.DeserializeObject<RootObject>(response);
            Datum product = deserialized.results.data.Find(o => o.productID == pid);
            return product;
        }

        public async Task<print.Models.OrderConfirm.RootObject> PlaceOrder(OrderRoot order)
        {
            order.items[0].itemSequenceNumber = 1;
            order.shipments[0].shipmentSequenceNumber = 1;
            order.items[0].productionDays = 1;
            var request = JsonConvert.SerializeObject(order);
            var content = new StringContent(request, Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(RequestUrl, content);
            string result = await response.Content.ReadAsStringAsync();
            var deserialized = JsonConvert.DeserializeObject<print.Models.OrderConfirm.RootObject>(result);
            return deserialized;
        }
    }
}
