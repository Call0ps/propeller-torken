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
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var str = HttpContext.Session.GetString("cart");
            var cart = JsonConvert.DeserializeObject<Cart>(str);
            
            return View(cart);
        }
    }
}
