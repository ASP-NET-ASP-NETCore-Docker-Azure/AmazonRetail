using AmazonWeb.Core.Entities;
using ECommerce_shoppinCart_AspNetCore.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonRetail.Web.Controllers
{
    public class PayController : Controller
    {
        
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            ViewBag.Total = cart.Sum(item => item.Product.UnitPrice * item.Quantity);
            return View();
        }
        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
