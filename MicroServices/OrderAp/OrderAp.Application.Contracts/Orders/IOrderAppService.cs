using OrderAp.Orders.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace OrderAp.Orders
{
    public interface IOrderAppService : IApplicationService
    {
        Task<PagedResultDto<OrderDto>> GetAll(GetOrderInputDto input);

        Task<OrderDto> Get(Guid id);

        Task<OrderDto> Create(CreateOrUpdateOrderDto input);

        Task<OrderDto> Update(Guid id, CreateOrUpdateOrderDto input);

        Task Delete(List<Guid> ids);
    }
}
