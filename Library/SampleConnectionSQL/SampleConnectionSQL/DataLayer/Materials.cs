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

        private int id;
        private int customerId;
        private int unitID;
        private int materialNumber;
        private string description;
        private double price;


        public int Id { get => id; set => id = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public int UnitID { get => unitID; set => unitID = value; }
        public int MaterialNumber { get => materialNumber; set => materialNumber = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }


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

        public void InsertMaterial()
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

        public void EditMaterial()
        {
            Command.Connection = Connection.OpenConnection();
            Command.CommandText = $"update Materials set CustomerId={customerId}, UnitId={unitID}, MaterialNumber={materialNumber}, Description='{description}', Price={price} where Id={id}";
            Command.CommandType = CommandType.Text;
            Command.ExecuteNonQuery();
            Connection.CloseConnection();
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

        public DataTable MaterialsListRaw()
        {
            DataTable Data = new DataTable();
            Command.Connection = Connection.OpenConnection();
            Command.CommandText = "Sp_MaterialsListRaw";
            Command.CommandType = CommandType.StoredProcedure;
            Reader = Command.ExecuteReader();
            Data.Load(Reader);
            Reader.Close();
            Connection.CloseConnection();
            return Data;
        }

        public void DeleteProduct()
        {
            Command.Connection = Connection.OpenConnection();
            Command.CommandText = $"delete from Materials where Id={id}";
            Command.CommandType = CommandType.Text;
            Command.ExecuteNonQuery();
            Connection.CloseConnection();
        }



    }
}
