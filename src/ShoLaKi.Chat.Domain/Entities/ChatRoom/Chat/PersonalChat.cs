namespace ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType
{
    public class PersonalChat
    {
        public int ChatId { get; set; }
        public string? Password { get; set; }

        /*
        public int ChatCustomizationId { get; set; }
        public ChatCustomization ChatCustomization { get; set; } 
        

        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedTime { get; set; }

        */

        public Message FrontMess { get; set; }
        public int SenderId { get; set; }
        public ICollection<User> ChatUsers { get; set; }
    }
}
