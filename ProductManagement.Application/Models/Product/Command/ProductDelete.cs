using MediatR;

namespace ProductManagement.Application.Models.Product.Command
{
    public class ProductDelete : IRequest
    {
        public Guid Id { get; set; }
    }
}
