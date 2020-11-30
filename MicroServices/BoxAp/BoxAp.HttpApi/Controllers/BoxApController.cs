using BoxAp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BoxAp.Controllers
{
    public class BoxApController : AbpController
    {
        protected BoxApController()
        {
            LocalizationResource = typeof(BoxApResource);
        }
    }
}
