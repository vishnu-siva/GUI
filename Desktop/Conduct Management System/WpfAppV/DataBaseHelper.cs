using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ConductManagementSystem
{
    public class DataBaseHelper
    {
        private string connectionString = "Data Source=conducts.db;Version=3;";

        public void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Conducts (
                                  ConductID INTEGER PRIMARY KEY AUTOINCREMENT,
                                  Name TEXT NOT NULL,
                                  Email TEXT NOT NULL,
                                  Contact TEXT NOT NULL,
                                  Address TEXT NOT NULL)";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Conduct> GetAllConducts()
        {
            var conducts = new List<Conduct>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Conducts";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        conducts.Add(new Conduct
                        {
                            ConductID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Email = reader.GetString(2),
                            Contact = reader.GetString(3),
                            Address = reader.GetString(4)
                        });
                    }
                }
            }
            return conducts;
        }

        public void AddConduct(Conduct conduct)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Conducts (Name, Email, Contact, Address) VALUES (@Name, @Email, @Contact, @Address)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", conduct.Name);
                    command.Parameters.AddWithValue("@Email", conduct.Email);
                    command.Parameters.AddWithValue("@Contact", conduct.Contact);
                    command.Parameters.AddWithValue("@Address", conduct.Address);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateConduct(Conduct conduct)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Conducts SET Name = @Name, Email = @Email, Contact = @Contact, Address = @Address WHERE ConductID = @ConductID";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ConductID", conduct.ConductID);
                    command.Parameters.AddWithValue("@Name", conduct.Name);
                    command.Parameters.AddWithValue("@Email", conduct.Email);
                    command.Parameters.AddWithValue("@Contact", conduct.Contact);
                    command.Parameters.AddWithValue("@Address", conduct.Address);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteConduct(int ConductID)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Conducts WHERE ConductID = @ConductID";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ConductID", ConductID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
