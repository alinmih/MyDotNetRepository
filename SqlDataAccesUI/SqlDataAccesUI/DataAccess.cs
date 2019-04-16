using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SqlDataAccesUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("OrdersDB")))
            {
                //var output = connection.Query<Person>($"Select * from People where Name='{ name }'").ToList();
                var output = connection.Query<Person>("dbo.People_GetByName @Name", new { Name = name }).ToList();
                return output;
            }
        }

        public void InsertPerson(string name, string location, string phone)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("OrdersDB")))
            {
                Person newPerson = new Person { Name= name, Location= location, Phone=phone};
                List<Person> people = new List<Person>();
                people.Add(newPerson);
                connection.Execute("dbo.People_Insert @Name, @Location, @Phone", people);
            }
        }
    }
}
