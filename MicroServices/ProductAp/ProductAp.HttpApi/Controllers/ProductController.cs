using Microsoft.AspNetCore.Mvc;
using ProductAp.Localization;
using ProductAp.Products;
using ProductAp.Products.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductAp.Controllers
{
    [Area("product")]
    [Route("api/product/Product")]
    public class ProductController : AbpController
    {
        private readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpGet]
        public async Task<PagedResultDto<ProductDto>> GetAllAsync()
        {
            GetProductInputDto input = new GetProductInputDto();
            return await _productAppService.GetAll(input);
        }

        [HttpGet]
        [Route("classes")]
        public List<string> GetClasses()
        {
            var theList = Assembly.GetExecutingAssembly().GetTypes()
                      .Where(t => t.Namespace == "Business.Models.Test")
                      .ToList();

            foreach (var the in theList)
            {
                var type = the.GetProperties();
            }

            return null;
        }
    }
}
