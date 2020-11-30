using BoxAp.Localization;
using Volo.Abp.Application.Services;

namespace BoxAp
{
    public abstract class BoxApAppService : ApplicationService
    {
        protected BoxApAppService()
        {
            LocalizationResource = typeof(BoxApResource);
        }
    }
}
