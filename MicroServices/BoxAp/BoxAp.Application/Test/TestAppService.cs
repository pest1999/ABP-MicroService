using BoxAp.Permissions;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace BoxAp.Test
{
    [Authorize(BoxApPermissions.BoxAp.Default)]
    public class TestAppService : ApplicationService, ITestAppService
    {
        public async Task<string> TestApi(string name)
        {

            return "010101";
        }
    }
}
