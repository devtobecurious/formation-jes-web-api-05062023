using StarwarsCo.Core.Services.Interfaces;
using Starwarsgame.Core.Enemies.Application;
using Starwarsgame.Core.Enemies.Services;
using Starwarsgame.Core.Games.Models;
using Starwarsgame.Core.Games.Services;
using Starwarsgame.Core.Wookiees.Application;
using Starwarsgame.Core.Wookiees.Services;

namespace StarwarsGame.Web.API.UI.Shared.Services
{
    public static class ServiceCollectionExtensions
    {
        #region Public methods
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
#if DEBUG
            services.AddScoped<IEnemyService, MemoryEnemyService>();
#else
            services.AddScoped<IEnemyService, MemoryEnemyService>();
#endif
            services.AddScoped<IWookieeService, ContextWookieeService>();

            services.AddScoped<IGetAll<Game>, GameGetAllService>();
            return services;
        }
        #endregion
    }
}
