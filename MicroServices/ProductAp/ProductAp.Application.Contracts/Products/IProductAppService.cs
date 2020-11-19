using ProductAp.Products.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ProductAp.Products
{
    public interface IProductAppService : IApplicationService
    {
        Task<PagedResultDto<ProductDto>> GetAll(GetProductInputDto input);

        Task<ProductDto> Get(Guid id);

        Task<ProductDto> Create(CreateOrUpdateProductDto input);

        Task<ProductDto> Update(Guid id, CreateOrUpdateProductDto input);

        Task Delete(List<Guid> ids);
    }
}
