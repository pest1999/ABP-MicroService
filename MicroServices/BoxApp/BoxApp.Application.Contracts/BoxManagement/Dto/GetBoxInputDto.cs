using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace BoxApp.BoxManagement.Dto
{
    public class GetBoxInputDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
