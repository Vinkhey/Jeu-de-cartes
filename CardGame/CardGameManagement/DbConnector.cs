﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
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
            cmd.CommandText = "CREATE DATABASE IF NOT EXISTS CardGame; USE CardGame; CREATE TABLE CardGame.Users(idUsers INT, Email VARCHAR(50), PasswordHash VARCHAR(20)); ALTER TABLE Users ADD CONSTRAINT AUTO_INCREMENT PRIMARY KEY(idUsers); ALTER TABLE `users` CHANGE COLUMN `idUsers` `idUsers` INT(11) NOT NULL AUTO_INCREMENT FIRST; ";

            // Execute the SQL command
            cmd.ExecuteNonQuery();
        }

        public string AddUser(string SignUpEmail, string SignUpPassword)
        {
            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();
            string QueryResultEmail = "";
            connection.Open();

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
                // SQL request
                cmd.CommandText = $"USE CardGame; INSERT INTO users(Email, PasswordHash) VALUES('{SignUpEmail}', '{SignUpPassword}') ";

                // Execute the SQL command
                cmd.ExecuteNonQuery();
            }
            else
            {
                return "User with this email assigned already exists";
            }

            return "";
        }

        public void UserLogin(string Mail, string Password)
        {
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();

            // SQL request
            cmd.CommandText = $"USE CardGame; SELECT Email, PasswordHash FROM users WHERE Email LIKE '{Mail}' AND PasswordHash LIKE '{Password}'";

            // Execute the SQL command
            cmd.ExecuteNonQuery();
        }
    }
}
