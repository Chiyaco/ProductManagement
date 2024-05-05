using ProductManagement.Domain.Enums;

namespace ProductManagement.Application.Models
{
    public class ProductDto
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
