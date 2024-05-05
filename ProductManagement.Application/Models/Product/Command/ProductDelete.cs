using MediatR;

namespace ProductManagement.Application.Models.Product.Command
{
    public class ProductDelete : IRequest
    {
        public int Id { get; set; }
    }
}
