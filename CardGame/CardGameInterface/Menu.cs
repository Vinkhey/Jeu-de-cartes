using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGameInterface
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();

            CardGameMainInterface GameInterface = new CardGameMainInterface();
            GameInterface.ShowDialog();
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login LoginForm = new Login();
            LoginForm.ShowDialog();
        }
    }
}
