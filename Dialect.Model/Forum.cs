namespace Dialect.Model
{
    public class Forum
    {
        public int Id { get; set; }
        public string HomeProvince { get; set; }
        public string HomeCity { get; set; }
        public string LivingCountry { get; set; }
        public string LivingProvince { get; set; }
        public string LivingCity { get; set; }
    }

    public class ForumRoute
    {
        public string HomeProvince { get; set; }
        public string HomeCity { get; set; }
        public string LivingCountry { get; set; }
        public string LivingProvince { get; set; }
        public string LivingCity { get; set; }
    }
}
