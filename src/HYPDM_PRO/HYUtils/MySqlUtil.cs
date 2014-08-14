using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;

namespace HYUtils
{
    public class MySqlUtil
    {
        public static DataTable Query(string sql)
        {
            using (var conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectString()))
            {
                conn.Open();
                var adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sql, conn);
                var ds = new DataSet();
                var reader = adapter.Fill(ds);
                conn.Close();
                return ds.Tables[0];
            }
        }
        public static int Execute(string sql)
        {
            using (var conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectString()))
            {
                conn.Open();
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                return i;
            }
        }
        public static int GetMaxID(string tablename)
        {
            string sql = "SELECT MAX(ID) MAXID FROM " + tablename;
            return Convert.ToInt32(Query(sql).Rows[0]["MAXID"]);
        }
        public static string ConnectString()
        {
            return "Database=hypdm;Data Source=192.168.0.8;User Id=root;Password=123456;charset=utf8;pooling=true";
        }
    }
}
