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
        public DbSet<Pizza> Pizzas => Set<Pizza>();

        public DbSet<Order> Orders => Set<Order>();

        protected void onModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>{
                entity.ToTable("Users");
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Id).ValueGeneratedOnAdd();
            }
            );

            modelBuilder.Entity<Pizza>(entity =>{
                entity.ToTable("Pizzas");
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Id).ValueGeneratedOnAdd();
            });

                modelBuilder.Entity<Order>(entity =>{
                entity.ToTable("Orders");
                entity.HasKey(o => o.Id);
                entity.Property(o => o.Id).ValueGeneratedOnAdd();
            }
            );
        }
    }

}