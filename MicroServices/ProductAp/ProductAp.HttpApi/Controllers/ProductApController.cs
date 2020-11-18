using ProductAp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductAp.Controllers
{
    public class ProductApController : AbpController
    {
        protected ProductApController()
        {
            LocalizationResource = typeof(ProductApResource);
        }
    }
}
