using CC_Cyx_Vansnick.DAL.IDAL;
using CC_Cyx_Vansnick.Models.POCO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace CC_Cyx_Vansnick.DAL
{
    public class UsersDAL : IUsersDAL
    {
        public string ConnectionString { get; private set; }

        public UsersDAL(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public bool CreateUser(Client client)
        {
            bool success = false;
            string query = "INSERT INTO dbo.[User] (FirstName, LastName, Type, Email, PhoneNumber, Address, Password) VALUES(@FirstName, @LastName, @Type, @Email, @PhoneNumber, @Address, @Password)";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("FirstName", client.FirstName);
                cmd.Parameters.AddWithValue("LastName", client.LastName);
                cmd.Parameters.AddWithValue("Type", "Client");
                cmd.Parameters.AddWithValue("Email", client.Email);
                cmd.Parameters.AddWithValue("Address", client.Address);
                cmd.Parameters.AddWithValue("PhoneNumber", client.PhoneNumber);
                cmd.Parameters.AddWithValue("Password", client.Password);
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                success = result > 0;
            }
            return success;
        }

        public Client FindUser(string email, string password)
        {
            Client client = null;
            string query = "SELECT * FROM dbo.[User] WHERE Email = @Email AND Password = @Password";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Parameters.AddWithValue("Password", password);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        client = new Client();
                        client.IdUser = reader.GetInt32("idUser");
                        client.FirstName = reader.GetString("FirstName");
                        client.LastName = reader.GetString("LastName");
                        client.Address = reader.GetString("Address");
                        client.PhoneNumber =Convert.ToString(reader.GetInt32("PhoneNumber"));
                        client.Password = reader.GetString("Password");
                        client.Type = reader.GetString("Type");
                        client.Email = reader.GetString("Email");
                    }
                }

            }
            return client;
        }

        public User FindUserById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
