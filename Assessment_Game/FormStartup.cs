using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Assessment_Game
{
    public partial class FormStartup : Form
    {

        string playerName;

        public FormStartup()
        {
            InitializeComponent();
        }

        private void FormStartup_Load(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

            Form1 frm = new Form1();
            frm._textName = _TxtName;
            

            playerName = TxtName.Text;

            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$"))//checks playerName for letters
            {
                //if playerName valid (only letters) 
                frm.Show();
                this.Hide();
            }

            else
            {
                //invalid playerName, clear txtName and focus on it to try again
                MessageBox.Show("Please enter a name!");
                TxtName.Clear();
                TxtName.Focus();
            }
        }

        private void BtnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the left and right arrow keys to move the dragon. \nClick the mouse to shoot fire and try to cook as many marshmallows as you can! \nEvery marshmallow that you hit scores a point. \nIf a marshmallow goes to the bottom of the game area you lose a life. \nOnce you reach 50 points you win!! \nEnter your name and click 'Start' to begin.", "Game Instructions");
        }

        public string _TxtName
        {
            get { return TxtName.Text; }
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
