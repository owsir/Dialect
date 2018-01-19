using System.Collections.Generic;
using Dialect.IRepository;
using Dialect.Model;
using Dialect.ILogic;

namespace Dialect.Logic
{
    public class ForumLogic: IForumLogic
    {
        private readonly IForumRepository _forumRepository;

        public ForumLogic(IForumRepository forumRepository)
        {
            _forumRepository = forumRepository;
        }

        public int InsertForum(Forum forum) => _forumRepository.Insert_Forum(forum);

        public Forum GetForum(int id) => _forumRepository.Get_Forum(id);

        public Forum GetForumByRoute(ForumRoute forumRoute) => _forumRepository.Get_Forum_By_Route(forumRoute);

        public IEnumerable<Forum> GetForums() => _forumRepository.Get_Forums();
    }
}
