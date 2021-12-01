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
            optionsBuilder.UseSqlServer("Server=serveradresi; Database=veritabani;uid=kullanıcıadı;pwd=şifre");
        }

        public DbSet<User> Users { get; set; }
    }
}
