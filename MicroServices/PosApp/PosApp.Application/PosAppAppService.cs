using PosApp.Localization;
using Volo.Abp.Application.Services;

namespace PosApp
{
    public abstract class PosAppAppService : ApplicationService
    {
        protected PosAppAppService()
        {
            LocalizationResource = typeof(PosAppResource);
        }
    }
}
