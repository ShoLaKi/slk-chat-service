using ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType;
using ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType.GroupChat;
using System.ComponentModel.DataAnnotations;

namespace ShoLaKi.Chat.Domain.Entities
{
    public class UserChatAppearance
    {
        [Key]
        public int UserCchatAppearanceID {  get; set; }
        public int UserID {  get; set; }
        public User User { get; set; }
        public ICollection<GroupChat>? GroupChats { get; set; }
        public ICollection<PersonalChat>? PersonalChats { get; set; }
    }
}
