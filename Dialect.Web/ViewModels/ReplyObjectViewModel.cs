using System.ComponentModel.DataAnnotations;

namespace Dialect.Web.ViewModels
{
    public class ReplyObjectViewModel
    {
        public int PostId { get; set; }
        [Required]
        [Display(Name = "内容")]
        public string Content { get; set; }
    }
}