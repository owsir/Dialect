using System.Collections.Generic;
using Dialect.Model;

namespace Dialect.IRepository
{
    public interface IUserRepository
    {
        int Insert_User(User user);
        IEnumerable<User> Get_Users();
        User Get_UserByUserName(string name);
        User Get_UserByUserId(int id);
    }
}
