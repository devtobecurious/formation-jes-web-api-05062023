using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Starwarsgame.Core.Games.Services.Factories
{
    public class GamesContextFactory : IDesignTimeDbContextFactory<GameDbContext>
    {
        public GameDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<GameDbContext> builder = new();

            builder.UseSqlServer("sever=127.0.0.1", options =>
            {
                options.CommandTimeout(1500);
            });

            return new GameDbContext(builder.Options);
        }
    }
}
