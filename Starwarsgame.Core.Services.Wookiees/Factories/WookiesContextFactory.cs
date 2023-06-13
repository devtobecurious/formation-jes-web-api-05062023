using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Starwarsgame.Core.Wookiees.Services.Factories
{
    public class WookiesContextFactory : IDesignTimeDbContextFactory<WookieeContext>
    {
        public WookieeContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder builder = new();

            builder.UseSqlServer("sever=127.0.0.1", options =>
            {
                options.CommandTimeout(1500);
            });

            return new WookieeContext(builder.Options);
        }
    }
}
