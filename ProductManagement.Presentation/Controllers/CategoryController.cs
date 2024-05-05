using Microsoft.AspNetCore.Mvc;
using ProductManagement.Application.Models.Category.Query;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseController
    {
        
        [HttpGet("getCategories")]
        public async Task<ActionResult<List<CategoryType>>> GetProducts()
        {
            var query = new GetCategories();
            return await Mediator.Send(query);
        }

    }
}
