using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarwarsGame.Core.Models;

namespace Starwarsgame.Core.Wookiees.Services.Configurations
{
    internal class WookieeEntityTypeConfiguration : IEntityTypeConfiguration<Wookiee>
    {
        public void Configure(EntityTypeBuilder<Wookiee> builder)
        {
            // TODO: totable
            builder.HasKey(e => e.Id);
            builder.ToTable(nameof(Wookiee));

            builder.Property(e => e.Id).HasColumnName("Identifiant");

            builder.HasMany(item => item.Roles)
                   .WithMany(item => item.Wookiees);

            var converterGrade = new ValueConverter<Grade, string>(x => x.ToString(),
                                                                   x => (Grade)Enum.Parse<Grade>(x));

            builder.Property(item => item.Grade)
                   .HasConversion(converterGrade);

        }
    }
}
