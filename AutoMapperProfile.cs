using AutoMapper;
using LatihanApi.Dtos.User;
using LatihanApi.Models;

namespace LatihanApi
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, GetUserDto>();
            CreateMap<AddUserDto, User>();
        }
    }
}