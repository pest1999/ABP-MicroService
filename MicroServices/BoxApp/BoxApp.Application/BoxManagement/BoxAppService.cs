using BoxApp.Boxes;
using BoxApp.BoxManagement.Dto;
using BoxApp.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace BoxApp.BoxManagement
{
    [Authorize(BoxAppPermissions.BoxAppCrudPm.Default)]
    public class BoxAppService : ApplicationService, IBoxAppService
    {
        private readonly IRepository<Box, Guid> _repository;

        public BoxAppService(IRepository<Box, Guid> repository)
        {
            _repository = repository;
        }

        public Task<BoxDto> Create(CreateOrUpdateBoxDto input)
        {
            throw new NotImplementedException();
        }

        public Task Delete(List<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public Task<BoxDto> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResultDto<BoxDto>> GetAll(GetBoxInputDto input)
        {
            var query = _repository
                .WhereIf(!string.IsNullOrWhiteSpace(input.Filter), _ => _.Name.Contains(input.Filter) ||
                                                                        _.Description.Contains(input.Filter));

            var items = await query.OrderBy(input.Sorting ?? "Name")
                                 .Skip(input.SkipCount)
                                 .Take(input.MaxResultCount)
                                 .ToListAsync();
            var totalCount = await query.CountAsync();

            var dots = ObjectMapper.Map<List<Box>, List<BoxDto>>(items);
            return new PagedResultDto<BoxDto>(totalCount, dots);
        }

        public Task<BoxDto> Update(Guid id, CreateOrUpdateBoxDto input)
        {
            throw new NotImplementedException();
        }
    }
}
