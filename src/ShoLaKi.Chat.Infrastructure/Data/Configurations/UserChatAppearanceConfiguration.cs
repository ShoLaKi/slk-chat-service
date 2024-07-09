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
            builder.HasOne(uca => uca.User)
                .WithOne(u => u.UserChatAppearance);
        }
    }
}
