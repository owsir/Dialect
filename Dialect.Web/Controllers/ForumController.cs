using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dialect.ILogic;
using Dialect.Model;
using Dialect.Web.App_Start;
using Dialect.Web.ViewModels;

namespace Dialect.Web.Controllers
{
    [BasicAuthorize]
    public class ForumController : BaseController
    {
        private readonly IForumLogic _forumLogic;
        private readonly IForumPostLogic _forumPostLogic;

        public ForumController(IForumLogic forumLogic, IForumPostLogic forumPostLogic)
        {
            _forumLogic = forumLogic;
            _forumPostLogic = forumPostLogic;
        }

        public ActionResult Index()
        {
            var forumId = LoginUser.Forum.Id;
            var forums = _forumPostLogic.GetForumPostsByForumId(forumId).ToList();
            return View(forums);
        }

        [HttpGet]
        public ActionResult NewPost()
        {
            return View();
        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult NewPost(PostObjectViewModel model)
        {
            if (string.IsNullOrEmpty(model.Content))
            {
                ModelState.AddModelError("", "内容不能为空.");
                return View(model);
            }
            var forumId = LoginUser.Forum.Id;
            var postModel=new ForumPost
            {
                Title = model.Title,
                Content = model.Content,
                ForumId = forumId,
                UserId = LoginUser.User.Id,
                UserName = LoginUser.User.UserName
            };
            var postId = _forumPostLogic.InsertForumPost(postModel);
            return RedirectToAction("Index","ForumPost",new {id= postId});
        }
        
    }
}