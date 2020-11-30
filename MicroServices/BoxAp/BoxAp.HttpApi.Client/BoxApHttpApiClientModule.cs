using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace BoxAp
{
    [DependsOn(
        typeof(BoxApApplicationContractsModule)
    )]
    public class BoxApHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "BoxAp";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(BoxApApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
