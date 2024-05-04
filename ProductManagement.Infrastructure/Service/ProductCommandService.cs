// using ProductManagement.Application.Interfaces;
// using ProductManagement.Application.Models.Product.Command;
// using ProductManagement.Domain;
// using ProductManagement.Domain.Entities;
//
// namespace ProductManagement.Infrastructure.Service
// {
//     public class ProductCommandService : IProductCommandService
//     {
//         private readonly IRepository<Product> _productRepository;
//
//         public ProductCommandService(IRepository<Product> productRepository)
//         {
//             _productRepository = productRepository;
//         }
//
//         public async Task InsertProduct(ProductCommand request)
//         {
//             var product = new Product
//             {
//                 Name = request.Name,
//                 Code = request.Code,
//                 Description = request.Description,
//                 Price = request.Price
//             };
//
//             await _productRepository.Insert(product);
//
//         }
//     }
// }
