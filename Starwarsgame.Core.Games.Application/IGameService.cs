using StarwarsCo.Core.Services.Interfaces;
using Starwarsgame.Core.Games.Models;

namespace Starwarsgame.Core.Games.Application
{
    public interface IGameService : IGetAll<Game>, IUpdateOne<Game>
    {
    }
}
