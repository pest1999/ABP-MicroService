using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace OrderAp.Orders.Dto
{
    public class GetOrderInputDto : PagedAndSortedResultRequestDto
    {
        public Guid Filter { get; set; }
    }
}
