﻿using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Dialect.Repository
{
    public class ConnectionFactory
    {
        private static readonly string ConnectionName = ConfigurationManager.AppSettings["ConnectionName"];

        private static readonly string MysqlConnectionString =
            ConfigurationManager.ConnectionStrings["mysqlConnectionString"].ConnectionString;

        public static IDbConnection CreateConnection()
        {
            IDbConnection conn;
            switch (ConnectionName)
            {
                case "MySQL":
                    conn = new MySqlConnection(MysqlConnectionString);
                    break;
                default:
                    conn = new SqlConnection(MysqlConnectionString);
                    break;
            }
            conn.Open();
            return conn;
        }
    }
}
