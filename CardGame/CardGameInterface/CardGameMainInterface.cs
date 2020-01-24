using CardGameManagement;
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
    public partial class CardGameMainInterface : Form
    {
        private List<string> UserPreferences;
        private string WorkingDirectory;

        public CardGameMainInterface()
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            ToJson();
            this.Close();
        }

        private void CardGameMainInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            ToJson();
        }

        private void BtnQuitGame_Click(object sender, EventArgs e)
        {
            ToJson();
            this.Hide();

            Menu MainMenu = new Menu();
            MainMenu.ShowDialog();
        }

        private void BtnNewCardPlayer1_Click(object sender, EventArgs e)
        {
            Random Card = new Random();
            int RandomCardNumber = Card.Next(1, 17);

            DbConnector DBconnection = new DbConnector();
            MemoryStream test = DBconnection.PullCard(RandomCardNumber);
            DBconnection.CheckCardAlreadyPulled(RandomCardNumber);
            string HealpointsP1 = DBconnection.GetCardHealthPointsPlayer1(RandomCardNumber);
            string AttackvalueP1 = DBconnection.GetCardAttackValuePlayer1(RandomCardNumber);
            label3.Text = HealpointsP1;
            label4.Text = AttackvalueP1;
            button2.Image = Image.FromStream(test);
        }

        private void BtnNewCardPlayer2_Click(object sender, EventArgs e)
        {
            Random Card = new Random();
            int RandomCardNumber = Card.Next(1, 17);

            DbConnector DBconnection = new DbConnector();
            MemoryStream test = DBconnection.PullCard(RandomCardNumber);
            DBconnection.CheckCardAlreadyPulled(RandomCardNumber);
            string HealpointsP2 = DBconnection.GetCardHealthPointsPlayer2(RandomCardNumber);
            string AttackvalueP2 = DBconnection.GetCardAttackValuePlayer2(RandomCardNumber);
            label1.Text = HealpointsP2;
            label2.Text = AttackvalueP2;
            button5.Image = Image.FromStream(test);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text != "" || label2.Text != "")
            {
                int HealpointsP2Int = int.Parse(label1.Text) - int.Parse(label3.Text);

                if (HealpointsP2Int <= 0)
                {
                    label1.Text = "0";
                    label2.Text = "0";
                    button5.Image = null;
                }

                label1.Text = HealpointsP2Int.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label3.Text != "" || label4.Text != "")
            {
                int HealpointsP1Int = int.Parse(label4.Text) - int.Parse(label2.Text);

                if (HealpointsP1Int <= 0)
                {
                    label3.Text = "0";
                    label4.Text = "0";
                    button2.Image = null;
                }
                else
                {
                    label4.Text = HealpointsP1Int.ToString();
                }
            }
        }
    }
}
    