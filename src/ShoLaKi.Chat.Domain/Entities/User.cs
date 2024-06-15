using System.ComponentModel.DataAnnotations;

namespace ShoLaKi.Chat.Domain.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public UserStatus Status { get; set; }
        public UserType Type { get; set; }

        public void SetOnline()
        {
            Status = UserStatus.Online;
        }

        public void SetOffline()
        {
            Status = UserStatus.Offline;
        }

        public void ChangeType(UserType newType)
        {
            Type = newType;
        }
    }

    public enum UserStatus
    {
        Online,
        Offline
    }

    public enum UserType
    {
        Seller,
        Client
    }

}
