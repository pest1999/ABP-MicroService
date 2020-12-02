using AutoMapper;
using BoxApp.Boxes;
using BoxApp.BoxManagement.Dto;

namespace BoxApp
{
    public class BoxAppApplicationAutoMapperProfile : Profile
    {
        public BoxAppApplicationAutoMapperProfile()
        {
            CreateMap<Box, BoxDto>();
        }
    }
}
