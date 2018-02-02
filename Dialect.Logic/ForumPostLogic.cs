using System.Collections.Generic;
using System.Linq;
using Dialect.ILogic;
using Dialect.IRepository;
using Dialect.Model;

namespace Dialect.Logic
{
    public class ForumPostLogic : IForumPostLogic
    {
        private readonly IForumPostRepository _forumPostRepository;

        public ForumPostLogic(IForumPostRepository forumPostRepository)
        {
            _forumPostRepository = forumPostRepository;
        }

        public int InsertForumPost(ForumPost forumPost) => _forumPostRepository.Insert_ForumPost(forumPost);

        public IEnumerable<ForumPost> GetForumPosts() => _forumPostRepository.Get_ForumPosts();

        public IEnumerable<ForumPost> GetForumPostsByForumId(int forumId) => _forumPostRepository.Get_ForumPostsByForumId(forumId).OrderByDescending(x=>x.Id);

        public ForumPost GetForumPostByPostId(int postId) => _forumPostRepository.Get_ForumPostByPostId(postId);
        public IEnumerable<ForumPost> GetPostsByUserId(int userid) => _forumPostRepository.Get_PostsByUserId(userid);
    }
}
