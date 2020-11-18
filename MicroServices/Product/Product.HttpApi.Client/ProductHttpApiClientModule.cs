using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace Product
{
    [DependsOn(
        typeof(ProductApplicationContractsModule)
    )]
    public class ProductHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Product";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ProductApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
