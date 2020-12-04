using BoxApp.BoxManagement;
using BoxApp.BoxManagement.Dto;
using Business.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Identity;

namespace Business.Test
{
    [Authorize(BusinessPermissions.BusinessCrudPm.Default)]
    public class TestAppService : ApplicationService, ITestAppService
    {
        private readonly IIdentityUserAppService _userAppService;

        public TestAppService(IIdentityUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<string> TestApi(string name)
        {
            var user = await _userAppService.GetAsync(Guid.NewGuid());
            return "010101";
        }
    }
}
