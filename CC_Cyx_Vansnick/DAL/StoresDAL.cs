using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using CC_Cyx_Vansnick.DAL.IDAL;
using CC_Cyx_Vansnick.Models.POCO;

namespace CC_Cyx_Vansnick.DAL
{
    public class StoresDAL : IStoresDAL
    {
        public string ConnectionString { get; private set; }

        public StoresDAL(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<Store> FindAllStore()
        {
            List<Store> stores = new List<Store>();
            string query = "SELECT * FROM dbo.[Store];";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Store s = new Store();
                        s.IdStore = reader.GetInt32("idStore");
                        s.Street = reader.GetString("Street");
                        s.Number = reader.GetString("Number");
                        s.City = reader.GetString("City");
                        s.PhoneNumber = reader.GetString("PhoneNumber");
                        stores.Add(s);
                    }
                }
            }
            return stores;
        }

    }
}
