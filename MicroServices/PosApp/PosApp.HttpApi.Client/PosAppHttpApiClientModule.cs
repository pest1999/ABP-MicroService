using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace PosApp
{
    [DependsOn(
        typeof(PosAppApplicationContractsModule)
    )]
    public class PosAppHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "PosApp";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(PosAppApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
