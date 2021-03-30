using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using propeller_torken.Models;
using propeller_torken.Services;



namespace propeller_torken.Controllers
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

        public IActionResult Adminpage()
        {
            return View();
        }
        
        public IActionResult AdminOrders()
        {
            

            return View(OrderService);
        }

        public IActionResult AdminSent()
        {
            return View(OrderService);
        }


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

        [HttpPost]
        public IActionResult AdminOrders(OrderService os)
        {
            return View(os);
        }

        [HttpPost]
        public IActionResult AdminSent(OrderService os)
        {
            return View(os);
        }

    }


}
