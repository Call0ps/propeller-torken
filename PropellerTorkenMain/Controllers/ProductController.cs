using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropellerTorkenMain.Models.Database;

namespace PropellerTorkenMain.Controllers
{
    public class ProductController : Controller
    {
        public Product ourProducts = new Product();
        PropellerDataContext ctx = new PropellerDataContext();


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PropellerKepsar()
        {

            ViewBag.ourProduct = new Product()
            {
                Name = ourProducts.Name,
                Price = ourProducts.Price,
                Qty = ourProducts.Qty
            };

            return View();
        }

        public IActionResult TorkTumlare()
        {
            return View();
        }
    }
}
