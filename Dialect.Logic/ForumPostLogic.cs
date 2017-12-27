using System.Collections.Generic;
using Dialect.ILogic;
using Dialect.IRepository;
using Dialect.Model;

// ReSharper disable once CheckNamespace
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

        public IEnumerable<ForumPost> GetForumPostsByForumId(int id) => _forumPostRepository.Get_ForumPostsByForumId(id);
    }
}
