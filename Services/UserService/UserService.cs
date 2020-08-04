using System.Linq;
using System.Collections.Generic;
using LatihanApi.Models;
using System.Threading.Tasks;
using LatihanApi.Dtos.User;
using AutoMapper;

namespace LatihanApi.Services.UserService
{
    public class UserService : IUserService
    {
        private static List<User> users = new List<User> {
            new User {Id = 0},
            new User {Id = 1, Username = "coba", Email = "coba@coba.com"}
        };
        private readonly IMapper _mapper;

        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetUserDto>>> GetAllUsers()
        {
            ServiceResponse<List<GetUserDto>> serviceResponse = new ServiceResponse<List<GetUserDto>>();
            serviceResponse.Data = (users.Select(u => _mapper.Map<GetUserDto>(u))).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetUserDto>> GetUserById(int id)
        {
            ServiceResponse<GetUserDto> serviceResponse = new ServiceResponse<GetUserDto>();
            serviceResponse.Data = _mapper.Map<GetUserDto>(users.FirstOrDefault(u => u.Id == id));
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetUserDto>>> AddUser(AddUserDto newUser)
        {
            ServiceResponse<List<GetUserDto>> serviceResponse = new ServiceResponse<List<GetUserDto>>();
            User user = _mapper.Map<User>(newUser);
            user.Id = users.Max(u => u.Id) + 1;
            users.Add(user);
            serviceResponse.Data = (users.Select(u => _mapper.Map<GetUserDto>(u))).ToList();
            return serviceResponse;
        }
    }
}