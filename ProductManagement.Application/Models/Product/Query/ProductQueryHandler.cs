using MediatR;
using ProductManagement.Domain;

namespace ProductManagement.Application.Models.Product.Query
{
    public class ProductQueryHandler : IRequestHandler<GetProductQuery, List<Domain.Entities.Product>>
    {
        private readonly IRepository<Domain.Entities.Product> _productRepository;

        public ProductQueryHandler(IRepository<Domain.Entities.Product> productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<Domain.Entities.Product>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var products = (await _productRepository.GetAll()).ToList();

            return products;
        }
    }
}
