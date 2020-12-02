using BoxApp.BoxManagement;
using BoxApp.BoxManagement.Dto;
using BoxApp.Models.Boxes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace BoxApp.Controllers
{
    [Area("BoxApp")]
    [Route("api/BoxApp/box")]
    public class BoxController : BoxAppController
    {
        private readonly IBoxAppService _appService;

        public BoxController(IBoxAppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        public async Task<PagedResultDto<BoxDto>> GetAll(GetBoxInputModel input)
        {
            GetBoxInputDto inputDto = new GetBoxInputDto();
            inputDto.Filter = input.Filter;
            return await _appService.GetAll(inputDto);
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
