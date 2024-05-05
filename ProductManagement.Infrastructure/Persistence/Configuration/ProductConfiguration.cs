using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Infrastructure.Persistence.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Price)
                .HasColumnType("decimal(18,4)");

            builder.Property(p => p.Name).IsRequired();

            builder.Property(p => p.Price).IsRequired();

            builder.Property(p => p.Category).IsRequired();
            builder.Ignore(p => p.Category);
        }
    }
}
