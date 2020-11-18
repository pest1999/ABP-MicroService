using Product.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Product.Controllers
{
    public class ProductController : AbpController
    {
        protected ProductController()
        {
            LocalizationResource = typeof(ProductResource);
        }
    }
}
