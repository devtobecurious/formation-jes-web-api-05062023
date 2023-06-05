using StarwarsGame.Core.Models;

namespace Starwarsgame.Core.Wookiees.Application
{
    public interface IWookieeService
    {
        IEnumerable<Wookiee> GetAll();
    }
}
