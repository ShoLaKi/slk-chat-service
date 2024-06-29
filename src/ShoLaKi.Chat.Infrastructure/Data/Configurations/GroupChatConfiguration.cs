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

            builder.Property(gc => gc.ChatCustomizationId); 
            builder.HasOne(gc => gc.ChatCustomization)
                .WithOne(cc => cc.GroupChat) 
                .HasForeignKey<GroupChat>(gc => gc.ChatCustomizationId); 

            builder.Property(gc => gc.CreatedTime)
                .HasDefaultValueSql("getutcdate()"); 

            builder.Property(gc => gc.UpdatedTime);

            builder.HasMany(gc => gc.Members) 
                .WithMany(gm => gm.GroupChats)
                .UsingEntity<GroupMemberChat>(
                    j => j.HasOne(gmc => gmc.GroupChat).WithMany(gc => gc.GroupMemberChats).HasForeignKey(gmc => gmc.GroupChatId),
                    j => j.HasOne(gmc => gmc.Member).WithMany(m => m.GroupMemberChats).HasForeignKey(gmc => gmc.MemberId));

            builder.HasOne(gc => gc.FrontMess) 
                .WithOne(m => m.GroupChat) 
                .HasForeignKey<Message>(m => m.ChatId); 
        }
    }
}
