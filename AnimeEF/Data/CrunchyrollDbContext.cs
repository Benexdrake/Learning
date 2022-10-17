using AnimeEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AnimeEF.Data
{
    internal class CrunchyrollDbContext : DbContext
    {
        public DbSet<Anime_EF> Animes { get; set; }
        public DbSet<Season_EF> Seasons { get; set; }
        public DbSet<Episode_EF> Episodes { get; set; }

        public CrunchyrollDbContext()
        {

        }

        public CrunchyrollDbContext(DbContextOptions<CrunchyrollDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-MK5QCADK;Database=Crunchyroll;Trusted_Connection=True");
            }
        }

    }
}
