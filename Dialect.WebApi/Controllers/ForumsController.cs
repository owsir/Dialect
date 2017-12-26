using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Dialect.Model;
using Dialect.ILogic;

namespace Dialect.WebApi.Controllers
{
    public class ForumsController : ApiController
    {
        private readonly IForumLogic _forumLogic;

        public ForumsController(IForumLogic forumLogic)
        {
            _forumLogic = forumLogic;
        }

        [HttpGet]
        [Route("api/forums")]
        public IEnumerable<Forum> GetForums()
        {
            var forums = _forumLogic.GetForums().ToList();
            return forums;
        }

    }
}
