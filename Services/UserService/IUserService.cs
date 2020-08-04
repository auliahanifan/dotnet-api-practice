using System.Collections.Generic;
using System.Threading.Tasks;
using LatihanApi.Dtos.User;
using LatihanApi.Models;

namespace LatihanApi.Services.UserService
{
    public interface IUserService
    {
        Task<ServiceResponse<List<GetUserDto>>> GetAllUsers();

        Task<ServiceResponse<GetUserDto>> GetUserById(int id);

        Task<ServiceResponse<List<GetUserDto>>> AddUser(AddUserDto newUser);
    }
}