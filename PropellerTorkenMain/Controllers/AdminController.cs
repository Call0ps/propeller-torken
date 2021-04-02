using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropellerTorkenMain.Models;
using PropellerTorkenMain.Services;
using PropellerTorkenMain.Models.Database;



namespace PropellerTorkenMain.Controllers
{
    public class AdminController : Controller
    {
        public List<CombinedViewModelsService> CVMS { get; set; }
        public List<Order> orderList { get; set; }
        PropellerDataContext _ctx = new PropellerDataContext();

        


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
            orderList = _ctx.Orders.ToList();
            //CVMS = _ctx.Orders.ToList();

            var _orders = _ctx.Orders.ToList();
            var _products = _ctx.Products.ToList();
            var _customers = _ctx.Customers.ToList();

            var combined = new CombinedViewModelsService() { 
                _Customer = _customers,
                _Order = _orders,
                _Product = _products 
            };

            return View(combined);
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
