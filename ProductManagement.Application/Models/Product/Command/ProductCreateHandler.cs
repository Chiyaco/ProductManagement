using ProductManagement.Application.Interfaces;
using ProductManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ProductManagement.Application.Models.Product.Command
{
    public class ProductCreateHandler : IRequestHandler<ProductCreate>
    {
        private readonly IRepository<Domain.Entities.Product> _productRepository;

        public ProductCreateHandler(IRepository<Domain.Entities.Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task Handle(ProductCreate request, CancellationToken cancellationToken)
        {
            var product = new Domain.Entities.Product
            {
                Name = request.Name,
                Category = request.Category,
                Description = request.Description,
                Price = request.Price
            };

            await _productRepository.Insert(product);
        }
    }
}
