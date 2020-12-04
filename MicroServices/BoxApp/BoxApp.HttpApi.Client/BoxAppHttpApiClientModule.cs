using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;


namespace BoxApp
{
    [DependsOn(
        typeof(BoxAppApplicationContractsModule),
        typeof(AbpHttpClientModule)
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
