using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropellerTorkenMain.Services;
using PropellerTorkenMain.Models.Database;

namespace PropellerTorkenMain.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private ProductService pService = new ProductService();

        public ProductsController()
        {
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return pService.DeleteProduct(id);
        }

        [HttpGet]
        public IEnumerable<Product> Get(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return pService.GetAllProducts().ToList();
            }
            else
            {
                return pService.GetProductsByName(s).ToList();
            }
        }

        [HttpPost]
        public string Post(string name, int price, int qty)
        {
            return pService.AddProduct(name, price, qty);
        }
    }
}