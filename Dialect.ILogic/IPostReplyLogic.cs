using System.Collections.Generic;
using Dialect.Model;

namespace Dialect.ILogic
{
    public interface IPostReplyLogic
    {
        int InsertPostReply(PostReply postReply);
        IEnumerable<PostReply> GetPostReplies();
        IEnumerable<PostReply> GetPostRepliesByPostId(int id);
    }
}
