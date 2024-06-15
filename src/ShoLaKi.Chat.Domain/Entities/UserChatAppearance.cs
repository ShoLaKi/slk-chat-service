using System.ComponentModel.DataAnnotations;

namespace ShoLaKi.Chat.Domain.Entities
{
    public class UserChatAppearance
    {
        [Key]
        public int UCAID {  get; set; }
        public int UserID {  get; set; }
        public User User { get; set; }
        public ICollection<ShoLaKi.Chat.Domain.Entities.ChatRoom.Chat> Chats { get; set; }
    }
}
