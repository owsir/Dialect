using System.ComponentModel.DataAnnotations;

namespace Dialect.Web.ViewModels
{
    public class ReplyObjectViewModel
    {
        public int PostId { get; set; }
        [Required]
        public string Content { get; set; }
    }
}