namespace ShoLaKi.Chat.Domain.Entities.ChatRoom
{
    public class Chat
    {
        public int ChatId { get; set; }
        public chatType Type { get; set; }
        public string Password { get; set; }

        /*
        public int ChatCustomizationId { get; set; }
        public ChatCustomization ChatCustomization { get; set; } 
        */

        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedTime { get; set; }

        public Message FrontMess { get; set; }
    }

    public enum chatType
    {
        Private,
        Group
    }

}
