using AmazonRetail.Infrastructure.Data;
using AmazonRetail.Infrastructure.NewFolder;
using AmazonRetail.Web.Pages;
using AmazonWeb.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonRetail.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public IActionResult Index(string searchitem)
        {
            ViewData["SearchItem"] = searchitem;
            ViewBag.products = _productRepository.Search(searchitem);
            return View();
        }
    }
}
