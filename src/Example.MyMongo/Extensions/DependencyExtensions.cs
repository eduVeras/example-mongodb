using Example.MyMongo.Interfaces.Repositories;
using Example.MyMongo.Interfaces.Services;
using Example.MyMongo.Repositories;
using Example.MyMongo.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Example.MyMongo.Extensions
{
    public static class DependencyExtensions
    {

        public static IServiceCollection AddDependecies(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
