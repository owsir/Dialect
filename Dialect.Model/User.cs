namespace Dialect.Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string NickName { get; set; }
        public string HomeProvince { get; set; }
        public string HomeCity { get; set; }
        public string LivingCountry { get; set; }
        public string LivingProvince { get; set; }
        public string LivingCity { get; set; }
        public string Token { get; set; }
    }


    public class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }

}
