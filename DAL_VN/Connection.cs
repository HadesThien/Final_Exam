using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_VN
{
    public class Connection
    {
        private static SqlConnection conn;
        public static void connect()
        {
            string s = "Data Source=TAANS;Initial Catalog=Vietnam;User ID=ngphctn14;Password=nuttertools123;";
            conn = new SqlConnection(s);
            conn.Open();
        }
        public static void actionQuery(string sql)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        
        public static DataTable selectQuery(string sql)
        {
            connect();
            SqlDataAdapter adpt = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }

    }
}
