using System.Linq;
using System.Collections.Generic;
using LatihanApi.Models;
using LatihanApi.Services.UserService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using LatihanApi.Dtos.User;

namespace LatihanApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private static User user = new User();
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _userService.GetAllUsers());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _userService.GetUserById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserDto newUser)
        {
            return Ok(await _userService.AddUser(newUser));
        }
    }
}