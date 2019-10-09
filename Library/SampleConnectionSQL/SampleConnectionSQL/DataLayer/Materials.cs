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
    public class Materials
    {
        private ConnectionDB Connection = new ConnectionDB();
        private SqlCommand Command = new SqlCommand();
        private SqlDataReader Reader;

        public DataTable MaterialUnitList()
        {
            DataTable Data = new DataTable();
            Command.Connection = Connection.OpenConnection();
            Command.CommandText = "sp_GetMaterialUnitList";
            Command.CommandType = CommandType.StoredProcedure;
            Reader = Command.ExecuteReader();
            Data.Load(Reader);
            Reader.Close();
            Connection.CloseConnection();
            return Data;
        }

        public DataTable CustomersList()
        {
            DataTable Data = new DataTable();
            Command.Connection = Connection.OpenConnection();
            Command.CommandText = "sp_GetCustomerList";
            Command.CommandType = CommandType.StoredProcedure;
            Reader = Command.ExecuteReader();
            Data.Load(Reader);
            Reader.Close();
            Connection.CloseConnection();
            return Data;
        }

        public void InsertMaterial(int customerId, int unitID, int materialNumber, string description, double price)
        {
            Command.Connection = Connection.OpenConnection();
            Command.CommandText = "sp_InsertMaterial";
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@UnitId", unitID);
            Command.Parameters.AddWithValue("@CustomerId",customerId );
            Command.Parameters.AddWithValue("@MaterialNumber", materialNumber);
            Command.Parameters.AddWithValue("@Description", description);
            Command.Parameters.AddWithValue("@Price", price);
            Command.ExecuteNonQuery();
            Command.Parameters.Clear();

        }

        public DataTable MaterialsList()
        {
            DataTable Data = new DataTable();
            Command.Connection = Connection.OpenConnection();
            Command.CommandText = "sp_GetMaterials";
            Command.CommandType = CommandType.StoredProcedure;
            Reader = Command.ExecuteReader();
            Data.Load(Reader);
            Reader.Close();
            Connection.CloseConnection();
            return Data;
        }



    }
}
