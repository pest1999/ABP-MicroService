using OrderAp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OrderAp.Controllers
{
    public class OrderApController : AbpController
    {
        protected OrderApController()
        {
            LocalizationResource = typeof(OrderApResource);
        }
    }
}
