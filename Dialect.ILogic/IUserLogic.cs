using System.Collections.Generic;
using Dialect.Model;

namespace Dialect.ILogic
{
    public interface IUserLogic
    {
        int InsertUser(User user);
        IEnumerable<User> GetUsers();
        bool IsUserExist(string username);
        User GetUserByUserName(string username);
        IEnumerable<User> GetUsersByForumId(int id);
    }
}
