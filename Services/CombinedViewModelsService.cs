using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using propeller_torken.Models;
using propeller_torken.Services;

namespace propeller_torken.Services
{
    public class CombinedViewModelsService
    {
        public Orders myOrders { get; set; }
        public OrderService myOrderService { get; set; }


        public CombinedViewModelsService()
        {
            myOrderService = new OrderService();
        }


    }
}
