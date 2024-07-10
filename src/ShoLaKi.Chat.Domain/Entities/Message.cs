using ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType;
using ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType.GroupChat;
using System.ComponentModel.DataAnnotations;

namespace ShoLaKi.Chat.Domain.Entities
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        public string Content { get; set; }
        public int BelongWhichChat { get; set; }
        public GroupChat BelongToThisGroupChat { get; set; }
        public PersonalChat BelongToThisPersonalChat { get; set; }
        public DateTime TimeSent { get; set; } = DateTime.UtcNow;
        public bool isEdited {  get; set; }
        public DateTime? EditedTime { get; set; }
        public int SenderId {  get; set; }
        public User User { get; set; }

    }
}
