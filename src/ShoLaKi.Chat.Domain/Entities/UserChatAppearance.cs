using ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType;
using ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType.GroupChat;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoLaKi.Chat.Domain.Entities
{
    public class UserChatAppearance
    {
        [Key]
        public int UserCchatAppearanceID {  get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        /*
        public List<Message> FrontMessage { get; set; }
        public ICollection<GroupChat>? GroupChats { get; set; }
        public ICollection<PersonalChat>? PersonalChats { get; set; }
        */
    }
}
