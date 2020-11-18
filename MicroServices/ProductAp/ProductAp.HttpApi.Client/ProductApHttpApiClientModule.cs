using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace ProductAp
{
    [DependsOn(
        typeof(ProductApApplicationContractsModule)
    )]
    public class ProductApHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "ProductAp";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ProductApApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
