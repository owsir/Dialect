using System;

namespace Dialect.Model
{
    public class ForumPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ForumId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int? ReplyCount { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsAdminDelete { get; set; }
    }
}
