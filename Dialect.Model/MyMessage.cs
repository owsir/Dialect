using System;

namespace Dialect.Model
{
    public class MyMessage
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int FromUserId { get; set; }
        public int ToUserid { get; set; }
        public int FriendUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsRead { get; set; }
    }
}
