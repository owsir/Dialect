using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Dialect.IRepository;
using Dialect.Model;

namespace Dialect.Repository
{
    public class ForumRepository: IForumRepository
    {
        private IDbConnection _conn;
        public IDbConnection Conn
        {
            get
            {
                return _conn = ConnectionFactory.CreateConnection();
            }
        }

        public int Insert_Forum(Forum forum)
        {
            using (_conn)
            {
                var sql = @"INSERT INTO forum 
                                    (homeprovince,homecity,livingcountry,livingprovince,livingcity)VALUES
                                    (@HomeProvince,@HomeCity,@LivingCountry,@LivingProvince,@LivingCity);";
                sql += "select LAST_INSERT_ID();";
                return Conn.ExecuteScalar<int>(sql, forum);
            }
        }

        public Forum Get_Forum(int id)
        {
            using (_conn)
            {
                var sql = @"SELECT * FROM `forum` where id=" + id;
                return Conn.Query<Forum>(sql).FirstOrDefault();
            }
        }

        public bool Is_Exist_Forum(Forum forum)
        {
            using (_conn)
            {
                const string sql = @"SELECT
                             COUNT(*)
                            FROM
                             forum
                            WHERE
                             homeprovince = @HomeProvince and 
                             homecity = @HomeCity and 
                             livingcountry = @LivingCountry and 
                             livingprovince = @LivingProvince and 
                             livingcity = @LivingCity";
                return int.Parse(Conn.ExecuteScalar(sql, forum).ToString())>0;
            }
        }
        public Forum Get_Forum_By_Route(ForumRoute forumRoute)
        {
            using (_conn)
            {
                const string sql = @"SELECT
                             *
                            FROM
                             forum
                            WHERE
                             homeprovince = @HomeProvince and 
                             homecity = @HomeCity and 
                             livingcountry = @LivingCountry and 
                             livingprovince = @LivingProvince and 
                             livingcity = @LivingCity";
                return Conn.Query<Forum>(sql, forumRoute).FirstOrDefault();
            }
        }

        public IEnumerable<Forum> Get_Forums()
        {
            using (_conn)
            {
                const string sql = @"SELECT * FROM `forum`";
                return Conn.Query<Forum>(sql);
            }
        }

        //public Tour Get_Article(int id)
        //{
        //    using (_conn)
        //    {
        //        var sql = @"SELECT * FROM `tours` where id="+id;
        //        return Conn.Query<Tour>(sql).FirstOrDefault();
        //    }
        //}
    }
}
