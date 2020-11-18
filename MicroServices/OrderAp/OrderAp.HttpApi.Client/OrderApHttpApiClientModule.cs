using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace OrderAp
{
    [DependsOn(
        typeof(OrderApApplicationContractsModule)
    )]
    public class OrderApHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "OrderAp";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(OrderApApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
