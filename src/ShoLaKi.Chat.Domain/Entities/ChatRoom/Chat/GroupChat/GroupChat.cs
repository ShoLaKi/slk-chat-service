using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType.GroupChat
{
    public class GroupChat
    {
        public int ChatId { get; set; }
        public string? Password { get; set; }

        /*
        public int ChatCustomizationId { get; set; }
        public ChatCustomization ChatCustomization { get; set; } 
        

        public DateTime? CreatedTime { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedTime { get; set; }
        */
        public ICollection<GroupMember> Members { get; set; }
        public Message FrontMess
        {
            get; set;
        }
    }
}
