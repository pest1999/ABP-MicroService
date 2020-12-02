using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace BoxApp.BoxManagement.Dto
{
    public class BoxDto : EntityDto<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
