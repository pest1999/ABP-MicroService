using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace Order
{
    [DependsOn(
        typeof(OrderApplicationContractsModule)
    )]
    public class OrderHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Order";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(OrderApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
