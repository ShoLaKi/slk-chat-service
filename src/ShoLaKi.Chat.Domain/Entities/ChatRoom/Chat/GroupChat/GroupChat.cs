using System.ComponentModel.DataAnnotations;

namespace ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType.GroupChat
{
    public class GroupChat
    {
        [Key]
        public int ChatId { get; set; }
        public string? Password { get; set; }
        public ICollection<Message> Messages { get; set; }

        /*
        public int ChatCustomizationId { get; set; }
        public ChatCustomization ChatCustomization { get; set; } 
        

        public DateTime? CreatedTime { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedTime { get; set; }
        */
        public ICollection<GroupMember> GroupMembers { get; set; }
        //public Message FrontMess{ get; set; }
    }
}
