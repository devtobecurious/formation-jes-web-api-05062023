using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Starwarsgame.Core.Wookiees.Services;

namespace StarwarsGame.Web.API.UI.Shared.Services
{
    public static class DbContextConfigExtensions
    {
        #region Public methods
        public static IServiceCollection ConfigDbContext(this IServiceCollection services)
        {
            var settingsInMemory = (InMemoryDbContextOptionsBuilder optionsInMemory) =>
            {
                optionsInMemory.EnableNullChecks();
            };

            var callbackSettings = (DbContextOptionsBuilder options) =>
            {
                //options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.UseInMemoryDatabase("WookieesDb", settingsInMemory);
            };

            services.AddDbContext<WookieeContext>(callbackSettings);

            return services;
        }
        #endregion
    }
}
