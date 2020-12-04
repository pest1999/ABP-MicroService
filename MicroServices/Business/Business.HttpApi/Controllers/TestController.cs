using BoxApp.BoxManagement;
using BoxApp.BoxManagement.Dto;
using Business.Test;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace Business.Controllers
{
    [Area("business")]
    [Route("api/business/test")]
    public class TestController: BusinessController
    {
        private readonly ITestAppService _testAppService;

        private readonly IBoxAppService _appService;

        public TestController(ITestAppService testAppService
            , IBoxAppService appService
            )
        {
            _testAppService = testAppService;
            _appService = appService;
        }

        [HttpGet]
        public async Task<string> GetAsync()
        {
            //HttpClient client = new HttpClient();
            //string token = Request.Headers["Authorization"];
            //client.DefaultRequestHeaders.Add("Authorization", token);
            //var result = await client.GetAsync("http://localhost:62162" + "/api/BoxApp/box");

            var dto = await _appService.GetAll(new GetBoxInputDto());

            return await _testAppService.TestApi("1");
        }

        [HttpGet]
        [Route("classes")]
        public List<string> GetClasses()
        {
            var theList = Assembly.GetExecutingAssembly().GetTypes()
                      .Where(t => t.Namespace == "Business.Models.Test")
                      .ToList();

            foreach (var the in theList)
            {
                var type = the.GetProperties();
            }

            return null;
        }
    }
}
