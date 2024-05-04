using ProductManagement.Domain;
using MediatR;

namespace ProductManagement.Application.Models.Product.Command
{
    public class ProductUpdateHandler : IRequestHandler<ProductUpdate>
    {
        private readonly IRepository<Domain.Entities.Product> _productRepository;

        public ProductUpdateHandler(IRepository<Domain.Entities.Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task Handle(ProductUpdate request, CancellationToken cancellationToken)
        {
            var existedProduct = await _productRepository.Get(request.Id);

            if (existedProduct == null)
                throw new ArgumentNullException("The product isn't exist!");

            existedProduct.Name = request.Name;
            existedProduct.Price = request.Price;
            existedProduct.Description = request.Description;
            existedProduct.Category = request.Category;

            await _productRepository.Update(existedProduct);


        }
    }
}
