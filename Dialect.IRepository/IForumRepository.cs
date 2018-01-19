using System.Collections.Generic;
using Dialect.Model;

namespace Dialect.IRepository
{
    public interface IForumRepository
    {
        int Insert_Forum(Forum forum);

        IEnumerable<Forum> Get_Forums();

        Forum Get_Forum(int id);

        bool Is_Exist_Forum(Forum forum);
        Forum Get_Forum_By_Route(ForumRoute forumRoute);
    }
}
