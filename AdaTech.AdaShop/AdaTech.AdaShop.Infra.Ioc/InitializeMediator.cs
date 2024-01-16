using AdaTech.AdaShop.Application.Customer.Handler;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.AdaShop.Infra.Ioc
{
    public static class InitializeMediator
    {
        public static IServiceCollection ResgisterMediator(IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CustomerHandler).Assembly));
            return services;
        }

    }
}
