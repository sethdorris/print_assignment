using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using print.Models;
using print.Helpers;
using Microsoft.AspNetCore.Http;

namespace print.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            APIHelper api = new APIHelper("products");
            RootObject result = await api.GetProducts();
            return View(result);
        }

        public async Task<IActionResult> Order(int productId)
        {
            APIHelper api = new Helpers.APIHelper("products");
            Datum result = await api.GetProduct(productId);

            return View(result);
        }

        public async Task<IActionResult> PlaceOrder(OrderRoot OrderForm)
        {

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
