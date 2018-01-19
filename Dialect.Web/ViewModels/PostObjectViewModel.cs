using System.ComponentModel.DataAnnotations;

namespace Dialect.Web.ViewModels
{
    public class PostObjectViewModel
    {
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
    }
}