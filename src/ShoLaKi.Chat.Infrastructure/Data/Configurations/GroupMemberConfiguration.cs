using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType.GroupChat;

namespace ShoLaKi.Chat.Infrastructure.Data.Configurations
{
    public class GroupMemberConfiguration : IEntityTypeConfiguration<GroupMember>
    {
        public void Configure(EntityTypeBuilder<GroupMember> builder)
        {
            builder.ToTable("GroupMembers");

            builder.HasKey(gm => new { gm.GroupId, gm.UserId });

            builder.HasOne(gm => gm.GroupChat)
                .WithMany(gc => gc.Members)
                .HasForeignKey(gm => gm.GroupId);

            builder.HasOne(gm => gm.User)
                .WithMany(u => u.GroupMemberships)
                .HasForeignKey(gm => gm.UserId);

        }
    }
}
