using System;

namespace Dialect.Model
{
    public class MyFriend
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FriendUserId { get; set; }
        public string FriendUserName { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
