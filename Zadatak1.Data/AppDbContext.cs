using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak1.Data.Entities;

namespace Zadatak1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        // Dodaj DbSet za svaku entitet klasu koju zelis mapirati na bazu podataka
        public DbSet<Book> Books { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQL2022DEV;Database=Algebra.WebApiZadatak1;Trusted_Connection=true;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
