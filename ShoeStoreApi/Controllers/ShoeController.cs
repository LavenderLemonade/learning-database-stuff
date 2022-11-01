using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseStuff;

namespace ShoeStoreApi.Controllers
{
    [Route("shoes")]
    [ApiController]
    public class ShoeController : ControllerBase
    {
        private IShoeDao shoeDao;

        public ShoeController(IShoeDao shoeDao)
        {
            this.shoeDao = shoeDao;
        }

        [HttpGet()]
        public List<string> ListShoes()
        {
            return shoeDao.GetInventory();
        }
    }
}
