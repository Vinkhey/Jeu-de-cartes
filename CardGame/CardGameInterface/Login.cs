using CardGameManagement;
using Newtonsoft.Json;
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
        

        public Login()
        {
            InitializeComponent();

            if(UserPreferences == null)
            {
                UserPreferences = new List<string> { "0", "0" };
            }

            if (File.Exists(@"C:\UserPreferences.json"))
            {
                FromJson();
                //
                //string test = UserPreferences.First();
                //int test2 = Int32.Parse(test);
                //this.Top = test2;
                //
            }
            else
            {
                using (StreamWriter file = File.CreateText(@"C:\UserPreferences.json"))
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
            this.MaximumSize = new Size(1280, 800);
            this.MinimumSize = new Size(1280, 800);
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
                CardGameMainInterface CardGameMainInterface = new CardGameMainInterface(TxtBoxEmailLogin.Text);
                this.Hide();
                CardGameMainInterface.ShowDialog();
            }
            
        }
        public void ToJson()
        {
            UserPreferences.Clear();
            UserPreferences.Add(this.Location.X.ToString());
            UserPreferences.Add(this.Location.Y.ToString());

            System.IO.File.WriteAllText(@"C:\UserPreferences.json", "");

            using (StreamWriter file = File.CreateText(@"C:\UserPreferences.json"))
            {
                
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, UserPreferences);
                file.Close();
            }
            
        }

        public void FromJson()
        {
            using (StreamReader file = File.OpenText(@"c:\UserPreferences.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                var res = JsonConvert.DeserializeObject(File.ReadAllText(@"c:\UserPreferences.json"));
                string test = res.ToString();
                UserPreferences.Clear();
                UserPreferences.Add(test);
                file.Close();
            }
        }


        private void BtnLoginToSignUp_Click(object sender, EventArgs e)
        {
            SignUp SignUpForm = new SignUp();
            ToJson();

            this.Hide();
            SignUpForm.ShowDialog();
        }
    }
}
