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
                var sql = @"INSERT INTO forumpost
                            (title,content,forumid,userid,username,createdate)
VALUES(@Title,@Content,@ForumId,@UserId,@UserName,NOW());";
                sql += "select LAST_INSERT_ID();";
                var postId= Conn.ExecuteScalar<int>(sql, forumPost);;
                return postId;
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

        public ForumPost Get_ForumPostByPostId(int postId)
        {
            using (_conn)
            {
                var sql = @"SELECT * FROM `forumpost` where id=" + postId + "";
                return Conn.Query<ForumPost>(sql).FirstOrDefault();
            }
        }

    }

}
