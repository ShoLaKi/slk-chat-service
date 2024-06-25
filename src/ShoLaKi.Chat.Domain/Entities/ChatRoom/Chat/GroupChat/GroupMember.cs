using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoLaKi.Chat.Domain.Entities.ChatRoom.ChatType.GroupChat
{
    public class GroupMember
    {
        public int GroupId { get; set; }
        public GroupChat GroupChat { get; set; }
        public int UserId {  get; set; }
        public User User { get; set; } 
        public string AddedBy { get; set; }
        
        /*
        public Role Role { get; set; }
        */
    }
}
