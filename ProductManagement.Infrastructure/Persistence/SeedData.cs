using ProductManagement.Domain.Entities;

namespace ProductManagement.Infrastructure.Persistence
{
    public static class SeedData
    {
        public static void InitializeDatabase(ApplicationDbContext context)
        {
            if (context.Products.Any())
                return;
            var product1 = new Product
            {
                Category = "Fashion",
                Name = "T-Shirt",
                Description = "This is a red T-Shirt",
                Price = 21,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now
            };

            var product2 = new Product
            {
                Category = "Fashion",
                Name = "Shirt",
                Description = "This is white Shirt",
                Price = 22,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now
            };
            var product3 = new Product
            {
                Category = "Fashion",
                Name = "Hat",
                Description = "This is a black Hat",
                Price = 23,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now
            };

            context.Products.Add(product1);
            context.Products.Add(product2);
            context.Products.Add(product3);

            context.SaveChanges();
        }
    }
}
