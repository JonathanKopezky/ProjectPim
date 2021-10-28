using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKopezkzky.src.config
{
    class Connection
    {
        SqlConnection conn = new SqlConnection();

        public Connection()
        {
            conn.ConnectionString = "";
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
