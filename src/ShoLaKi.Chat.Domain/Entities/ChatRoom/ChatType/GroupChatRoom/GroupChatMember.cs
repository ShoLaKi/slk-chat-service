using System.ComponentModel.DataAnnotations;

namespace ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType.GroupChatRoom
{
    public class GroupChatMember
    {
        [Key]
        public int GroupChatId { get; set; }
        public GroupChat GroupChat { get; set; }
        public int UserID {  get; set; }
        public User User { get; set; }
        /*
        string Role UserRole {get;set;}
        */


    }
}
