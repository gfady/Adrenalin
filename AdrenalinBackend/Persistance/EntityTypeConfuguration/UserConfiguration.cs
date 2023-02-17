using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityTypeConfuguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("User_name");

            builder.Property(u => u.Role)
                .IsRequired(false)
                .HasDefaultValue("admin")
                .HasColumnName("User_Role");


            builder.Property(a => a.PasswordHash)
                .IsRequired()
                .HasColumnName("User_PasswordHash");

            builder.Property(a => a.PasswordSalt)
                .IsRequired()
                .HasColumnName("User_PasswordSalt");
        }
    }
}
