using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    Category = product.Category,
                    Price = product.Price,
                    Name = product.Name
                };
                productsDto.Add(dto);
            }

            return productsDto;
        }
    }
}
