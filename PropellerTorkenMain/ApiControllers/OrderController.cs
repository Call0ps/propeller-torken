using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropellerTorkenMain.Models.Database;
using PropellerTorkenMain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropellerTorkenMain.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        OrderService os = new OrderService();

        public OrderController()
        {

        }

        [HttpGet]
        public IEnumerable<Order> Get(int id)
        {
            if (int.Equals(id, 0))
            {
                return os.Get();
            }
            else
            {
                return os.GetOrderById(id);
            }
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return os.DeleteOrder(id);
        }

        [HttpPost]
        public string CreateOrder(int customerId, int productId, int orderSum)
        {
            return os.AddOrder(customerId, productId, orderSum);
        }
    }
}
