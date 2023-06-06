using Starwarsgame.Core.Enemies.Application;
using StarwarsGame.Core.Models.Enemies;

namespace Starwarsgame.Core.Enemies.Services
{
    public class MemoryEnemyService : IEnemyService
    {
        public IEnumerable<Enemy> GetAll()
        {
            return new List<Enemy>()
            {
                new(),
                new()
            };
        }
    }
}