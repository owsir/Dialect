using System.Collections.Generic;
using Dialect.Model;

namespace Dialect.ILogic
{
    public interface IUserLogic
    {
        int InsertUser(User user);
        IEnumerable<User> GetUsers();
    }
}
