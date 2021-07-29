using System;
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
    public partial class FormStartup : Form
    {
        public FormStartup()
        {
            InitializeComponent();
        }

        private void FormStartup_Load(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void BtnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the left and right arrow keys to move the dragon. \n Try to cook as many marshmallows as you can! \n Every marshmallow that you hit scores a point. \n If a marshmallow goes to the bottom of the game area you lose a life! \n \n Enter your Name and click Start to begin", "Game Instructions");
        }
    }
}
