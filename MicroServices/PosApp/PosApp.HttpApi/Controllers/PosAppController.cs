using PosApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PosApp.Controllers
{
    public class PosAppController : AbpController
    {
        protected PosAppController()
        {
            LocalizationResource = typeof(PosAppResource);
        }
    }
}
