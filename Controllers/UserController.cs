using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplikacija.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aplikacija.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static List<User> korisnici = new List<User>{
            new User(),
            new User{ Username = "Goran"}
        };

        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return Ok(korisnici);
        }

    }
}