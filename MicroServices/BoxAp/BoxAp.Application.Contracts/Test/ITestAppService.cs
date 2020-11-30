using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace BoxAp.Test
{
    public interface ITestAppService: IApplicationService
    {
        Task<string> TestApi(string name);
    }
}
