using Business.Permissions;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Business.Test
{
    [Authorize(BusinessPermissions.Business.Default)]
    public class TestAppService : ApplicationService, ITestAppService
    {
        public async Task<string> TestApi(string name)
        {

            return "010101";
        }
    }
}
