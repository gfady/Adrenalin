using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityTypeConfuguration
{
    public class ClubConfiguration : IEntityTypeConfiguration<Club>
    {
        public void Configure(EntityTypeBuilder<Club> builder)
        {
            builder.Property(c => c.Image)
                .IsRequired(false)
                .HasDefaultValue(null);

            builder.Property(c => c.City)
                .IsRequired()
                .HasColumnName("Location_of_club");

            builder.Property(c => c.Adress)
                .IsRequired();
        }
    }
}
