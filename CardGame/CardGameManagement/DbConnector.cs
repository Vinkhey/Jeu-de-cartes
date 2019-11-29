using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameManagement
{
    public class DbConnector
    {
        private MySqlConnection connection;

        public DbConnector()
        {
            InitConnection();
        }

        private void InitConnection()
        {
            // Creation of the connection string : where, who
            // Avoid user id and pwd hardcoded
            string connectionString = "SERVER=127.0.0.1; UID=root; PASSWORD=Pa$$w0rd";
            connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CreateDatabase()
        {
            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = "CREATE DATABASE IF NOT EXISTS CardGame; USE CardGame; CREATE TABLE CardGame.Users(idUsers INT, Email VARCHAR(20), PasswordHash VARCHAR(20)); ALTER TABLE Users ADD CONSTRAINT PRIMARY KEY(idUsers); ";

            // Execute the SQL command
            cmd.ExecuteNonQuery();
        }
    }
}
