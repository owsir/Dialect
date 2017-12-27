using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Dialect.ILogic;
using Dialect.Model;

namespace Dialect.WebApi.Controllers
{
    public class ForumPostsController : ApiController
    {
        private readonly IForumPostLogic _forumPostLogic;

        public ForumPostsController(IForumPostLogic forumPostLogic)
        {
            _forumPostLogic = forumPostLogic;
        }

        [HttpGet]
        [Route("api/forumposts")]
        public IEnumerable<ForumPost> GetForumPosts()
        {
            var forumPosts = _forumPostLogic.GetForumPosts().ToList();
            return forumPosts;
        }

        [HttpGet]
        [Route("api/forumposts/{id}")]
        public IEnumerable<ForumPost> GetForumPostsByForumId(int id)
        {
            var forumPosts = _forumPostLogic.GetForumPostsByForumId(id).ToList();
            return forumPosts;
        }
    }
}
