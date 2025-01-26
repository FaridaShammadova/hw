using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework__ORM_
{
    public class AppDbContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01; Database=PB503Library; Trusted_Connection=true; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
