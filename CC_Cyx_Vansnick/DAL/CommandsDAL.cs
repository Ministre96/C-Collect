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
    public class CommandsDAL : ICommandsDAL
    {
        public string ConnectionString { get; private set; }

        public CommandsDAL(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<Command> FindCommand(int idStore, int delay)
        {
            List<Command> commands = new List<Command>();
            string query = "SELECT * FROM dbo.[Command] WHERE TIMESLOT = @Year-@Month-@Day";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("Year", DateTime.Today.Year);
                cmd.Parameters.AddWithValue("Month", DateTime.Today.Month);
                cmd.Parameters.AddWithValue("Day", DateTime.Today.Day+delay);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Command c = new Command();
                        c.IdCommand = reader.GetInt32("IdCommand");
                        c.NbrBox = reader.GetInt32("NbrBox");
                        c.OrderPickUp = reader.GetDateTime("TimeSlot");
                        commands.Add(c);
                    }
                }
            }
            foreach (Command item in commands)
            {
                
            }
            return commands;
        }

        public bool VerifyTimeSLot(int idStore, DateTime date, int maxSlot)
        {
            string query = "SELECT COUNT * AS cpt FROM dbo.[Command] WHERE IDSTORE = @IdStore AND TIMESLOT = @Year-@Month-@Day";
            int result = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("IdStore", idStore);
                cmd.Parameters.AddWithValue("Year", date.Year);
                cmd.Parameters.AddWithValue("Month", date.Month);
                cmd.Parameters.AddWithValue("Day", date.Day);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result = reader.GetInt32("cpt");
                    }
                }
            }
            if (result < maxSlot)
            {
                return true;
            }
            return false;
        }

        public bool CreateCommand(Command command, int idClient)
        {
            bool success = false;
            string query = "INSERT INTO dbo.[Users] (TimeSlot, NbrBox, Paid, IdClient) VALUES(@TimeSlot, @NbrBox, @Address, @Paid, @IdClient);";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("TimeSlot", command.OrderPickUp);
                cmd.Parameters.AddWithValue("NbrBox", command.NbrBox);
                cmd.Parameters.AddWithValue("Paid", command.Paid);
                cmd.Parameters.AddWithValue("IdClient", idClient);
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                success = result > 0;
            }
            return success;
        }
        public bool DeleteCommand(int idCommand)
        {
            bool success = false;
            string query = "DELETE FROM dbo.[Command] WHERE IdCommand = @IdCommand;";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("TimeSlot", idCommand);
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                success = result > 0;
            }
            return success;
        }
    }
}
