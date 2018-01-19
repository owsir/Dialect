using System.Collections.Generic;
using Dialect.Model;

namespace Dialect.Web.ViewModels
{
    public class ForumPostViewModel
    {
        public ForumPost ForumPost { get; set; }
        public IEnumerable<PostReply> PostReplies { get; set; }
        public ReplyObjectViewModel ReplyObjectViewModel { get; set; }
    }
}