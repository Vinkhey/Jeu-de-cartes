using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
    public partial class Menu : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private List<string> UserPreferences;
        private string WorkingDirectory;

        public Menu()
        {
            player.SoundLocation = "musique.wav";
            player.Play();
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

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            ToJson();
            this.Close();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            ToJson();
            this.Hide();

            CardGameMainInterface GameInterface = new CardGameMainInterface();
            GameInterface.ShowDialog();
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            ToJson();
            this.Hide();

            Login LoginForm = new Login();
            LoginForm.ShowDialog();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            ToJson();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void LblMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
