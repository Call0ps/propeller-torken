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
        public OrderService ourOrderService = new OrderService();
        public CombinedViewModelsService myCVMS = new CombinedViewModelsService();


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
            

            return View(ourOrderService);
        }

        public IActionResult AdminSent()
        {
            return View();
        }


        public IActionResult AdminContact()
        {
            return View();
        }

        public IActionResult Delete(int? id)
        {
            ourOrderService.CurrentOrderList.Remove(ourOrderService.CurrentOrderList.FirstOrDefault(t => t.Id == id));
            ourOrderService.CurrentOrderList.Remove(ourOrderService.CurrentOrderList.Where(z => z.Id == id));
            

            return View();

        }
        
    }


}
