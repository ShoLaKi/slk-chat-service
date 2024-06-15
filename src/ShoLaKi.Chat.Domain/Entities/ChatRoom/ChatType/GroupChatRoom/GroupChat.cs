namespace ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType.GroupChatRoom
{
    public class GroupChat : Chat
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public DateTime TimestampCreated {  get; set; }
        public ICollection<User> Users { get; set; }

    }
}
