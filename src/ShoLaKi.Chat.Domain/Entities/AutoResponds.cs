using System.ComponentModel.DataAnnotations;

namespace ShoLaKi.Chat.Domain.Entities
{
    public class AutoResponds
    {
        [Key]
        public int AutoRespondId { get; set; }
        public int BelongToUserId { get; set; }
        public User User { get; set; }
        public string RespondsText {  get; set; }
        public DateTime? TimestampSent {  get; set; }
        public string TriggerCondition { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
