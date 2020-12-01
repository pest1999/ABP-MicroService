using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace BoxApp
{
    [DependsOn(
        typeof(BoxAppApplicationContractsModule)
    )]
    public class BoxAppHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "BoxApp";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(BoxAppApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
