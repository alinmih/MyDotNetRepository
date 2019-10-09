using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SampleConnectionSQL.DataLayer
{
    public class ConnectionDB
    {
        static private string ConnectionString = "Server=.; DataBase=ProductionMes; Integrated Security= true ";

        private SqlConnection connection = new SqlConnection(ConnectionString);

        public SqlConnection OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public SqlConnection CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }


    }
}
