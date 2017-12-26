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
                const string sql = @"INSERT  INTO forum
                            ( id ,
                              title ,
                              content ,
                              createTime
                            )
                    VALUES  ( @Id ,
                              @Title ,
                              @Content ,
                              @CreateTime
                            )";
                return Conn.Execute(sql, forum);
            }
        }

        //public int Is_Exist_Tour(string title)
        //{
        //    using (_conn)
        //    {
        //        const string sql = @"SELECT
	       //                     COUNT(*)
        //                    FROM
	       //                     tours
        //                    WHERE
	       //                     title = @Title";
        //        return int.Parse(Conn.ExecuteScalar(sql, new { Title = title }).ToString());
        //    }
        //}

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
