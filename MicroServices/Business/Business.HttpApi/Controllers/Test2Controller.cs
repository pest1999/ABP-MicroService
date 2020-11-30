﻿using Business.Test;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Business.Controllers
{
    [Area("business")]
    [Route("api/business/test2")]
    public class Test2Controller: BusinessController
    {
        private readonly ITest2AppService _testAppService;

        public Test2Controller(ITest2AppService testAppService)
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
