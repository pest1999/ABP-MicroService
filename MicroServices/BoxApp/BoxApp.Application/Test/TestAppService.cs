using BoxApp.Permissions;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace BoxApp.Test
{
    [Authorize(BoxAppPermissions.BoxAppCrudPm.Default)]
    public class TestAppService : ApplicationService, ITestAppService
    {
        public async Task<string> TestApi(string name)
        {

            return "010101";
        }
    }
}
