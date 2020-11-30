using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using BoxAp.Products.Dto;
using BoxAp.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace BoxAp.Products
{
    //[Authorize(ProductApPermissions.Product.Default)]
    public class ProductAppService : ApplicationService, IProductAppService
    {
        private readonly IRepository<Product, Guid> _repository;

        public ProductAppService(IRepository<Product, Guid> repository)
        {
            _repository = repository;
        }

        [Authorize(BoxApPermissions.BoxAp.Create)]
        public async Task<ProductDto> Create(CreateOrUpdateProductDto input)
        {
            //var entity = new Product
            //{
            //    ProductID = input.ProductID,
            //    Count = input.Count
            //};
            var entity = ObjectMapper.Map<CreateOrUpdateProductDto, Product>(input);

            var result = await _repository.InsertAsync(entity);
            return ObjectMapper.Map<Product, ProductDto>(result);
        }

        [Authorize(BoxApPermissions.BoxAp.Delete)]
        public async Task Delete(List<Guid> ids)
        {
            foreach (var id in ids)
            {
                await _repository.DeleteAsync(id);
            }
        }

        public async Task<ProductDto> Get(Guid id)
        {
            var result = await _repository.GetAsync(id);
            return ObjectMapper.Map<Product, ProductDto>(result);
        }

        [Authorize(BoxApPermissions.BoxAp.Create)]
        public async Task<PagedResultDto<ProductDto>> GetAll(GetProductInputDto input)
        {
            var query = _repository
                .WhereIf(!string.IsNullOrEmpty(input.Filter), _ => _.Name.Contains(input.Filter));

            var items = await query.OrderBy(input.Sorting ?? "Name")
                                 .Skip(input.SkipCount)
                                 .Take(input.MaxResultCount)
                                 .ToListAsync();
            var totalCount = await query.CountAsync();

            var dots = ObjectMapper.Map<List<Product>, List<ProductDto>>(items);
            return new PagedResultDto<ProductDto>(totalCount, dots);
        }

        //[Authorize(ProductApPermissions.Product.Update)]
        public async Task<ProductDto> Update(Guid id, CreateOrUpdateProductDto input)
        {
            var dic = await _repository.GetAsync(id);

            dic.Name = input.Name;
            dic.Stock = input.Stock; ;

            return ObjectMapper.Map<Product, ProductDto>(dic);
        }
    }
}
