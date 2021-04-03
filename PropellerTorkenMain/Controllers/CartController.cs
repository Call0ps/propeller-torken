using Microsoft.AspNetCore.Mvc;

namespace PropellerTorkenMain.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}