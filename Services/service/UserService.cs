using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplikacija.Data;
using Aplikacija.DTO;
using Aplikacija.Interfaces;
using Aplikacija.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Aplikacija.Services.service
{
    public class UserService : IUserService
    {

        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            this._context = context;
        }
        public async Task<User> Login(UserLoginDTO userLoginDTO)
        {
             var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == userLoginDTO.UsernameOrEmail);
             var password = Encoding.UTF8.GetBytes(userLoginDTO.Password + user.PasswordSalt);
             Console.WriteLine(password);
            try {
                if (user == null)
                    throw new Exception(@"User with this id does not exist!!!");
                if(!user.PasswordHash.SequenceEqual(password))
                {
                    throw new Exception(@"Incorrect password");
                }
                return user;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Register(UserRegisterDTO userDTO)
        {
            var user = new User();
            user.Username= userDTO.Username;
            user.Adresa = userDTO.Adresa;
            user.Mail = userDTO.Mail;
            user.Godina= userDTO.Godina;
            user.PasswordSalt = Encoding.UTF8.GetBytes("yourSalt"); 
            user.PasswordHash = Encoding.UTF8.GetBytes(userDTO.Password + user.PasswordSalt);
            await _context.Users.AddAsync(user);
            _context.SaveChanges();
        }

        public async Task UpdateUser(UserRegisterDTO updatedUser)
        {
            var oldUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == updatedUser.Username);
            oldUser.Username= updatedUser.Username;
            oldUser.Adresa = updatedUser.Adresa;
            oldUser.Mail = updatedUser.Mail;
            oldUser.Godina= updatedUser.Godina;
            oldUser.PasswordSalt = Encoding.UTF8.GetBytes("yourSalt"); 
            oldUser.PasswordHash = Encoding.UTF8.GetBytes(updatedUser.Password + oldUser.PasswordSalt);
            
            await _context.SaveChangesAsync();

        }
    }
}