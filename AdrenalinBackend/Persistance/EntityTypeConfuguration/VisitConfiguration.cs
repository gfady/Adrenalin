using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityTypeConfuguration
{
    public class VisitCOnfiguration : IEntityTypeConfiguration<Visit>
    {
        public void Configure(EntityTypeBuilder<Visit> builder)
        {
            builder.Property(v => v.VisitorName)
                .IsRequired()
                .HasColumnName("Visitor_name");

            builder.Property(v => v.Date)
                .IsRequired()
                .HasColumnName("Applying_date");

            builder.Property(v => v.PhoneNumber)
                .IsRequired()
                .HasColumnName("Visitor_phone_number");

            builder.HasOne(v => v.Club)
                .WithMany(c => c.Visits)
                .HasForeignKey(c => c.ClubId);
        }
    }
}
