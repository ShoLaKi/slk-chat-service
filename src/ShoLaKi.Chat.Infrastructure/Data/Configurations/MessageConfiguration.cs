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

            builder.HasKey(mId => mId.MessageID);

            builder.Property(ct => ct.Content)
                .IsRequired(); 

            builder.Property(tS => tS.TimeSent)
                .HasDefaultValueSql("getutcdate()");
            builder.HasOne(bl => bl.BelongToThisGroupChat)
                .WithMany (ms=>ms.Messages)
                .HasForeignKey(id=>id.BelongWhichChat);
            builder.HasOne(bl => bl.BelongToThisPersonalChat)
                .WithMany(ms => ms.Messages)
                .HasForeignKey(id => id.BelongWhichChat);
            builder.Property(iE => iE.isEdited)
                .HasDefaultValue(false);
            builder.Property(eT=> eT.EditedTime);
            builder.HasOne(us=>us.User)
                .WithMany(bl=>bl.Messages) 
                .HasForeignKey(id=>id.SenderId);

        }
    }
}
