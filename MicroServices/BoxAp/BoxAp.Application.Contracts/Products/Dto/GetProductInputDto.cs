using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace BoxAp.Products.Dto
{
    public class GetProductInputDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
