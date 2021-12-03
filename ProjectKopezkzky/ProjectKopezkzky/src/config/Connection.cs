using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectKopezkzky.src.config
{
    class Connection
    {
        SqlConnection conn = new SqlConnection();
        public Connection()
        {
          conn.ConnectionString = @"Data Source=kopezky-database.database.windows.net;Initial Catalog=Kopezky;Persist Security Info=True;User ID=kopezky;Password=Tico#2212123";
        }

        public SqlConnection connect()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
        public SqlConnection disconnect()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }
    }
}
