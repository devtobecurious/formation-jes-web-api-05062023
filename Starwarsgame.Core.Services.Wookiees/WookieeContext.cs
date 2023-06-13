using Microsoft.EntityFrameworkCore;
using Starwarsgame.Core.Wookiees.Services.Configurations;
using StarwarsGame.Core.Models;

namespace Starwarsgame.Core.Wookiees.Services
{

    public class WookieeContext : DbContext
    {
        protected WookieeContext()
        {
        }

        public WookieeContext(DbContextOptions<WookieeContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // modelBuilder.

            //var myType = this.GetType();
            //var methods = myType.GetMethods();
            //foreach (var method in methods)
            //{
            //    method.Invoke(this, new object[] { method });
            //}
            //Activator.CreateInstance()

            // modelBuilder.ApplyConfigurationsFromAssembly(myType.Assembly);
            modelBuilder.ApplyConfiguration(new WookieeEntityTypeConfiguration());
        }


        public DbSet<Wookiee>? Wookiees { get; set; }

    }
}
