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

        public IActionResult ItemKeps1() 
        {
            if (HttpContext.Session.GetString("cart") == null)
            {
                Cart cart = new Cart();
                var product = pc.GetProductsByName("Propellerkeps2").FirstOrDefault();
                cart.products.Add(product);
                var str = JsonConvert.SerializeObject(cart);
                HttpContext.Session.SetString("cart", str);
            }
            else
            {
                var product = pc.GetProductsByName("Propellerkeps2").FirstOrDefault();
                var str = HttpContext.Session.GetString("cart");
                var cart = JsonConvert.DeserializeObject<Cart>(str);
                cart.products.Add(product);
                str = JsonConvert.SerializeObject(cart);
                HttpContext.Session.SetString("cart", str);
            }

            return View("PropellerKepsar");
        }
    }
}
