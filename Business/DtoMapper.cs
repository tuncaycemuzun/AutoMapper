using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace Business
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<LoginDto, User>().ReverseMap();
            CreateMap<CreateUserDto, User>().ReverseMap();
        }
    }
}
