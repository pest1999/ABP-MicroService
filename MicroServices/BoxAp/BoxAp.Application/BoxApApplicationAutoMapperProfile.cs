using AutoMapper;
using BoxAp.Products;
using BoxAp.Products.Dto;

namespace BoxAp
{
    public class BoxApApplicationAutoMapperProfile : Profile
    {
        public BoxApApplicationAutoMapperProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<Product, CreateOrUpdateProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<CreateOrUpdateProductDto, Product>();
        }
    }
}
