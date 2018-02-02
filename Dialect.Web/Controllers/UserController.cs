using System.Web.Mvc;
using Dialect.ILogic;

namespace Dialect.Web.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserLogic _userLogic;

        public UserController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        public ActionResult Index(string userName)
        {
            var user = _userLogic.GetUserByUserName(userName);
            return View(user);
        }

        public ActionResult List()
        {
            var users = _userLogic.GetUsersByForumId(LoginUser.Forum.Id);
            return View(users);
        }
    }
}