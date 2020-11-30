using Business.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using XCZ.FormManagement;
using System;
using XCZ.FormManagement.Dto;
using Volo.Abp.Application.Dtos;

namespace Business.FormManagement
{
    //[Authorize(BusinessPermissions.Business.Default)]
    public class Form2AppService : FormAppService, IFormAppService
    {
        public Form2AppService(IRepository<Form, Guid> formRep, IRepository<FormField, int> columnRep):base(formRep, columnRep)
        {
        }


        public new Task<PagedResultDto<FormDto>> GetAll(GetFormInputDto input)
        {
            return base.GetAll(input);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override Task CheckPolicyAsync(string policyName)
        {
            return base.CheckPolicyAsync(policyName);
        }

        protected override IStringLocalizer CreateLocalizer()
        {
            return base.CreateLocalizer();
        }
    }
}
