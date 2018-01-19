using System.Web.Mvc;
using Dialect.ILogic;
using Dialect.Model;
using Dialect.Web.App_Start;
using Dialect.Web.ViewModels;

namespace Dialect.Web.Controllers
{
    [BasicAuthorize]
    public class ForumPostController : BaseController
    {
        private readonly IForumPostLogic _forumPostLogic;
        private readonly IPostReplyLogic _postReplyLogic;

        public ForumPostController(IForumPostLogic forumPostLogic, IPostReplyLogic postReplyLogic)
        {
            _forumPostLogic = forumPostLogic;
            _postReplyLogic = postReplyLogic;
        }

        public ActionResult Index(int id)
        {
            var post = _forumPostLogic.GetForumPostByPostId(id);
            var postReplies = _postReplyLogic.GetPostRepliesByPostId(id);
            var viewModel = new ForumPostViewModel
            {
                ForumPost = post,
                PostReplies = postReplies,
                ReplyObjectViewModel = new ReplyObjectViewModel
                {
                    PostId = id
                }
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult NewReply(ReplyObjectViewModel replyObjectViewModel)
        {
            var replyModel=new PostReply()
            {
                Content = replyObjectViewModel.Content,
                PostId = replyObjectViewModel.PostId,
                UserId = LoginUser.User.Id,
                UserName = LoginUser.User.UserName
            };
            _postReplyLogic.InsertPostReply(replyModel);
            return RedirectToAction("Index", "ForumPost", new { id = replyObjectViewModel.PostId });
        }
    }
}