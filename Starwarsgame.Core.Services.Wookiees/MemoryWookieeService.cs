using Starwarsgame.Core.Wookiees.Application;
using StarwarsGame.Core.Models;

namespace Starwarsgame.Core.Wookiees.Services
{
    public class MemoryWookieeService : IWookieeService
    {
        public IEnumerable<Wookiee> GetAll()
        {
            return new List<Wookiee>()
            {
                new("Chewie", 10),
                new("Chewie 2", 100),
            };
        }
    }
}
