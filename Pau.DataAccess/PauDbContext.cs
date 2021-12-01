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
            //= 192.168.147.21 database= PauTest kullanıcı adı = hasan şifre=a123*!
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-TSVRU3N; Database=PauTest;uid=HasCodingStok;pwd=HasCodingStok.2021");
        }

        public DbSet<User> Users { get; set; }
    }
}
