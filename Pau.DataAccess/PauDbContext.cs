using Microsoft.EntityFrameworkCore;
using Pau.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pau.DataAccess
{
    public class PauDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=192.168.147.21; Database=PauTest;uid=hasan;pwd=a123*!");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
