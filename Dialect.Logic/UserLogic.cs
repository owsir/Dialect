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
    }
}
