using AutoMapper;
using OrderAp.Orders;
using OrderAp.Orders.Dto;

namespace OrderAp
{
    public class OrderApApplicationAutoMapperProfile : Profile
    {
        public OrderApApplicationAutoMapperProfile()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<Order, CreateOrUpdateOrderDto>();
            CreateMap<OrderDto, Order>();
            CreateMap<CreateOrUpdateOrderDto, Order>();
        }
    }
}
