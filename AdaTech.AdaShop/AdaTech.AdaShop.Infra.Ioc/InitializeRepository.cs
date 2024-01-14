using AdaTech.AdaShop.Domain.Infra;
using AdaTech.AdaShop.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace AdaTech.AdaShop.Infra.Ioc
{
    public static class InitializeRepository
    {
        public static IServiceCollection ResgisterRepositories(this IServiceCollection services)
        {
            services.AddSingleton(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            return services;
        }
    }
}