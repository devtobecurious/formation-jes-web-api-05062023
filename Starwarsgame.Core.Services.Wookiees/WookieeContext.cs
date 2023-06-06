using Microsoft.EntityFrameworkCore;
using Starwarsgame.Core.Wookiees.Services.Configurations;
using StarwarsGame.Core.Models;

namespace Starwarsgame.Core.Wookiees.Services
{
    public class WookieeContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new WookieeEntityTypeConfiguration());
        }

        public DbSet<Wookiee>? Wookiees { get; set; }

    }
}
