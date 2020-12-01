using BoxApp.Test;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BoxApp.Controllers
{
    [Area("BoxApp")]
    [Route("api/BoxApp/test")]
    public class TestController: BoxAppController
    {
        private readonly ITestAppService _testAppService;

        public TestController(ITestAppService testAppService)
        {
            _testAppService = testAppService;
        }

        [HttpGet]
        public async Task<string> GetAsync()
        {
            return await _testAppService.TestApi("1");
        }

        [HttpGet]
        [Route("classes")]
        public List<string> GetClasses()
        {
            var theList = Assembly.GetExecutingAssembly().GetTypes()
                      .Where(t => t.Namespace == "BoxApp.Models.Test")
                      .ToList();

            foreach (var the in theList)
            {
                var type = the.GetProperties();
            }

            return null;
        }
    }
}
