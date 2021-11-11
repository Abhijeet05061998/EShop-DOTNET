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
    public class CategroyController : ControllerBase
    {
        private readonly CategoryRepository repository = new CategoryRepository();
        [HttpPost]
        [Route("AddCategroy")]
        public IActionResult Add(Category category)
        {
            try
            {
                repository.AddCategroy(category);
                return Ok("Categroy Added");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}
