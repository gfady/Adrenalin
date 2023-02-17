using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityTypeConfuguration
{
    public class NewConfiguration : IEntityTypeConfiguration<New>
    {
        public void Configure(EntityTypeBuilder<New> builder)
        {
            builder.Property(n => n.Date)
                 .IsRequired()
                 .HasColumnType("date");

            builder.Property(p => p.Image)
                .IsRequired(false)
                .HasDefaultValue(null);

            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(n => n.Text)
                 .IsRequired(false)
                 .HasMaxLength(250);
        }
    }
}
