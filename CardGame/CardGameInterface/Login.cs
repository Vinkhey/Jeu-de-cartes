using CardGameManagement;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGameInterface
{
    public partial class Login : Form
    {
        private List<string> UserPreferences;
        private string WorkingDirectory;

        public Login()
        {
            InitializeComponent();

            WorkingDirectory = Directory.GetCurrentDirectory();

            if (UserPreferences == null)
            {
                UserPreferences = new List<string> { "0", "0" };
            }

            if (File.Exists($@"{WorkingDirectory}\UserPreferences.json"))
            {
                FromJson();

                string FormPositionX = UserPreferences[0];
                string FormPositionY = UserPreferences[1];

                int FormPositionXToInt = Int32.Parse(FormPositionX);
                int FormPositionYToInt = Int32.Parse(FormPositionY);

                Point newPoint = new Point();

                newPoint.X = FormPositionXToInt;
                newPoint.Y = FormPositionYToInt;

                this.Location = newPoint; 
            }
            else
            {
                using (StreamWriter file = File.CreateText($@"{WorkingDirectory}\UserPreferences.json"))
                {
                
                    JsonSerializer serializer = new JsonSerializer();
                    //serialize object directly into file stream
                    serializer.Serialize(file, UserPreferences);
                    file.Close();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                DbConnector connDB = new DbConnector();
                //init of the connection    
                connDB.OpenConnection();
            }
            catch (Exception exc)
            {
                //we display the error message.
                MessageBox.Show(exc.Message);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DbConnector ConnexionDb = new DbConnector();
            string LoginError;

            LoginError = ConnexionDb.UserLogin(TxtBoxEmailLogin.Text, TxtBoxPswLogin.Text);

            if(LoginError != "")
            {
                MessageBox.Show(LoginError);
            }
            else
            {
                Menu MainMenu = new Menu();
                this.Hide();
                MainMenu.ShowDialog();
            }
            
        }
        public void ToJson()
        {
            UserPreferences.Clear();
            UserPreferences.Add(this.Location.X.ToString());
            UserPreferences.Add(this.Location.Y.ToString());

            System.IO.File.WriteAllText($@"{WorkingDirectory}\UserPreferences.json", "");

            using (StreamWriter file = File.CreateText($@"{WorkingDirectory}\UserPreferences.json"))
            {
                
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, UserPreferences);
                file.Close();
            }
        }

        public void FromJson()
        {
            using (StreamReader file = File.OpenText($@"{WorkingDirectory}\UserPreferences.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                var expandoConverter = new ExpandoObjectConverter();
                var obj = JsonConvert.DeserializeObject<List<dynamic>>(File.ReadAllText($@"{WorkingDirectory}\UserPreferences.json"));
                UserPreferences.Clear();
                UserPreferences.Add(obj[0]);
                UserPreferences.Add(obj[1]);
                file.Close();
            }
        }

        private void BtnLoginToSignUp_Click(object sender, EventArgs e)
        {
            ToJson();
            SignUp SignUpForm = new SignUp();    

            this.Hide();
            SignUpForm.ShowDialog();
        }

        private void Login_Closing(object sender, FormClosingEventArgs e)
        {
            DbConnector ConnexionDb = new DbConnector();

            ToJson();
            ConnexionDb.CloseConnection();
        }
    }
}
