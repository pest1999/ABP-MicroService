using BoxApp.BoxManagement.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace BoxApp.BoxManagement
{
    public interface IBoxAppService: IApplicationService
    {
        Task<PagedResultDto<BoxDto>> GetAll(GetBoxInputDto input);

        Task<BoxDto> Get(Guid id);

        Task<BoxDto> Create(CreateOrUpdateBoxDto input);

        Task<BoxDto> Update(Guid id, CreateOrUpdateBoxDto input);

        Task Delete(List<Guid> ids);
    }
}
