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
    public class EmployeesDAL : IEmployeesDAL
    {
         public string ConnectionString { get; private set; }
        public EmployeesDAL(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public Employee FindEmployee(string email, string password)
        {
            Employee emp = null;
            string query = "SELECT * FROM dbo.[Employee] WHERE Email = @Email AND Password = @Password";
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
                        if (reader.GetString("Type") == "OrderPicker")
                        {
                            emp = new OrderPicker();
                            emp.IdUser = reader.GetInt32("idUser");
                            emp.FirstName = reader.GetString("FirstName");
                            emp.LastName = reader.GetString("LastName");
                            emp.Address = reader.GetString("Address");
                            emp.PhoneNumber = Convert.ToString(reader.GetInt32("PhoneNumber"));
                            emp.Password = reader.GetString("Password");
                            emp.Type = reader.GetString("Type");
                            emp.Email = reader.GetString("Email");
                            emp.IdStore = reader.GetInt32("IdStore");
                        }
                        else
                        {
                            emp = new Cashier();
                            emp.IdUser = reader.GetInt32("idUser");
                            emp.FirstName = reader.GetString("FirstName");
                            emp.LastName = reader.GetString("LastName");
                            emp.Address = reader.GetString("Address");
                            emp.PhoneNumber = Convert.ToString(reader.GetInt32("PhoneNumber"));
                            emp.Password = reader.GetString("Password");
                            emp.Type = reader.GetString("Type");
                            emp.Email = reader.GetString("Email");
                            emp.IdStore = reader.GetInt32("IdStore");
                        }
                    }
                }
            }
            return emp;
        }
            
       
    }
}
