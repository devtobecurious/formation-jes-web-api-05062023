using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Wookiee> GetAll()
        {
            var query2 = from wookiee in this.context.Wookiees!
                         where wookiee.Id > 0
                         select wookiee;

            var query = this.context.Wookiees!.AsNoTracking()
                          .Where(item => item.Id > 0);
            // .Select(item => new { NamePlus = item.Name!.ToLower() });

            // no tracking
            return query.ToList();
        }
    }
}
