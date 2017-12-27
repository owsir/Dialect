using System.Collections.Generic;
using Dialect.ILogic;
using Dialect.IRepository;
using Dialect.Model;

// ReSharper disable once CheckNamespace
namespace Dialect.Logic
{
    public class PostReplyLogic : IPostReplyLogic
    {
        private readonly IPostReplyRepository _postReplyRepository;

        public PostReplyLogic(IPostReplyRepository postReplyRepository)
        {
            _postReplyRepository = postReplyRepository;
        }

        public int InsertPostReply(PostReply postReply) => _postReplyRepository.Insert_PostReply(postReply);

        public IEnumerable<PostReply> GetPostReplies() => _postReplyRepository.Get_PostReplies();
        public IEnumerable<PostReply> GetPostRepliesByPostId(int id) => _postReplyRepository.Get_PostRepliesByPostId(id);
    }
}
