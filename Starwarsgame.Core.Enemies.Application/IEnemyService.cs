using StarwarsCo.Core.Services.Interfaces;
using StarwarsGame.Core.Models.Enemies;

namespace Starwarsgame.Core.Enemies.Application
{
    public interface IEnemyService : IGetAll<Enemy>
    {
    }
}
