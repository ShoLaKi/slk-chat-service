using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoLaKi.Chat.Domain.Entities;

namespace ShoLaKi.Chat.Infrastructure.Data.Configurations 
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Messages");

            builder.HasKey(m => m.MessageID);

            builder.Property(m => m.Content)
                .IsRequired(); 

            builder.Property(m => m.TimeSent)
                .HasDefaultValueSql("getutcdate()"); 

            builder.Property(m => isEdited); 

            builder.Property(m => EditedTime); 

            builder.HasOne(m => m.Sender) 
                .WithMany(u => u.SentMessages) 
                .HasForeignKey(m => m.SenderId);

        }
    }
}
