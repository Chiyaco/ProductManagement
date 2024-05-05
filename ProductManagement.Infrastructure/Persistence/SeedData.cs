using ProductManagement.Domain.Entities;

namespace ProductManagement.Infrastructure.Persistence
{
    public static class SeedData
    {
        public static void InitializeDatabase(ApplicationDbContext context)
        {
            if (context.Products.Any())
                return;

            if (context.CategoryTypes.Any())
                return;

            var category1 = new CategoryType()
            {
                CategoryName = "Fashion"
            };
            var category2 = new CategoryType()
            {
                CategoryName = "Retails"
            };
            var category3 = new CategoryType()
            {
                CategoryName = "Food"
            };

            context.CategoryTypes.Add(category1);
            context.CategoryTypes.Add(category2);
            context.CategoryTypes.Add(category3);

            var product1 = new Product
            {
                Name = "T-Shirt",
                Description = "This is a red T-Shirt",
                Price = 21,
                CategoryId = 1,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
                
            };

            var product2 = new Product
            {
                Name = "Shirt",
                Description = "This is white Shirt",
                Price = 22,
                CategoryId = 1,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
               
            };
            var product3 = new Product
            {
                Name = "Hat",
                Description = "This is a black Hat",
                Price = 23,
                CategoryId = 1,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
                
            };

            context.Products.Add(product1);
            context.Products.Add(product2);
            context.Products.Add(product3);

            context.SaveChanges();
        }
    }
}
