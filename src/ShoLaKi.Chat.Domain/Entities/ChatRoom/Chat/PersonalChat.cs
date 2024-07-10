using System.ComponentModel.DataAnnotations;

namespace ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType
{
    public class PersonalChat
    {
        [Key]
        public int ChatId { get; set; }
        public string? Password { get; set; }

        /*
        public int ChatCustomizationId { get; set; }
        public ChatCustomization ChatCustomization { get; set; } 
        

        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedTime { get; set; }

        */
        public ICollection <Message> Messages { get; set; }
        //public Message FrontMess { get; set; }
        public ICollection<User> ChatUsers { get; set; }
    }
}
