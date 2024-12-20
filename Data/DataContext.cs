using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplikacija.Models;
using Microsoft.EntityFrameworkCore;

namespace Aplikacija.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users => Set<User>();
    }
}