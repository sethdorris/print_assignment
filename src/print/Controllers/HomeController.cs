using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace print.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            JsonResult data;
            using (var client = new HttpClient())
            {
                var url = "https://testapi.pfl.com/products?apikey=136085";
                var message = new HttpRequestMessage(HttpMethod.Get, url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Basic bWluaXByb2plY3Q6UHIhbnQxMjM=");
                var response = await client.GetAsync(url);
                var info = JsonConvert.DeserializeObjectAsync(response);
            }
            return View(data.Value);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
