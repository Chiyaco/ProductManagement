using ProductManagement.Application.Models.Product.Command;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Interfaces
{
    public interface IProductQueryService
    {
        // Query
        Task<Product> GetProductById(Guid id);

        // Query
        Task<List<Product>> GetProducts();
    }

    public interface IProductCommandService
    {
        // Command
        Task InsertProduct(ProductCreate request);
    }
}
