using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductManagement.Domain;
using ProductManagement.Infrastructure.Interceptor;

namespace ProductManagement.Infrastructure.Persistence
{
    public static class ConfigureServices
    {
        public static IServiceCollection RegisterPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<AuditableEntityInterceptor>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            

            services.AddTransient<HttpClient>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddScoped<IProductQueryService, ProductQueryService>();
            //services.AddScoped<IProductCommandService, ProductCommandService>();


            return services;
        }
    }
}
