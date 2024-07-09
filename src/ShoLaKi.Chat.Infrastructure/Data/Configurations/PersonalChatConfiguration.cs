using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoLaKi.Chat.Domain.Entities;
using ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType;

namespace ShoLaKi.Chat.Infrastructure.Data.Configurations
{   
    public class PersonalChatConfiguration :IEntityTypeConfiguration<PersonalChat>
    {
        public void Configure(EntityTypeBuilder<PersonalChat> builder)
        {
            builder.ToTable("PersonalChats");

            builder.HasKey(pc => pc.ChatId);

            builder.Property(pc => pc.Password)
                .HasMaxLength(50);
            builder.HasMany(ms => ms.Messages)
                .WithOne(pr => pr.BelongToThisPersonalChat)
                .HasForeignKey(ms => ms.BelongWhichChat);
            builder.HasMany(pm => pm.ChatUsers)
            .WithMany(pc => pc.PersonalChats);
            //builder.Property(fm=>fm.FrontMess); 
        }
    }
}
