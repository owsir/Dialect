using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Dialect.IRepository;
using Dialect.Model;

namespace Dialect.Repository
{
    public class ForumPostRepository : IForumPostRepository
    {
        private IDbConnection _conn;
        public IDbConnection Conn
        {
            get
            {
                return _conn = ConnectionFactory.CreateConnection();
            }
        }

        public int Insert_ForumPost(ForumPost forumPost)
        {
            using (_conn)
            {
                const string sql = @"INSERT  INTO forumpost
                            (id,title,content,forumid,userid,username,createTime)VALUES
                            (@Id,@Title,@Content,@ForumId,@UserId,@UserName,NOW())";
                return Conn.Execute(sql, forumPost);
            }
        }

        public IEnumerable<ForumPost> Get_ForumPosts()
        {
            using (_conn)
            {
                const string sql = @"SELECT * FROM `forumpost`";
                return Conn.Query<ForumPost>(sql);
            }
        }

        public IEnumerable<ForumPost> Get_ForumPostsByForumId(int forumId)
        {
            using (_conn)
            {
                var sql = @"SELECT * FROM `forumpost` where forumid="+ forumId+"";
                return Conn.Query<ForumPost>(sql);
            }
        }

    }

}
