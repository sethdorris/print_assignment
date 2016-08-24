﻿using Newtonsoft.Json;
using print.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
    }
}
