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
            return View(GetPostAndRepliesById(id));
        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult NewReply(ReplyObjectViewModel replyObjectViewModel)
        {
            if (string.IsNullOrEmpty(replyObjectViewModel.Content))
            {
                ModelState.AddModelError("", "内容不能为空.");
                return View("Index", GetPostAndRepliesById(replyObjectViewModel.PostId));
            }
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

        private ForumPostViewModel GetPostAndRepliesById(int id)
        {
            var post = _forumPostLogic.GetForumPostByPostId(id);
            var postReplies = _postReplyLogic.GetPostRepliesByPostId(id);
            var postAndReplies = new ForumPostViewModel
            {
                ForumPost = post,
                PostReplies = postReplies,
                ReplyObjectViewModel = new ReplyObjectViewModel
                {
                    PostId = id
                }
            };
            return postAndReplies;
        }

    }
}