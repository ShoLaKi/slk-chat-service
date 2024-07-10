using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType.GroupChat;

namespace ShoLaKi.Chat.Infrastructure.Data.Configurations 
{
    public class GroupChatConfiguration : IEntityTypeConfiguration<GroupChat>
    {
        public void Configure(EntityTypeBuilder<GroupChat> builder)
        {
            builder.ToTable("GroupChats"); 

            builder.HasKey(gc => gc.ChatId); 

            builder.Property(gc => gc.Password)
                .HasMaxLength(50);
            builder.HasMany(gm => gm.GroupMembers)
                .WithOne(gc => gc.GroupChat);
            builder.HasMany(ms => ms.Messages)
                .WithOne(gr => gr.BelongToThisGroupChat)
                .HasForeignKey(ms=>ms.BelongWhichChat) ;
            //builder.Property(fm=>fm.FrontMess); 
        }
    }
}
