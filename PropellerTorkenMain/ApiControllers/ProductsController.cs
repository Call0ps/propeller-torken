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

        ProductService pService = new ProductService();

        public ProductsController()
        {

        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return pService.GetAllProducts().ToList();
        }



    }
}
