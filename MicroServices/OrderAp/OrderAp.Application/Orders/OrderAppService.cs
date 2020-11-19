using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using OrderAp.Orders.Dto;
using OrderAp.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace OrderAp.Orders
{
    //[Authorize(OrderApPermissions.Order.Default)]
    public class OrderAppService : OrderApAppService, IOrderAppService
    {
        private readonly IRepository<Order, Guid> _repository;

        public OrderAppService(IRepository<Order, Guid> repository)
        {
            _repository = repository;
        }

        //[Authorize(OrderApPermissions.Order.Create)]
        public async Task<OrderDto> Create(CreateOrUpdateOrderDto input)
        {
            //var entity = new Order
            //{
            //    ProductID = input.ProductID,
            //    Count = input.Count
            //};
            var entity = ObjectMapper.Map<CreateOrUpdateOrderDto, Order>(input);

            var result = await _repository.InsertAsync(entity);
            return ObjectMapper.Map<Order, OrderDto>(result);
        }

        //[Authorize(OrderApPermissions.Order.Delete)]
        public async Task Delete(List<Guid> ids)
        {
            foreach (var id in ids)
            {
                await _repository.DeleteAsync(id);
            }
        }

        public async Task<OrderDto> Get(Guid id)
        {
            var result = await _repository.GetAsync(id);
            return ObjectMapper.Map<Order, OrderDto>(result);
        }

        public async Task<PagedResultDto<OrderDto>> GetAll(GetOrderInputDto input)
        {
            var query = _repository
                .WhereIf(Guid.Empty!=input.Filter, _ => _.ProductID == input.Filter);

            var items = await query.OrderBy(input.Sorting ?? "ProductID")
                                 .Skip(input.SkipCount)
                                 .Take(input.MaxResultCount)
                                 .ToListAsync();
            var totalCount = await query.CountAsync();

            var dots = ObjectMapper.Map<List<Order>, List<OrderDto>>(items);
            return new PagedResultDto<OrderDto>(totalCount, dots);
        }

        //[Authorize(OrderApPermissions.Order.Update)]
        public async Task<OrderDto> Update(Guid id, CreateOrUpdateOrderDto input)
        {
            var dic = await _repository.GetAsync(id);

            dic.ProductID = input.ProductID;
            dic.Count = input.Count;;

            return ObjectMapper.Map<Order, OrderDto>(dic);
        }
    }
}
