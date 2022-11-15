using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperShopAPI.Model;

namespace SuperShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IConfiguration config;
        private readonly ApplicationDBContext dBContext;

        public ItemsController(IConfiguration _config, ApplicationDBContext _dBContext)
        {
            this.config = _config;
            this.dBContext = _dBContext;
        }

        [HttpPost("AddItem")]
        public IActionResult AddItem(Item item)
        {
            if (dBContext.Items.Where(x=> x.ItemName == item.ItemName).FirstOrDefault() != null)
            {
                return Ok("Already Exist");
            }

            item.ItemInDate = DateTime.Now;
            dBContext.Items.Add(item);
            var result = dBContext.SaveChanges();

            return Ok("Your Item ID is : " + result);
        }

        [HttpGet("GetItems")]
        public IActionResult GetAllItems()
        {
            return Ok(dBContext.Items.ToList<Item>());
        }
    }
}
