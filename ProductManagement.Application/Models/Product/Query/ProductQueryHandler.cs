using MediatR;
using ProductManagement.Application.Mapping;
using ProductManagement.Domain;

namespace ProductManagement.Application.Models.Product.Query
{
    public class ProductQueryHandler : IRequestHandler<GetProductQuery, List<ProductDto>>
    {
        private readonly IRepository<Domain.Entities.Product> _productRepository;

        public ProductQueryHandler(IRepository<Domain.Entities.Product> productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<ProductDto>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var products = (await _productRepository.GetAll()).ToList();

            var productDto = ProductMapping.MappingProductToProductDto(products);

            return productDto;
        }
    }
}
