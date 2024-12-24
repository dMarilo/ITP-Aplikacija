using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplikacija.DTO;
using Aplikacija.Interfaces;
using Aplikacija.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Aplikacija.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDTO user)
        {
            await _userService.Register(user);
            return Ok();
        }

        [HttpPost("Login")]
        public async Task<ActionResult<User>> Login(UserLoginDTO userLoginDTO)
        {
            return Ok(await _userService.Login(userLoginDTO));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UserRegisterDTO user)
        {
            await _userService.UpdateUser(user);
            return Ok();
        }
    }
}