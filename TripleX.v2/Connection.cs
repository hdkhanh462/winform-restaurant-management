using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TripleX.v2
{
    internal class Connection
    {
        private static string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TripleX;Integrated Security=True";
        //private static string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=" + System.IO.Path.GetFullPath("WibuSaver.mdf") + ";Integrated Security=True;Connect Timeout=15";
        public static SqlConnection conn = new SqlConnection(_connectionString);
        public static void Connect()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
        }

        public static void DisConnect()
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
        }
    }
}
