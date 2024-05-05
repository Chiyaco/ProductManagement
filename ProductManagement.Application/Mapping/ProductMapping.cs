using ProductManagement.Application.Models;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Mapping
{
    public static class ProductMapping
    {
        public static List<ProductDto> MappingProductToProductDto(List<Product> products)
        {
            var productsDto = new List<ProductDto>();
            foreach (var product in products)
            {
                var dto = new ProductDto()
                {
                    Id = product.Id,
                    Description = product.Description,
                    CategoryId = product.CategoryId,
                    Price = product.Price,
                    Name = product.Name
                };
                productsDto.Add(dto);
            }

            return productsDto;
        }
    }
}
