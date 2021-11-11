using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop.Supplier.Entities;
using Eshop.Supplier.Repositories;
namespace Eshop.Supplier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ItemRepository repository = new ItemRepository();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetItems() //Get the All item
        {
            try
            {
                List<Item> items = repository.GetItems();
                return Ok(items);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetItem/{itemId}")]
        public IActionResult Get(string itemId) //Get item using id
        {
            try
            {
                Item item = repository.GetItem(itemId);
                return Ok(item);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteItem/{itemId}")]
        public IActionResult DeleteItem(string itemId) //Delete Item using id
        {
            try
            {
                repository.DeleteItem(itemId);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddItem")]
        public IActionResult AddItem(Item item) //Add item
        {
            try
            {
                repository.AddItem(item);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPut]
        [Route("EditItem")]
        public IActionResult EditItem(Item item) //Update Item
        {
            try
            {
                repository.UpdateItem(item);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}
