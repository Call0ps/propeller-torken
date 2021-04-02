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

        PropellerDataContext _ctx = new PropellerDataContext();

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


        public void AddItemToCart()
        {

        }
    }
}
