using Microsoft.EntityFrameworkCore;
using StarwarsCo.Core.Services.Interfaces;
using Starwarsgame.Core.Games.Models;

namespace Starwarsgame.Core.Games.Services
{
    public class GameGetAllService : IGetAll<Game>
    {
        private readonly GameDbContext context;

        public GameGetAllService(GameDbContext context)
        {
            this.context = context;
            this.context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public IEnumerable<Game> GetAll()
        {
            return this.context.Games!.ToList();
        }
    }
}
