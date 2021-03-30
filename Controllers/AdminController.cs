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
        //Program myProgram = new Program();
        //CombinedViewModelsService combined = new CombinedViewModelsService();
        

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
            return View();
        }


        public IActionResult AdminContact()
        {
            return View();
        }

        public IActionResult Delete(int id, OrderService os)
        {
            os.CurrentOrderList.Remove(os.CurrentOrderList.FirstOrDefault(t => t.Id == id));
            OrderService.CurrentOrderList = os.CurrentOrderList;
            //ourOrderService.CurrentOrderList.Remove((Orders)ourOrderService.CurrentOrderList.Where(z => z.Id.Equals(id)));
            //ourOrderService.CurrentOrderList = ourOrderService.CurrentOrderList.Where(c => c.Id != id).ToList();

            return View("AdminOrders", os);

            

        }

        [HttpPost]
        public IActionResult AdminOrders(OrderService os)
        {
            return View(os);
        }
        
    }


}
