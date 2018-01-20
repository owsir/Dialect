using System.ComponentModel.DataAnnotations;

namespace Dialect.Web.ViewModels
{
    public class PostObjectViewModel
    {
        [Display(Name = "标题")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "内容")]
        public string Content { get; set; }
    }
}