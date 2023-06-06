using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarwarsGame.Core.Models;

namespace Starwarsgame.Core.Wookiees.Services.Configurations
{
    internal class WookieeEntityTypeConfiguration : IEntityTypeConfiguration<Wookiee>
    {
        public void Configure(EntityTypeBuilder<Wookiee> builder)
        {
            // TODO: totable
            builder.HasKey(e => e.Id);
        }
    }
}
