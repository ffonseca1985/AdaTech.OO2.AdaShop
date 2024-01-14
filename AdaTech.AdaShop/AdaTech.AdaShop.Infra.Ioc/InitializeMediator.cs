using AdaTech.AdaShop.Application.Customer.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace AdaTech.AdaShop.Infra.Ioc
{
    public static class InitializeMediator
    {
        public static IServiceCollection ResgisterMediator(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CustomerHandler).Assembly));
            return services;
        }
        
    }
}
