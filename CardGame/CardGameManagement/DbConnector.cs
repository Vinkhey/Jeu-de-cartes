using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string connectionString = "SERVER=127.0.0.1; UID=root; PASSWORD=Pa$$w0rd";
            connection = new MySqlConnection(connectionString);        
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void CreateDatabase()
        {
            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = "CREATE DATABASE IF NOT EXISTS CardGame; USE CardGame; CREATE TABLE CardGame.Users(idUsers INT, Email VARCHAR(100), PasswordHash VARCHAR(500)); ALTER TABLE Users ADD CONSTRAINT AUTO_INCREMENT PRIMARY KEY(idUsers); ALTER TABLE `users` CHANGE COLUMN `idUsers` `idUsers` INT(11) NOT NULL AUTO_INCREMENT FIRST; ";

            // Execute the SQL command
            cmd.ExecuteNonQuery();
        }

        public string AddUser(string SignUpEmail, string SignUpPassword)
        {
            if (connection.State == ConnectionState.Closed && connection != null)
            {
                try
                {
                    //init of the connection    
                    connection.Open();
                }
                catch (Exception exc)
                {
                    //we display the error message.
                    MessageBox.Show(exc.Message);
                }
            }

            if (connection.State == ConnectionState.Open)
            {
                // Create a SQL command
                MySqlCommand cmd = connection.CreateCommand();
                string QueryResultEmail = "";

                cmd.CommandText = $"USE CardGame; SELECT Email, PasswordHash FROM users WHERE Email LIKE '{SignUpEmail}'";

                cmd.ExecuteNonQuery();

                DbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    //we go through the result of the select, we might get only one response. 
                    //Despite this, we use a while
                    while (reader.Read())
                    {
                        QueryResultEmail = reader.GetString(0);
                    }

                    reader.Close();
                }

                reader.Close();

                if (QueryResultEmail != SignUpEmail)
                {
                    byte[] data = System.Text.Encoding.ASCII.GetBytes(SignUpPassword);
                    data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                    String hashPassword = System.Text.Encoding.ASCII.GetString(data);

                    // SQL request
                    cmd.CommandText = $"USE CardGame; INSERT INTO users(Email, PasswordHash) VALUES('{SignUpEmail}', '{hashPassword}') ";

                    // Execute the SQL command
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Connection to database lost !");
                }
            }
            else
            {
                return "Still unable to connect to database !";
            }

            return "";
        }

        public string UserLogin(string UserLoginEmail, string UserLoginPassword)
        {
            if (connection.State == ConnectionState.Closed && connection != null)
            {
                try
                {
                    //init of the connection    
                    connection.Open();
                }
                catch (Exception exc)
                {
                    //we display the error message.
                    MessageBox.Show(exc.Message);
                }
            }
            
            if(connection.State == ConnectionState.Open)
            {
                MySqlCommand cmd = connection.CreateCommand();

                byte[] data = System.Text.Encoding.ASCII.GetBytes(UserLoginPassword);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                String hashPassword = System.Text.Encoding.ASCII.GetString(data);

                // SQL request
                cmd.CommandText = $"USE CardGame; SELECT Email, PasswordHash FROM users WHERE Email LIKE '{UserLoginEmail}' AND PasswordHash LIKE '{hashPassword}'";

                DbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return "Email or password is not valid !";
                }
                else
                {
                    reader.Close();
                    cmd.ExecuteNonQuery();
                }     
            }
            else
            {
                return "Still unable to connect to database !";
            }

            return "";
        }
    }
}
