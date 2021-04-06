using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PropellerTorkenMain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropellerTorkenMain.Controllers
{
    public class ProductController : Controller
    {
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
                //cart.products.
                var str = JsonConvert.SerializeObject(cart);
                HttpContext.Session.SetString("cart", str);
            }

            return View();
        }
    }
}
