using System.Collections.Generic;
using Dialect.Model;

namespace Dialect.IRepository
{
    public interface IPostReplyRepository
    {
        int Insert_PostReply(PostReply postReply);

        IEnumerable<PostReply> Get_PostReplies();

        IEnumerable<PostReply> Get_PostRepliesByPostId(int postId);
    }
}
