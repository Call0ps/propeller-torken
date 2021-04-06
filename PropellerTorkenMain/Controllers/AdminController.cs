using Microsoft.AspNetCore.Mvc;
using PropellerTorkenMain.Models.Database;
using PropellerTorkenMain.Services;
using System.Collections.Generic;
using System.Linq;

namespace PropellerTorkenMain.Controllers
{
    public class AdminController : Controller
    {
        private PropellerDataContext _ctx = new PropellerDataContext();

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
            //List<Order> ourOrders = new List<Order>();
            //var orders = _ctx.Orders.ToList();
            //ourOrders = _ctx.Orders.ToList();

            //OrderService.GetOrders();

            //var model = OrderService.GetOrders();

            return View(OrderService.GetOrders());
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

            //_ctx.Orders.Remove(_ctx.Orders.FirstOrDefault(t => t.Id == id));

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