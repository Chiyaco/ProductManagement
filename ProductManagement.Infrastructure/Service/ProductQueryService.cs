// using ProductManagement.Application.Interfaces;
// using ProductManagement.Application.Models.Product;
// using ProductManagement.Domain;
// using ProductManagement.Domain.Entities;
//
// namespace ProductManagement.Infrastructure.Service
// {
//     public class ProductQueryService : IProductQueryService
//     {
//         private readonly IRepository<Product> _productRepository;
//
//         public ProductQueryService(IRepository<Product> productRepository)
//         {
//             _productRepository = productRepository;
//         }
//
//         public async Task<Product> GetProductById(Guid id)
//         {
//             throw new NotImplementedException();
//         }
//
//         public async Task<List<Product>> GetProducts()
//         {
//
//             var products = (await _productRepository.GetAll()).ToList();
//
//             return products;
//         }
//
//         
//     }
// }
