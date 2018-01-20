using Dialect.Model;

namespace Dialect.Web.ViewModels
{
    public class UserViewModel
    {
        public User User { get; set; }
        public Forum Forum { get; set; }
        public string UserForumName => string.Concat(User.HomeCity, "人在", User.LivingCity);
    }
}