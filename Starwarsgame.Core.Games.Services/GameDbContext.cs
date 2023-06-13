using Microsoft.EntityFrameworkCore;
using Starwarsgame.Core.Games.Models;

namespace Starwarsgame.Core.Games.Services
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options) : base(options)
        {
        }

        protected GameDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().ToTable("Game");
        }

        public DbSet<Game>? Games { get; set; }
    }
}
