using System;
using Microsoft.EntityFrameworkCore;
using Samurai.App.Domain;

namespace Samurai.App.Data
{
    public class SamuraiContext:DbContext
    {
        public SamuraiContext()
        {
        }

        public DbSet<Domain.Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "");
        }
    }
}
