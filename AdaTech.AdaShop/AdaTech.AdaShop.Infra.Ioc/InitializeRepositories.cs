using AdaTech.AdaShop.Domain.Infra.Data;
using AdaTech.AdaShop.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace AdaTech.AdaShop.Infra.Ioc
{
    //É um classe responsavel por criar os repositories => Service Locatore
    public static class InitializeRepositories
    {
        public static IServiceCollection RegisterRepository(IServiceCollection services)
        {
            //registrando/mapeado os tipos genericos
            services.AddSingleton(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            return services;
        } 
    }
}
