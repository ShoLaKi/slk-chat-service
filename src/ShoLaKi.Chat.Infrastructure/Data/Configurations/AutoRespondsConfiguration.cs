using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoLaKi.Chat.Domain.Entities;

namespace ShoLaKi.Chat.Infrastructure.Data.Configurations
{
    public class AutoRespondsConfiguration : IEntityTypeConfiguration<AutoResponds>
    {
        public void Configure(EntityTypeBuilder<AutoResponds> builder)
        {
            builder.ToTable("AutoResponds");
            builder.HasKey(a => a.AutoRespondId);

            builder.Property(a => a.RespondsText)
                .IsRequired();

            builder.Property(a => a.TimeSent);

            builder.Property(a => a.TriggerCondition)
                .IsRequired();

            builder.Property(a => a.IsActive)
                .HasDefaultValue(true);

            builder.HasOne(a => a.User)
                .WithMany(u => u.AutoResponds)
                .HasForeignKey(a => a.BelongToUserId);
        }
    }
}
