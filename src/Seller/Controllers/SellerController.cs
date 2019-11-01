using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Seller.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private string ShopApiBasePath = "http://localhost:5000/api/v1/Shop";

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}