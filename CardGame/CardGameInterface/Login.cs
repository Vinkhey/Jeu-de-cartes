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

namespace CardGameInterface
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(1280, 800);
            this.MinimumSize = new Size(1280, 800);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DbConnector ConnexionDb = new DbConnector();

            if(TxtBoxEmailLogin.Text == "")
            {
                //TODO
            }

            if(TxtBoxPswLogin.Text == "")
            {
                //TODO
            }
           
            ConnexionDb.UserLogin(TxtBoxEmailLogin.Text, TxtBoxPswLogin.Text); 
        }

        private void BtnLoginToSignUp_Click(object sender, EventArgs e)
        {
            SignUp SignUpForm = new SignUp();

            this.Hide();
            SignUpForm.ShowDialog();
        }
    }
}
