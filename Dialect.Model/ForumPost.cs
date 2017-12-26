using System;

namespace Dialect.Model
{
    public class ForumPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ForumId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsAdminDelete { get; set; }
    }
}
