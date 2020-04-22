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
                "Server=tcp:emamcoder.database.windows.net,1433;Initial Catalog=SamuraiDb;Persist Security Info=False;User ID=emam;Password=azure@12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
