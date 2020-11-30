using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Business.Test
{
    public interface ITest2AppService: IApplicationService
    {
        Task<string> TestApi(string name);
    }
}
