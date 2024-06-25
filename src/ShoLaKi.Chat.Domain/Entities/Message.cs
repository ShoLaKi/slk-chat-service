using System.ComponentModel.DataAnnotations;

namespace ShoLaKi.Chat.Domain.Entities
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        public string Content { get; set; }
        public DateTime TimeSent { get; set; } = DateTime.UtcNow;
        public bool isEdited {  get; set; }
        public DateTime? EditedTime { get; set; }
        public int SenderId {  get; set; }

    }
}
