using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Dialect.IRepository;
using Dialect.Model;

namespace Dialect.Repository
{
    public class MyFriendsRepository : IMyFriendsRepository
    {
        private IDbConnection _conn;
        public IDbConnection Conn
        {
            get
            {
                return _conn = ConnectionFactory.CreateConnection();
            }
        }

        public int Insert_Friend(MyFriend friend)
        {
            using (_conn)
            {
                const string sql = @"INSERT INTO myfriend 
                                    (userid,frienduserid,createdate)VALUES
                                    (@UserId,@FriendUserId,NOW());";
                return Conn.Execute(sql, friend);
            }
        }

        public IEnumerable<MyFriend> Get_Friends(int userid)
        {
            using (_conn)
            {
                var sql = @"SELECT * FROM `myfriend`where userid = " + userid + "";
                return Conn.Query<MyFriend>(sql);
            }
        }

        public int Delete_Friend(int id)
        {
            using (_conn)
            {
                var sql = @"DELETE FROM `myfriend` where id=" + id + "";
                return Conn.Execute(sql);
            }
        }

    }

}
