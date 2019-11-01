using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private string SellerApiBasePath = "http://localhost:5000/api/v1/Seller";

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}