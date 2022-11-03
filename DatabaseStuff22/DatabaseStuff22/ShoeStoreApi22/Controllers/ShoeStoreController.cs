using DatabaseStuff22.DAO;
using DatabaseStuff22.Models;
using Microsoft.AspNetCore.Mvc;

namespace ShoeStoreApi22.Controllers
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
