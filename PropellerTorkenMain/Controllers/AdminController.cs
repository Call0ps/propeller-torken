using Microsoft.AspNetCore.Mvc;
using PropellerTorkenMain.Models.Database;
using PropellerTorkenMain.Services;
using System.Collections.Generic;
using System.Linq;

namespace PropellerTorkenMain.Controllers
{
    public class AdminController : Controller
    {
        private readonly PropellerDataContext _ctx = new();

        public AdminController(OrderService orderService)
        {
            OrderService = orderService;
        }

        // public List<CombinedViewModelsService> CVMS { get; set; }
        public List<Order> orderList { get; set; }

        private OrderService OrderService { get; set; }

        public IActionResult AdminContact()
        {
            return View();
        }

        public IActionResult AdminOrders()
        {
            return View(_ctx);
        }

        public IActionResult Adminpage()
        {
            return View();
        }

        public IActionResult AdminSent()
        {
            return View(OrderService);
        }

        public IActionResult Delete(int id, OrderService os)
        {
            os.CurrentOrderList = OrderService.CurrentOrderList;
            os.CurrentOrderList.Remove(os.CurrentOrderList.FirstOrDefault(t => t.Id == id));
            OrderService.CurrentOrderList = os.CurrentOrderList;

            return View("AdminOrders", os);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Send(int id, OrderService os)
        {
            os.CurrentOrderList = OrderService.CurrentOrderList;
            os.SentOrderList = OrderService.SentOrderList;
            os.SentOrderList.Add(os.CurrentOrderList.FirstOrDefault(c => c.Id == id));
            os.CurrentOrderList.Remove(os.CurrentOrderList.FirstOrDefault(t => t.Id == id));
            OrderService.CurrentOrderList = os.CurrentOrderList;
            OrderService.SentOrderList = os.SentOrderList;

            return View("AdminOrders", os);
        }

        //[HttpPost]
        //public IActionResult AdminOrders(OrderService os)
        //{
        //    return View(os);
        //}

        //[HttpPost]
        //public IActionResult AdminSent(OrderService os)
        //{
        //    return View(os);
        //}
    }
}