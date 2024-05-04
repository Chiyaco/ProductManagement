using ProductManagement.Domain;
using MediatR;

namespace ProductManagement.Application.Models.Product.Command
{
    public class ProductDeleteHandler : IRequestHandler<ProductDelete>
    {
        private readonly IRepository<Domain.Entities.Product> _productRepository;

        public ProductDeleteHandler(IRepository<Domain.Entities.Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task Handle(ProductDelete request, CancellationToken cancellationToken)
        {
            var existedProduct = await _productRepository.Get(request.Id);

            if (existedProduct == null)
                throw new ArgumentNullException("The product isn't exist!");

            await _productRepository.Delete(existedProduct);


        }
    }
}
