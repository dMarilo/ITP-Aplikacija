using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija.DTO
{
    public class UserLoginDTO
    {
        public string UsernameOrEmail { get; set; }
        public string  Password { get; set; }
    }
}