using MediatR;
using ProductManagement.Domain.Enums;

namespace ProductManagement.Application.Models.Product.Command
{
    public class ProductCreate : IRequest
    {
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
