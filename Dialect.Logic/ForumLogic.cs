using System.Collections.Generic;
using Dialect.IRepository;
using Dialect.Model;
using Dialect.ILogic;

// ReSharper disable once CheckNamespace
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

        //public bool IsExistTour(string title) => _tourRepository.Is_Exist_Tour(title) >= 1;

        public IEnumerable<Forum> GetForums() => _forumRepository.Get_Forums();
    }
}
