using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assessment_Game
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g so we can draw on the Form
        Marshmallow[] marshmallow = new Marshmallow[7];
        Random yspeed = new Random();
        Dragon dragon = new Dragon(); //create an instance of the Spaceship Class called spaceship
        //declare a list  missiles from the Missile class
        List<Fire> fire = new List<Fire>();

        bool left, right;
        int score, lives;
        string playerName, move;

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 75);
                marshmallow[i] = new Marshmallow(x);
            }
        }

        private void CheckLives()
        {
            if (lives == 0)
            {
                tmrMarshmallow.Enabled = false;
                tmrDragon.Enabled = false;
                MessageBox.Show("Game Over");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Use the left and right arrow keys to move the dragon. \n Try to cook as many marshmallows as you can! \n Every marshmallow that you hit scores a point. \n If a marshmallow goes to the bottom of the game area you lose a life! \n \n Enter your Name \n Click Start to begin", "Game Instructions");
            TxtName.Focus();

            playerName = TxtName.Text;


            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$"))//checks playerName for letters
            {
                //if playerName valid (only letters) 
                MessageBox.Show("Starting");
            }
            else
            {
                //invalid playerName, clear txtName and focus on it to try again
                MessageBox.Show("please enter a name using letters only!");
                TxtName.Clear();

                TxtName.Focus();
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void tmrDragon_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                dragon.moveDragon(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                dragon.moveDragon(move);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                fire.Add(new Fire(dragon.dragonRec, dragon.rotationAngle));
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
        }

        private void tmrMarshmallow_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                marshmallow[i].MoveMarshmallow();
                if (dragon.dragonRec.IntersectsWith(marshmallow[i].marshmallowRec))
                {
                    //reset planet[i] back to top of panel
                    marshmallow[i].y = 30; // set  y value of planetRec
                    lives -= 1;// lose a life
                    LblLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }

                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (marshmallow[i].y >= PnlGame.Height)
                {
                    score += 1;//update the score
                    LblScore.Text = score.ToString();// display score
                    marshmallow[i].y = 30;
                }
            }

            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void MnuStart_Click(object sender, EventArgs e)
        {
            score = 0;
            LblScore.Text = score.ToString();
            // pass lives from LblLives Text property to lives variable
            lives = int.Parse(LblLives.Text);

            tmrDragon.Enabled = true;
            tmrMarshmallow.Enabled = true;
        }

        private void MnuStop_Click(object sender, EventArgs e)
        {
            tmrDragon.Enabled = false;
            tmrMarshmallow.Enabled = false;
        }

        private void LblName_Click(object sender, EventArgs e)
        {

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            // get the graphics used to paint on the Form control
            g = e.Graphics;

            for (int i = 0; i < 7; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(5, 10);
                marshmallow[i].y += rndmspeed;


                //call the Planet class's drawPlanet method to draw the images
                marshmallow[i].DrawMarshmallow(g);
                dragon.drawDragon(g);
            }

            foreach (Fire m in fire)
            {
                m.drawFire(g);
                m.moveFire(g);
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
