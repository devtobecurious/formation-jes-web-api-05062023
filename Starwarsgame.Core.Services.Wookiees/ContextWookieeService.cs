using Starwarsgame.Core.Wookiees.Application;
using StarwarsGame.Core.Models;

namespace Starwarsgame.Core.Wookiees.Services
{
    public class ContextWookieeService : IWookieeService
    {
        private readonly WookieeContext context;

        public ContextWookieeService(WookieeContext context)
        {
            this.context = context;
        }

        public IEnumerable<Wookiee>? GetAll()
        {
            // no tracking
            return this.context.Wookiees.ToList();
        }
    }
}
