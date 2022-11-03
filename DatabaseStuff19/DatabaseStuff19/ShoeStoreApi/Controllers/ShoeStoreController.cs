using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseStuff19.DAO;
using DatabaseStuff19.Models;

namespace ShoeStoreApi.Controllers
{
    [Route("shoes")]
    [ApiController]
    public class ShoeStoreController : ControllerBase
    {
        private IShoeDao shoeDao;

        public ShoeStoreController(IShoeDao shoeDao)
        {
            this.shoeDao = shoeDao;
        }

        [HttpGet()]
        public List<string> ListShoes()
        {
            return shoeDao.GetInventory();
        }

        [HttpGet("{id}")]
        public ActionResult<Shoe> GetShoe(int id)
        {
            Shoe shoe = shoeDao.GetShoe(id);

            if (shoe != null)
            {
                return shoe;
            }

            else
            {
                return NotFound();
            }
        }
    }
}
