using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Dialect.Model;
using Dialect.ILogic;

namespace Dialect.WebApi.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUserLogic _userLogic;

        public UsersController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        [HttpGet]
        [Route("api/users")]
        public IEnumerable<User> GetUsers()
        {
            var users = _userLogic.GetUsers().ToList();
            return users;
        }
    }
}
