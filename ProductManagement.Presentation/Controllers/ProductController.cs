using Microsoft.AspNetCore.Mvc;
using ProductManagement.Application.Models.Product.Command;
using ProductManagement.Application.Models.Product.Query;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {
        //[HttpGet("products")]
        //public async Task<IActionResult> GetProducts(GetProductQuery request)
        //{
        //    var response = new GetProductResponse { Result = ResultType.Error };

        //    try
        //    {
        //        await Mediator.Send(request);

        //        var products = await _productQueryService.GetProducts();
        //        response.Products.AddRange(products);
        //        response.Result = ResultType.Success;

        //        return Ok(response);

        //    }
        //    catch (Exception e)
        //    {
        //        response.Messages.Add(e.Message);
        //        response.Result = ResultType.Error;
        //        return BadRequest(response);

        //    }

        //}

        [HttpGet("products")]
        public async Task<ActionResult<List<Product>>> GetUser()
        {
            var query = new GetProductQuery();
            return await Mediator.Send(query);
        }

        [HttpPost("insertProducts")]
        public async Task Create([FromBody]ProductCreate command)
            => await Mediator.Send(command);

        [HttpPut("updateProduct")]
        public async Task Update([FromBody] ProductUpdate command)
            => await Mediator.Send(command);

        [HttpDelete("deleteProduct/{id}")]
        public async Task Delete( string id)
        {
            var deleteRequest = new ProductDelete { Id = Guid.Parse(id) };
            await Mediator.Send(deleteRequest);
        }
            


    }

    //[HttpPost("insertProduct")]
    //    public async Task<ActionResult<Guid>> InsertProduct(ProductCommand request)
    //    {
            
    //        var result = new PostProductResponse { Result = ResultType.Error };

    //        //try
    //        //{
    //            await Mediator.Send(request);

    //        //    //await _productCommandService.InsertProduct(request);
    //        //    //result.Result = ResultType.Success;
    //        //    //result.Messages.Add(ConstMessage.SuccessMessage);

    //        //    //return Ok(result);
    //        //}
    //        //catch (Exception ex)
    //        //{
                
    //        //    //result.Messages.Add(ex.Message);
    //        //    //return BadRequest(result);
    //        //}
    //    }
    //}
}
