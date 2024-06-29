using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoLaKi.Chat.Domain.Entities;

namespace ShoLaKi.Chat.Infrastructure.Data.Configurations 
{
    public class UserChatAppearanceConfiguration : IEntityTypeConfiguration<UserChatAppearance>
    {
        public void Configure(EntityTypeBuilder<UserChatAppearance> builder)
        {
            builder.ToTable("UserChatAppearances"); 
            builder.HasKey(uca => uca.UserCchatAppearanceID);

            builder.Property(uca => uca.UserID)
                .IsRequired(); 

            builder.HasOne(uca => uca.User) 
                .WithMany(u => u.ChatAppearances) 
                .HasForeignKey(uca => uca.UserID);

            builder.Property(uca => uca.Nickname);
            builder.Property(uca => uca.ColorTheme);
        }
    }
}
