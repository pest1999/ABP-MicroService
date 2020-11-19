using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace OrderAp.Orders.Dto
{
    public class OrderDto : EntityDto<Guid>
    {
        public Guid ProductID { get; set; }

        public decimal Count { get; set; }
    }
}
