using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Data
{
    public class dConecction
    {
        private SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Conecction"].ConnectionString);

        //Allow to connect to DB
        public SqlConnection OpenConn()
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            return Conn;
        }

        //Allow to end connection to DB
        public SqlConnection CloseConn()
        {
            if (Conn.State == ConnectionState.Open)
                Conn.Close();
            return Conn;
        }

    }
}
