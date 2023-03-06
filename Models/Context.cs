using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webproject.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-T64G6UVJ; database=BlogTasarım; integrated security=true");

        }
        public DbSet<Yazı> Yazis { get; set; }
        public DbSet<YaziTuru> YaziTurus { get; set; }

        public DbSet<Personel> Personels { get; set; }
    }
}
