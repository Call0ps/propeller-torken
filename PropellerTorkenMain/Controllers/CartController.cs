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
    public class CartController : Controller
    {
        ProductService pc;
        CartService cs;

        public CartController()
        {
            pc = new ProductService();
            cs = new CartService();
        }
        public IActionResult Index()
        {
            var str = HttpContext.Session.GetString("cart");
            var cart = JsonConvert.DeserializeObject<Cart>(str);

            return View(cart);
        }

        public IActionResult IncrementQtyForProduct(string productName)
        {
            var cart = IncrementQty(productName);

            return View("Index", cart);
        }

        public IActionResult DecrementQtyForProduct(string productName)
        {
            var cart = DecrementQty(productName);

            return View("Index", cart);
        }


        public Cart IncrementQty(string productname)
        {
        
            var str = HttpContext.Session.GetString("cart");
            var cart = JsonConvert.DeserializeObject<Cart>(str);

            if (cart.products.Any(product => product.Name == productname))
            {
                cart.products.Find(product => product.Name == productname).Qty++;
                cart.GetCartSum();
            }

            str = JsonConvert.SerializeObject(cart);
            HttpContext.Session.SetString("cart", str);

            return JsonConvert.DeserializeObject<Cart>(str);
        }

        public Cart DecrementQty(string productname)
        {
            var str = HttpContext.Session.GetString("cart");
            var cart = JsonConvert.DeserializeObject<Cart>(str);

            if (cart.products.Any(product => product.Name == productname))
            {
                if (cart.products.Find(product => product.Name == productname).Qty > 0)
                {
                    cart.products.Find(product => product.Name == productname).Qty--;
                    cart.GetCartSum();
                }
                
            }

            str = JsonConvert.SerializeObject(cart);
            HttpContext.Session.SetString("cart", str);

            return JsonConvert.DeserializeObject<Cart>(str);
        }
    }
}
