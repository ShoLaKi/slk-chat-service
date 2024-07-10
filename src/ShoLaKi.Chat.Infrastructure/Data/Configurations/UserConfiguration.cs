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
            builder.Property(u => u.Type)
                .HasDefaultValue(UserType.Client);

            builder.HasMany(pc => pc.PersonalChats)
                .WithMany(u => u.ChatUsers);

            builder.HasMany(u => u.GroupMembers) 
                .WithOne(gc => gc.User)
                .HasForeignKey(u => u.UserId);
            builder.HasMany(au => au.AutoResponds)
                .WithOne(us => us.User)
                .HasForeignKey(fk=>fk.BelongToUserId);
            builder.HasMany(ms => ms.Messages)
                .WithOne(u => u.User)
                .HasForeignKey(fk => fk.SenderId);
            builder.HasOne(uca => uca.UserChatAppearance)
                .WithOne(u => u.User);

 
        }
    }
}
