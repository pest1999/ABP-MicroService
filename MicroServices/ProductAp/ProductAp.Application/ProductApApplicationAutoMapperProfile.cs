using AutoMapper;
using ProductAp.Products;
using ProductAp.Products.Dto;

namespace ProductAp
{
    public class ProductApApplicationAutoMapperProfile : Profile
    {
        public ProductApApplicationAutoMapperProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<Product, CreateOrUpdateProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<CreateOrUpdateProductDto, Product>();
        }
    }
}
