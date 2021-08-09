﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_Game
{
    public partial class FormGameOver : Form
    {
        public FormGameOver()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //ends the program
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            new FormStartup().Show();
            this.Hide();
        }
    }
}
