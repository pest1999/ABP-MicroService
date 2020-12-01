using BoxApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BoxApp.Controllers
{
    public class BoxAppController : AbpController
    {
        protected BoxAppController()
        {
            LocalizationResource = typeof(BoxAppResource);
        }
    }
}
