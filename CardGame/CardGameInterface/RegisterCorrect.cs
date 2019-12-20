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
    public partial class RegisterCorrect : Form
    {
        public RegisterCorrect()
        {
            InitializeComponent();
        }

        private void RegisterCorrect_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            this.Hide();
            login.ShowDialog();
        }

        private void RegisterCorrect_Load_1(object sender, EventArgs e)
        {

        }
    }
}
