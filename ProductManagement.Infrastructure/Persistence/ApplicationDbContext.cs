using Microsoft.EntityFrameworkCore;
using ProductManagement.Domain.Common;
using ProductManagement.Domain.Entities;
using ProductManagement.Infrastructure.Persistence.Configuration;

namespace ProductManagement.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            //modelBuilder.ApplyConfiguration(new WalletConfiguration());
            base.OnModelCreating(modelBuilder);

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            // Get all the entities that inherit from AuditableEntity
            // and have a state of Added or Modified
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is IAuditEntity && 
                    e.State is EntityState.Added or EntityState.Modified);

            // For each entity we will set the Audit properties
            foreach (var entityEntry in entries)
            {
                // If the entity state is Added let's set
                // the CreatedAt and CreatedBy properties
                if (entityEntry.State == EntityState.Added)
                {
                    ((IAuditEntity)entityEntry.Entity).CreatedAt = DateTime.Now;
                }
                else
                {
                    // If the state is Modified then we don't want
                    // to modify the CreatedAt and CreatedBy properties
                    // so we set their state as IsModified to false
                    Entry((IAuditEntity)entityEntry.Entity).Property(p => p.CreatedAt).IsModified = false;
                }

                // In any case we always want to set the properties
                // ModifiedAt and ModifiedBy
                ((IAuditEntity)entityEntry.Entity).ModifiedAt = DateTime.Now;

                if (entityEntry.State == EntityState.Added || entityEntry.State == EntityState.Modified)
                {
                    var entity = (IAuditEntity)entityEntry.Entity;
                    if (entity.Name.Length < 3)
                    {
                        throw new InvalidOperationException("Minimum length constraint violated.");
                    }

                    if (entity.Price <= 0)
                    {
                        throw new InvalidOperationException("Minimum Price constraint violated.");
                    }
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Product> Products { get; set; }

    }
}
