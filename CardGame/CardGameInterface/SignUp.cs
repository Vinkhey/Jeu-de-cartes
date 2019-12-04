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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(1280, 800);
            this.MinimumSize = new Size(1280, 800);

            try
            {
                //init of the connection
                DbConnector connDB = new DbConnector();
                connDB.OpenConnection();
                connDB.CreateDatabase();
            }
            catch (Exception exc)
            {
                //we display the error message.
                Console.WriteLine(exc.Message);
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            DbConnector ConnexionDb = new DbConnector();
            RegisterCorrect form = new RegisterCorrect();

            if (TxtBoxPswSignUp.Text != TxtBoxPswVerifSignUp.Text)
            {
                throw new Exception("The passwords aren't the same !");
            }
            else
            {
                ConnexionDb.AddUser(TxtBoxEmailSignUp.Text, TxtBoxPswSignUp.Text);
                form.ShowDialog();
            }    
        }
    }
}
