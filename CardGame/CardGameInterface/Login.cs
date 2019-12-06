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
<<<<<<< Updated upstream
=======

            this.WindowState = Properties.Settings.Default.F1State;
            this.Location = Properties.Settings.Default.F1Location;
            this.Size = Properties.Settings.Default.F1Size;

            if (Properties.Settings.Default.F1Size.Width == 0) Properties.Settings.Default.Upgrade();

            if (Properties.Settings.Default.F1Size.Width == 0 || Properties.Settings.Default.F1Size.Height == 0)
            {

            }
            else
            {
                this.WindowState = Properties.Settings.Default.F1State;

                if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;

                this.Location = Properties.Settings.Default.F1Location;
                this.Size = Properties.Settings.Default.F1Size;
            }
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======

        private void Login_Closing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.F1State = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // save location and size if the state is normal
                Properties.Settings.Default.F1Location = this.Location;
                Properties.Settings.Default.F1Size = this.Size;
            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                Properties.Settings.Default.F1Location = this.RestoreBounds.Location;
                Properties.Settings.Default.F1Size = this.RestoreBounds.Size;
            }

            // don't forget to save the settings
            Properties.Settings.Default.Save();
        }
>>>>>>> Stashed changes
    }
}
