using System.Collections.Generic;
using System.Data;
using Dapper;
using Dialect.IRepository;
using Dialect.Model;

namespace Dialect.Repository
{
    public class UserRepository : IUserRepository
    {
        private IDbConnection _conn;
        public IDbConnection Conn
        {
            get
            {
                return _conn = ConnectionFactory.CreateConnection();
            }
        }

        public int Insert_User(User user)
        {
            using (_conn)
            {
                const string sql = @"insert into user
                            (username,userpassword,homeprovince,homecity,livingcountry,livingprovince,livingcity,createdate)
                    values (@UserName,@UserPassword,@HomeProvince,@homecity,@livingcountry,@livingprovince,@livingcity,NOW())";
                return Conn.Execute(sql, user);
            }
        }

        public IEnumerable<User> Get_Users()
        {
            using (_conn)
            {
                const string sql = @"SELECT * FROM `user`";
                return Conn.Query<User>(sql);
            }
        }
    }
}
