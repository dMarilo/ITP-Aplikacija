using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplikacija.DTO;
using Aplikacija.Models;

namespace Aplikacija.Interfaces
{
    public interface IUserService
    {
        Task Register(UserRegisterDTO userDTO);
        Task<User> Login(UserLoginDTO userLoginDTO);
        Task UpdateUser(UserRegisterDTO updatedUser);
    }
}