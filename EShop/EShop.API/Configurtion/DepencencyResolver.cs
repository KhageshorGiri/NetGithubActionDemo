using EShop.Application.Interfaces;
using EShop.Application.Services;
using EShop.Domain.IRepositories;
using EShop.Infrastructure.Repositories;

namespace EShop.API.Configurtion
{
    public static class DepencencyResolver
    {
        public static void AddServicesDependecy(this IServiceCollection services)
        {
            services.AddScoped<IProduct, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
