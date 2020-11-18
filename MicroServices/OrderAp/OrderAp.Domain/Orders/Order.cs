using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace OrderAp.Orders
{
    public class Order: AuditedAggregateRoot<Guid>, ISoftDelete, IMultiTenant
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        [Required]
        public Guid ProductID { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [Required]
        public decimal Count { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? TenantId { get; set; }
    }
}
