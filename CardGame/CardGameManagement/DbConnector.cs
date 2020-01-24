using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        public string IdUserConnected;

        public DbConnector()
        {
            InitConnection();
        }

        private void InitConnection()
        {
            // Creation of the connection string : where, who
            string connectionString = "SERVER=127.0.0.1; UID=root; PASSWORD=Pa$$w0rd;";
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
            cmd.CommandText = "CREATE DATABASE IF NOT EXISTS CardGame; CREATE USER IF NOT EXISTS 'AdminCardGame'@'localhost' IDENTIFIED BY 'Pa$$w0rd'; USE CardGame; CREATE TABLE CardGame.Users(idUsers INT, Email VARCHAR(100), PasswordHash VARCHAR(500)); ALTER TABLE Users ADD CONSTRAINT AUTO_INCREMENT PRIMARY KEY(idUsers); ALTER TABLE `users` CHANGE COLUMN `idUsers` `idUsers` INT(11) NOT NULL AUTO_INCREMENT FIRST; GRANT ALL PRIVILEGES ON CardGame.* TO 'AdminCardGame'@'localhost'; CREATE TABLE CardGame.Cards(IdCards INT, CardName VARCHAR(20), HealthPoints INT, AttackValue INT, CardPicture BLOB); ALTER TABLE Cards ADD CONSTRAINT AUTO_INCREMENT PRIMARY KEY(IdCards); ALTER TABLE Cards CHANGE COLUMN IdCards IdCards INT(11) NOT NULL AUTO_INCREMENT FIRST; CREATE TABLE CardGame.Users_Cards(IdCards INT(11), IdUsers INT(11), Game INT(11)); ALTER TABLE Users_Cards ADD FOREIGN KEY (IdUsers) REFERENCES Users(IdUsers); ALTER TABLE Users_Cards ADD FOREIGN KEY(IdCards) REFERENCES Cards(IdCards)";

            // Execute the SQL command
            cmd.ExecuteNonQuery();
        }

        public void UploadImages()
        {
            string WorkingDirectory = Directory.GetCurrentDirectory();

            MySqlCommand cmd = connection.CreateCommand();

            byte[] imag = File.ReadAllBytes($@"{WorkingDirectory}\images\Yoooda.png");

            cmd.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('Yoda', 90, 70, @Image)";
            cmd.Parameters.AddWithValue("@Image", imag);

            cmd.ExecuteNonQuery();

            MySqlCommand cmd2 = connection.CreateCommand();

            byte[] imag2 = File.ReadAllBytes($@"{WorkingDirectory}\images\Webp.net-resizeimage (11).jpg");

            cmd2.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('Grievous', 60, 70, @Image)";
            cmd2.Parameters.AddWithValue("@Image", imag2);

            cmd2.ExecuteNonQuery();

            MySqlCommand cmd3 = connection.CreateCommand();

            byte[] imag3 = File.ReadAllBytes($@"{WorkingDirectory}\images\Webp.net-resizeimage (1).png");

            cmd3.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('Rex', 50, 50, @Image)";
            cmd3.Parameters.AddWithValue("@Image", imag3);

            cmd3.ExecuteNonQuery();

            MySqlCommand cmd4 = connection.CreateCommand();

            byte[] imag4 = File.ReadAllBytes($@"{WorkingDirectory}\images\tumblr_pyevoelyyy1wsksg3o1_400.png");

            cmd4.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('Commando', 50, 60, @Image)";
            cmd4.Parameters.AddWithValue("@Image", imag4);

            cmd4.ExecuteNonQuery();

            MySqlCommand cmd5 = connection.CreateCommand();

            byte[] imag5 = File.ReadAllBytes($@"{WorkingDirectory}\images\Malgus.png");

            cmd5.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('Darth Malgus', 100, 100, @Image)";
            cmd5.Parameters.AddWithValue("@Image", imag5);

            cmd5.ExecuteNonQuery();

            MySqlCommand cmd6 = connection.CreateCommand();

            byte[] imag6 = File.ReadAllBytes($@"{WorkingDirectory}\images\dro--de_de_combat_b1.png");

            cmd6.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('Droïde', 20, 20, @Image)";
            cmd6.Parameters.AddWithValue("@Image",  imag6);

            cmd6.ExecuteNonQuery();

            MySqlCommand cmd7 = connection.CreateCommand();

            byte[] imag7 = File.ReadAllBytes($@"{WorkingDirectory}\images\ddhkouw-8b890283-d536-4552-8a2.png");

            cmd7.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('Kylo ren', 60, 60, @Image)";
            cmd7.Parameters.AddWithValue("@Image", imag7);

            cmd7.ExecuteNonQuery();

            MySqlCommand cmd8 = connection.CreateCommand();

            byte[] imag8 = File.ReadAllBytes($@"{WorkingDirectory}\images\commandodroid_detail.png");

            cmd8.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('Droïde commando', 35, 45, @Image)";
            cmd8.Parameters.AddWithValue("@Image", imag8);

            cmd8.ExecuteNonQuery();

            MySqlCommand cmd9 = connection.CreateCommand();

            byte[] imag9 = File.ReadAllBytes($@"{WorkingDirectory}\images\c3po.png");

            cmd9.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('C3PO', 5, 5, @Image)";
            cmd9.Parameters.AddWithValue("@Image", imag9);

            cmd9.ExecuteNonQuery();

            MySqlCommand cmd10 = connection.CreateCommand();

            byte[] imag10 = File.ReadAllBytes($@"{WorkingDirectory}\images\b2_battle_droid_imv6.jpg");

            cmd10.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('Droïde de combat', 50, 40, @Image)";
            cmd10.Parameters.AddWithValue("@Image", imag10);

            cmd10.ExecuteNonQuery();

            MySqlCommand cmd11 = connection.CreateCommand();

            byte[] imag11 = File.ReadAllBytes($@"{WorkingDirectory}\images\anakin-skywalker-luke-skywalke.jpg");

            cmd11.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('Darth vador', 80, 80, @Image)";
            cmd11.Parameters.AddWithValue("@Image", imag11);

            cmd11.ExecuteNonQuery();

            MySqlCommand cmd12 = connection.CreateCommand();

            byte[] imag12 = File.ReadAllBytes($@"{WorkingDirectory}\images\6838079_preview-1.png");

            cmd12.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('Anakin', 90, 70, @Image)";
            cmd12.Parameters.AddWithValue("@Image", imag12);

            cmd12.ExecuteNonQuery();

            MySqlCommand cmd13 = connection.CreateCommand();

            byte[] imag13 = File.ReadAllBytes($@"{WorkingDirectory}\images\6690636_preview.png");

            cmd13.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('Obi-wan kenobi', 90, 70, @Image)";
            cmd13.Parameters.AddWithValue("@Image", imag13);

            cmd13.ExecuteNonQuery();

            MySqlCommand cmd14 = connection.CreateCommand();

            byte[] imag14 = File.ReadAllBytes($@"{WorkingDirectory}\images\5462702-darth-sidious-png-dart.jpg");

            cmd14.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('Darth sidious', 100, 80, @Image)";
            cmd14.Parameters.AddWithValue("@Image", imag14);

            cmd14.ExecuteNonQuery();

            MySqlCommand cmd15 = connection.CreateCommand();

            byte[] imag15 = File.ReadAllBytes($@"{WorkingDirectory}\images\4109c25126f333fe8f0b0cf23777f4.png");

            cmd15.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('Darth nihilus', 120, 90, @Image)";
            cmd15.Parameters.AddWithValue("@Image", imag15);

            cmd15.ExecuteNonQuery();

            MySqlCommand cmd16 = connection.CreateCommand();

            byte[] imag16 = File.ReadAllBytes($@"{WorkingDirectory}\images\131-1317620_darth-maul-png-tra.png");

            cmd16.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('Darth maul', 70, 70, @Image)";
            cmd16.Parameters.AddWithValue("@Image", imag16);

            cmd16.ExecuteNonQuery();

            MySqlCommand cmd17 = connection.CreateCommand();

            byte[] imag17 = File.ReadAllBytes($@"{WorkingDirectory}\images\61hhimpnd7l-_ac_sy550_.jpg");

            cmd17.CommandText = "INSERT INTO Cards(CardName, HealthPoints, AttackValue, CardPicture) VALUES('Clone trooper', 30, 30, @Image)";
            cmd17.Parameters.AddWithValue("@Image", imag17);

            cmd17.ExecuteNonQuery();
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
                cmd.CommandText = $"USE CardGame; SELECT IdUsers, Email, PasswordHash FROM users WHERE Email LIKE '{UserLoginEmail}' AND PasswordHash LIKE '{hashPassword}'";

                DbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return "Email or password is not valid !";
                }
                else
                {
                    if (reader.Read())
                    {
                        IdUserConnected = reader.GetString(0);
                    }

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

        public MemoryStream PullCard(int RandomCardNumber)
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

            

            MemoryStream ms1 = new MemoryStream();

            string WorkingDirectory = Directory.GetCurrentDirectory();
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = $"USE CardGame; SELECT CardPicture FROM Cards WHERE idCards LIKE({RandomCardNumber});";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    byte[] b = new byte[0];
                    b = (Byte[])(reader[0]);
                    MemoryStream ms = new MemoryStream(b);
                    connection.Close();
                    return ms;
                }

                connection.Close();
                reader.Close();
            }

            reader.Close();
            connection.Close();

            return ms1;
        }

        public void InsertCardUsed(int RandomCardNumber)
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

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $@"INSERT INTO `cardgame`.`users_cards` (`IdCards`, `IdUsers`, `Game`) VALUES ('2', '1', '1');";

            DbDataReader reader = cmd.ExecuteReader();

            connection.Close();
        }

        public void CheckCardAlreadyPulled(int RandomCardNumber)
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

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $@"USE CardGame; SELECT idCards, idUsers FROM users_cards WHERE idUsers LIKE(2) AND idCards LIKE(2);";

            DbDataReader reader = cmd.ExecuteReader();

            if(!reader.HasRows)
            {
                InsertCardUsed(RandomCardNumber);
            }
            else
            {
                Random Card = new Random();
                RandomCardNumber = Card.Next(1, 17);
                PullCard(RandomCardNumber);
            }

            connection.Close();
        }
    }
}
