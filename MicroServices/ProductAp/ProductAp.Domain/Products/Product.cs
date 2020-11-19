using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace ProductAp.Products
{
    public class Product : AuditedAggregateRoot<Guid>, ISoftDelete, IMultiTenant
    {
        /// <summary>
        /// 产品名称
        /// </summary>
        [Required]
        [Column(TypeName = "VARCHAR(16)")]
        public string Name { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [Required]
        public decimal Stock { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? TenantId { get; set; }
    }
}
