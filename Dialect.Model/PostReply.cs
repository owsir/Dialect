using System;

namespace Dialect.Model
{
    public class PostReply
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string UserName { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsAdminDelete { get; set; }
    }
}
