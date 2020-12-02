using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace BoxApp.Boxes
{
    public class Box : AuditedAggregateRoot<Guid>, ISoftDelete, IMultiTenant
    {
        public bool IsDeleted { get; set; }

        public Guid? TenantId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        public Box(Guid id, Guid? tenantId, [NotNull] string name, string description)
        {
            TenantId = tenantId;
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
