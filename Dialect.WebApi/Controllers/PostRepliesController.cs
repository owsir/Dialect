using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Dialect.ILogic;
using Dialect.Model;

namespace Dialect.WebApi.Controllers
{
    public class PostRepliesController : ApiController
    {
        private readonly IPostReplyLogic _postReplyLogic;

        public PostRepliesController(IPostReplyLogic postReplyLogic)
        {
            _postReplyLogic = postReplyLogic;
        }

        [HttpGet]
        [Route("api/postreplies")]
        public IEnumerable<PostReply> GetPostReplies()
        {
            var postReplies = _postReplyLogic.GetPostReplies().ToList();
            return postReplies;
        }

        [HttpGet]
        [Route("api/postreplies/{id}")]
        public IEnumerable<PostReply> GetPostRepliesByPostId(int id)
        {
            var postReplies = _postReplyLogic.GetPostRepliesByPostId(id).ToList();
            return postReplies;
        }

    }
}
