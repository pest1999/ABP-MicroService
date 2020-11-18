using OrderAp.Localization;
using Volo.Abp.Application.Services;

namespace OrderAp
{
    public abstract class OrderApAppService : ApplicationService
    {
        protected OrderApAppService()
        {
            LocalizationResource = typeof(OrderApResource);
        }
    }
}
