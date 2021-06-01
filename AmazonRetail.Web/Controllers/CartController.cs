using AmazonRetail.Infrastructure.Data;
using AmazonRetail.Infrastructure.NewFolder;
using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories;
using ECommerce_shoppinCart_AspNetCore.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonRetail.Web.Controllers
{
    public class CartController : Controller
    {
        IProductRepository _productRepository;
        public CartController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.Total = cart.Sum(item => item.Product.UnitPrice * item.Quantity);
            return View();
        }
        private int isExist(int id)
        {
            List<CartItem> cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
        public IActionResult Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart") == null)
            {
                List<CartItem> cart = new List<CartItem>();
                cart.Add(new CartItem() { Product = _productRepository.Get(id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<CartItem> cart = cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new CartItem() { Product = _productRepository.Get(id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            List<CartItem> cart = cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            int index = isExist(id);
            if (cart[index].Quantity > 1)
            {
                --cart[index].Quantity;
            }
            else
            {
                cart.RemoveAt(index);
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }


        /*private readonly ICartRepository _cartRepository;
        private readonly AmazonWebContext _context;
        public CartController(ICartRepository cartRepository,AmazonWebContext context)
        {
            _context = context;
            _cartRepository = cartRepository;
        }
        private int isExist(int id)
        {
            List<CartItem> cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
        public IActionResult Index()
        {
            var cart = _cartRepository.GetAll(); ;
            ViewBag.cart = cart; 
            ViewBag.Total = cart.Sum(item => item.Product.UnitPrice * item.Quantity);
            return View();
        }
        public IActionResult Buy(int id) 
        {
            IProductRepository _productRepository = new ProductRepository(_context);
            if (SessionHelper.GetObjectFromJson<IEnumerable<CartItem>>(HttpContext.Session, "cart") == null)
            {
                var cart = _cartRepository.GetAll();
                _cartRepository.Add(new CartItem() { Product = _productRepository.Get(id), Quantity = 1 });
                _context.SaveChanges();
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<CartItem> cart = cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new CartItem() { Product = _productRepository.Get(id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Remove(int id)
        {
            List<CartItem> cart = cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }*/
    }
}
