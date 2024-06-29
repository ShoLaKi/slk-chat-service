using System;
using Microsoft.EntityFrameworkCore;
using ShoLaKi.Chat.Domain.Entities;
using ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType.GroupChat;
using ShoLaKi.Chat.Infrastructure.Data.Configurations;

namespace ShoLaKi.Chat.Infrastructure.Data 
{
    public class ChatDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<AutoResponds> AutoResponds { get; set; }
        public DbSet<UserChatAppearance> UserChatAppearances { get; set; } 
        public DbSet<GroupChat> GroupChats { get; set; }
        public DbSet<GroupMember> GroupMembers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new MessageConfiguration());
            modelBuilder.ApplyConfiguration(new AutoRespondsConfiguration());

            modelBuilder.ApplyConfiguration(new UserChatAppearanceConfiguration());

            modelBuilder.ApplyConfiguration(new GroupChatConfiguration());
            modelBuilder.ApplyConfiguration(new GroupMemberConfiguration());

        }
    }
}
