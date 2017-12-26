using System.Collections.Generic;
using Dialect.Model;

namespace Dialect.IRepository
{
    public interface IForumRepository
    {
        int Insert_Forum(Forum forum);

        IEnumerable<Forum> Get_Forums();
    }
}
