using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace ProductAp.Products.Dto
{
    public class ProductDto : EntityDto<Guid>
    {
        /// <summary>
        /// 产品名称
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [Required]
        public decimal Stock { get; set; }
    }
}
