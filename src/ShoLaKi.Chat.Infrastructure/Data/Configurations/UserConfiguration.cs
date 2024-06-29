using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoLaKi.Chat.Domain.Entities;

namespace ShoLaKi.Chat.Infrastructure.Data.Configurations 
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.UserId); 

            builder.Property(u => u.Username)
                .IsRequired() 
                .HasMaxLength(50); 

            builder.Property(u => u.ProfilePictureUrl);

            builder.Property(u => u.Status)
                .HasDefaultValue(UserStatus.Offline); 

            builder.HasOne(u => u.PersonalChats) 
                .InverseProperty(pc => pc.User)
                .HasForeignKey(u => u.UserId); 

            builder.HasOne(u => u.GroupChats) 
                .InverseProperty(gc => gc.User)
                .HasForeignKey(u => u.UserId); 

 
        }
    }
}
