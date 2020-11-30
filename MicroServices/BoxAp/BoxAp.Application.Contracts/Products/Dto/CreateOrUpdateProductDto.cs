using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BoxAp.Products.Dto
{
    public class CreateOrUpdateProductDto
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
