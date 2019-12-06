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

                this.WindowState = FormWindowState.Normal;
                string test = UserPreferences[0];
                string test2 = UserPreferences[1];
                int test3 = Int32.Parse(test);
                int test4 = Int32.Parse(test2);
                Point newPoint = new Point();
                newPoint.X = test3;
                newPoint.Y = test4;
                this.Location = newPoint;
                Properties.Settings.Default.Save();
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

            this.WindowState = Properties.Settings.Default.LoginState;
            this.Location = Properties.Settings.Default.LoginPoint;
            this.Size = Properties.Settings.Default.LoginSize;

            // Upgrade?
            if (Properties.Settings.Default.LoginSize.Width == 0) Properties.Settings.Default.Upgrade();

            if (Properties.Settings.Default.LoginSize.Width == 0 || Properties.Settings.Default.LoginSize.Height == 0)
            {
                // first start
                // optional: add default values
            }
            else
            {
                this.WindowState = Properties.Settings.Default.LoginState;

                // we don't want a minimized window at startup
                if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;

                this.Location = Properties.Settings.Default.LoginPoint;
                this.Size = Properties.Settings.Default.LoginSize;
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
                var expandoConverter = new ExpandoObjectConverter();
                var obj = JsonConvert.DeserializeObject<List<dynamic>>(File.ReadAllText(@"c:\UserPreferences.json"));
                UserPreferences.Clear();
                UserPreferences.Add(obj[0]);
                UserPreferences.Add(obj[1]);
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

        private void Login_Closing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LoginState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // save location and size if the state is normal
                Properties.Settings.Default.LoginPoint = this.Location;
                Properties.Settings.Default.LoginSize = this.Size;
            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                Properties.Settings.Default.LoginPoint = this.RestoreBounds.Location;
                Properties.Settings.Default.LoginSize = this.RestoreBounds.Size;
            }

            // don't forget to save the settings
            Properties.Settings.Default.Save();
        }
    }
}
