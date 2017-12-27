using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Dialect.IRepository;
using Dialect.Model;

namespace Dialect.Repository
{
    public class PostReplyRepository : IPostReplyRepository
    {
        private IDbConnection _conn;
        public IDbConnection Conn
        {
            get
            {
                return _conn = ConnectionFactory.CreateConnection();
            }
        }

        public int Insert_PostReply(PostReply postReply)
        {
            using (_conn)
            {
                const string sql = @"INSERT INTO postreply
                            (content,postid,userid,username,createdate)
                    VALUES  (@Content,@PostId,@UserId,@UserName,NOW())";
                return Conn.Execute(sql, postReply);
            }
        }

        public IEnumerable<PostReply> Get_PostReplies()
        {
            using (_conn)
            {
                const string sql = @"SELECT * FROM `postreply`";
                return Conn.Query<PostReply>(sql);
            }
        }

        public IEnumerable<PostReply> Get_PostRepliesByPostId(int postId)
        {
            using (_conn)
            {
                var sql = @"SELECT * FROM `postreply` where postid=" + postId + "";
                return Conn.Query<PostReply>(sql);
            }
            
        }
    }
}
