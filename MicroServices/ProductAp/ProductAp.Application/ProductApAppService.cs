using ProductAp.Localization;
using Volo.Abp.Application.Services;

namespace ProductAp
{
    public abstract class ProductApAppService : ApplicationService
    {
        protected ProductApAppService()
        {
            LocalizationResource = typeof(ProductApResource);
        }
    }
}
