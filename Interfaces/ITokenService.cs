using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplikacija.Models;

namespace Aplikacija.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}