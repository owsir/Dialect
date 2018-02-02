using System.Collections.Generic;
using Dialect.IRepository;
using Dialect.Model;
using Dialect.ILogic;

namespace Dialect.Logic
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserRepository _userRepository;

        public UserLogic(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public int InsertUser(User user) => _userRepository.Insert_User(user);

        public IEnumerable<User> GetUsers() => _userRepository.Get_Users();

        public bool IsUserExist(string username)
        {
            var user = _userRepository.Get_UserByUserName(username);
            return user != null;
        }

        public User GetUserByUserName(string username)
        {
           return _userRepository.Get_UserByUserName(username);
        }

        public IEnumerable<User> GetUsersByForumId(int id)
        {
            return _userRepository.Get_UsersByForumId(id);
        }
    }
}
