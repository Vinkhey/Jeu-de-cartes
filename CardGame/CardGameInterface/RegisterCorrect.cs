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
    public partial class CardsGame : Form
    {
        public CardsGame()
        {
            InitializeComponent();
        }

        private void CardsGame_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(980, 720);
            this.MinimumSize = new Size(980, 720);
        }
    }
}
