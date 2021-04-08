using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PropellerTorkenMain.Models;
using PropellerTorkenMain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropellerTorkenMain.Controllers
{
    public class ProductController : Controller
    {
        ProductService pc;


        public ProductController()
        {
            pc = new ProductService();
        }

        private PropellerDataContext _ctx = new PropellerDataContext();

        public void AddItemToCart()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PropellerKepsar()
        {
            return View();
        }

        public IActionResult TorkTumlare()
        {
            return View();
        }

        public IActionResult CreateSessionForItem1() 
        {
                SessionHandler("PropellerKeps2");

            return View("PropellerKepsar");
        }

        public IActionResult CreateSessionForItem2()
        {
            SessionHandler("PropellerKeps3");
            
            return View("PropellerKepsar");
        }

        public IActionResult CreateSessionForItem3()
        {
            SessionHandler("Torktumlare1");

            return View("PropellerKepsar");
        }

        public IActionResult CreateSessionForItem4()
        {
            SessionHandler("Torktumalre2");

            return View("Torktumlare");
        }

        public IActionResult CreateSessionForItem5()
        {
            SessionHandler("Torktumlare3");

            return View("Torktumlare");
        }

        public IActionResult CreateSessionForItem6()
        {

            SessionHandler("Torktumlare5");

            return View("Torktumlare");
        }

        public void SessionHandler(string productname)
        {
            if (HttpContext.Session.GetString("cart") == null)
            {
                Cart cart = new Cart();
                var product = pc.GetProductsByName(productname).FirstOrDefault();
                cart.products.Add(product);
                var str = JsonConvert.SerializeObject(cart);
                HttpContext.Session.SetString("cart", str);
            }
            else
            {
                var str = HttpContext.Session.GetString("cart");
                var cart = JsonConvert.DeserializeObject<Cart>(str);
                if (cart.products.Any(product => product.Name == productname))
                {
                    cart.products.Find(product => product.Name == productname).Qty++;
                }
                else
                {
                    var product = pc.GetProductsByName(productname).FirstOrDefault();
                    cart.products.Add(product);
                }

                str = JsonConvert.SerializeObject(cart);
                HttpContext.Session.SetString("cart", str);
            }
        }
    }
}