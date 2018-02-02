using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Dialect.ILogic;
using Dialect.Web.App_Start;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Dialect.Web.Models;

namespace Dialect.Web.Controllers
{
    [BasicAuthorize]
    public class ManageController : BaseController
    {
        private readonly IUserLogic _userLogic;
        private readonly IForumPostLogic _forumPostLogic;

        public ManageController(IUserLogic userLogic, IForumPostLogic forumPostLogic)
        {
            _userLogic = userLogic;
            _forumPostLogic = forumPostLogic;
        }

        public ActionResult Index()
        {
            return View(LoginUser);
        }
        public ActionResult EditProfile()
        {
            return View(LoginUser);
        }

        public ActionResult MyPosts()
        {
            var posts = _forumPostLogic.GetPostsByUserId(LoginUser.User.Id);
            return View(posts);
        }

        public ActionResult MyFriends()
        {
            var user = LoginUser.User;
            return View();
        }

        public ActionResult MyMessages()
        {
            var user = LoginUser.User;
            return View();
        }
    }
}