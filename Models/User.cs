using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = "Dusan";
        public string Mail { get; set; } = "dusan@marilovic.com";
        public int Godina { get; set; } = 22;
        public string Adresa { get; set; } = "Ulica Dusana Marilovica 9";
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}