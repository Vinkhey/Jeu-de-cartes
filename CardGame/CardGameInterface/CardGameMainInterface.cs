﻿using System;
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
    public partial class CardGameMainInterface : Form
    {
        public CardGameMainInterface(string UserConnected)
        {
            InitializeComponent();
            LblUserConnected.Text = UserConnected;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}