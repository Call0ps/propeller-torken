using Microsoft.AspNetCore.Mvc;
using PropellerTorkenMain.Models.Database;

namespace PropellerTorkenMain.Controllers
{
    public class ProductController : Controller
    {
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
    }
}