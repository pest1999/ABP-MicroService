using Order.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Order.Controllers
{
    public class OrderController : AbpController
    {
        protected OrderController()
        {
            LocalizationResource = typeof(OrderResource);
        }
    }
}
