using System;
using CC_Cyx_Vansnick.DAL.IDAL;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CC_Cyx_Vansnick.Models.POCO;

namespace CC_Cyx_Vansnick.DAL
{
    public class LigneCommandsDAL: ILigneCommandsDAL
    {
        public string ConnectionString { get; private set; }

        public LigneCommandsDAL(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public bool CreateLC(int idCommand, int idArticle, int quantity)
        {
            bool success = false;
            string query = "INSERT INTO dbo.[LigneCommand] (idCommand, idArticle, Quantity) VALUES(@idCommand, @idArticle, @Quantity);";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("idCommand", idCommand);
                cmd.Parameters.AddWithValue("idArticle", idArticle);
                cmd.Parameters.AddWithValue("Quantity", quantity);
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                success = result > 0;
            }
            return success;
        }
    }
}
