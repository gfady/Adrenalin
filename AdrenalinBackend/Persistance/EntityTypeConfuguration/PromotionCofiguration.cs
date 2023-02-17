using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityTypeConfuguration
{
    public class PromotionCofiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.Property(p=>p.Image)
                .IsRequired(false)
                .HasDefaultValue(null);

            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Text)
                .IsRequired(false)
                .HasMaxLength(250);
        }
    }
}
