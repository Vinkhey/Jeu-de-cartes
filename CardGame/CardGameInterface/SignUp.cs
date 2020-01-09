using CardGameManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CardGameInterface
{
    public partial class SignUp : Form
    {
        private List<string> UserPreferences;
        DbConnector ConnexionDb = new DbConnector();
        private string WorkingDirectory;

        public SignUp()
        {
            InitializeComponent();

            WorkingDirectory = Directory.GetCurrentDirectory();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
           

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

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            RegisterCorrect form = new RegisterCorrect();

            try
            {
                var addr = new System.Net.Mail.MailAddress(TxtBoxEmailSignUp.Text);
            }
            catch
            {
                MessageBox.Show("Email isn't a valid format");
            }

            if (TxtBoxEmailSignUp.Text == "" || TxtBoxPswSignUp.Text == "" || TxtBoxPswVerifSignUp.Text == "")
            {
                if (TxtBoxPswSignUp.Text.Length < 8 && TxtBoxPswSignUp.Text.Length > 0)
                {
                    MessageBox.Show("Password is too small");
                }

                if(TxtBoxPswVerifSignUp.Text.Length < 8 && TxtBoxPswVerifSignUp.Text.Length > 0)
                {
                    MessageBox.Show("Password is too small");
                }

                if (TxtBoxEmailSignUp.Text == "")
                {
                    LblMailErrorSignUp.Text = "Ce champs est obligatoire";
                }
                else
                {
                    LblMailErrorSignUp.Text = "";
                }

                if (TxtBoxPswSignUp.Text == "")
                {
                    LblPswErrorSignUp.Text = "Ce champs est obligatoire";
                }
                else
                {
                    LblPswErrorSignUp.Text = "";
                }

                if (TxtBoxPswVerifSignUp.Text == "")
                {
                    LblPswverifErrorSignUp.Text = "Ce champs est obligatoire";
                }
                else
                {
                    LblPswverifErrorSignUp.Text = "";
                }
            }
            else if (TxtBoxPswSignUp.Text != TxtBoxPswVerifSignUp.Text)
            {
                MessageBox.Show("The passwords aren't the same !");
            }
            else if(TxtBoxPswSignUp.Text.Length < 8 || TxtBoxPswVerifSignUp.Text.Length < 8)
            {
                MessageBox.Show("Password is too small");
            }
            else if(TxtBoxEmailSignUp.Text.Contains("'"))
            {
                MessageBox.Show("Your email conatains an invalid character");
            }
            else
            {
                string UserAlreadyExists = "";
                UserAlreadyExists = ConnexionDb.AddUser(TxtBoxEmailSignUp.Text, TxtBoxPswSignUp.Text);

                if(UserAlreadyExists != "")
                {
                    MessageBox.Show(UserAlreadyExists);
                }
                else
                {
                    this.Hide();
                    form.ShowDialog();
                }
            }    
        }

        private void BtnSignUpToLogin_Click(object sender, EventArgs e)
        {
            ToJson();
            Login LoginForm = new Login();

            this.Hide();
            LoginForm.ShowDialog();
        }

        private void SignUp_Closing(object sender, FormClosingEventArgs e)
        {
            ToJson();
            ConnexionDb.CloseConnection();
        }
    }
}
