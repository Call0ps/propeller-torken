using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropellerTorkenMain.Models;
using PropellerTorkenMain.Services;
using Microsoft.AspNetCore.Authorization;

namespace PropellerTorkenMain.Controllers
{
    public class AdminController : Controller
    {
        private OrderService OrderService { get; set; }
        public AdminController(OrderService orderService)
        {
            OrderService = orderService;
        }



        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Adminpage()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult AdminOrders()
        {
            

            return View(OrderService);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult AdminSent()
        {
            return View(OrderService);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AdminContact()
        {
            return View();
        }

        public IActionResult Delete(int id, OrderService os)
        {
            os.CurrentOrderList = OrderService.CurrentOrderList;
            os.CurrentOrderList.Remove(os.CurrentOrderList.FirstOrDefault(t => t.Id == id));
            OrderService.CurrentOrderList = os.CurrentOrderList;
            

            return View("AdminOrders", os);

            

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
