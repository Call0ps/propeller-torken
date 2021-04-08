using Microsoft.AspNetCore.Mvc;
using PropellerTorkenMain.Models.Database;
using PropellerTorkenMain.Services;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using PropellerTorkenMain.Models;
using PropellerTorkenMain.Services;
using Microsoft.AspNetCore.Authorization;

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

        public IActionResult Adminpage()
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
            var orders = OrderService.GetOrders();
            return View(orders);
        }

        public IActionResult AdminSent()
        {
            return View();
        }


        public IActionResult AdminContact()
        {
            var orders = OrderService.GetOrders("SENT");
            return View(orders);
        }

        public IActionResult Delete(int id)
        {

            OrderService.RemoveItemFromList(id);
            //os = OrderService.ctx.Orders.ToList();
            //os.Remove(os.FirstOrDefault(t => t.Id == id));
            //OrderService.ctx.SaveChanges();

            //OrderService.CurrentOrderList = os.CurrentOrderList;

            //OrderService.CurrentOrderList.Remove(OrderService.CurrentOrderList.FirstOrDefault(t => t.Id == id));

            //OrderService.GetOrders().Remove(OrderService.GetOrders().FirstOrDefault(t => t.Id == id));

            //_ctx.Orders.Remove(_ctx.Orders.FirstOrDefault(t => t.Id == id));



            return RedirectToAction("AdminOrders");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Send(int id)
        {
            //os.CurrentOrderList = OrderService.CurrentOrderList;
            //os.SentOrderList = OrderService.SentOrderList;
            //os.SentOrderList.Add(os.CurrentOrderList.FirstOrDefault(c => c.Id == id));
            //os.CurrentOrderList.Remove(os.CurrentOrderList.FirstOrDefault(t => t.Id == id));
            //OrderService.CurrentOrderList = os.CurrentOrderList;
            //OrderService.SentOrderList = os.SentOrderList;

            OrderService.SetStatusToSent(id);

            return View("AdminOrders");
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