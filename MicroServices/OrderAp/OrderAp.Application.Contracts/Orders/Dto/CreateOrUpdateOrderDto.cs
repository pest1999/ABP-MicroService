using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrderAp.Orders.Dto
{
    public class CreateOrUpdateOrderDto
    {
        [Required]
        public Guid ProductID { get; set; }

        public decimal Count { get; set; }
    }
}
