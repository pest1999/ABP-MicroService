using BoxApp.Localization;
using Volo.Abp.Application.Services;

namespace BoxApp
{
    public abstract class BoxAppAppService : ApplicationService
    {
        protected BoxAppAppService()
        {
            LocalizationResource = typeof(BoxAppResource);
        }
    }
}
