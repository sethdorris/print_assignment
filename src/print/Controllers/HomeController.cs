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
using System.Net;

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
            APIHelper api = new APIHelper("products");
            Datum result = await api.GetProduct(productId);
            OrderViewModel viewModel = new OrderViewModel();
            viewModel.Datum = result;
            return View(viewModel);
        }

        public async Task<IActionResult> PlaceOrder(OrderViewModel OrderForm, int productId)
        {
            APIHelper api = new APIHelper("orders");
            OrderForm.OrderRoot.items[0].productID = productId;
            print.Models.OrderConfirm.RootObject result = await api.PlaceOrder(OrderForm.OrderRoot);
            return RedirectToAction("Success", "Home", new { result = result.results.data.orderNumber });
        }

        public IActionResult Success(string result)
        {
            ViewBag.OrderNum = result;
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
