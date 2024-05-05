using Microsoft.AspNetCore.Mvc;
using ProductManagement.Application.Models;
using ProductManagement.Application.Models.Product.Command;
using ProductManagement.Application.Models.Product.Query;

namespace ProductManagement.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {

        [HttpGet("getProducts")]
        public async Task<ActionResult<List<ProductDto>>> GetProducts()
        {
            var query = new GetProductQuery();
            return await Mediator.Send(query);
        }

        [HttpPost("insertProducts")]
        public async Task Create([FromBody] ProductCreate command)
            => await Mediator.Send(command);

        [HttpPut("updateProduct")]
        public async Task Update([FromBody] ProductUpdate command)
            => await Mediator.Send(command);

        [HttpDelete("deleteProduct/{id}")]
        public async Task Delete(int id)
        {
            var deleteRequest = new ProductDelete { Id = id };
            await Mediator.Send(deleteRequest);
        }



    }
}
