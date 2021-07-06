using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_Game
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g so we can draw on the Form
        Marshmallow[] marshmallow = new Marshmallow[7];
        Random yspeed = new Random();
        Dragon dragon = new Dragon(); //create an instance of the Spaceship Class called spaceship
        bool turnLeft, turnRight;
        //declare a list  missiles from the Missile class
        List<Fire> fires = new List<Fire>();

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 75);
                marshmallow[i] = new Marshmallow(x);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Use the left and right arrow keys to move the dragon. \n Try to cook as many marshmallows as you can! \n Every marshmallow that you hit scores a point. \n If a marshmallow goes to the bottom of the game area you lose a life! \n \n Enter your Name \n Click Start to begin", "Game Instructions");
            TxtName.Focus();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            dragon.moveDragon(e.X, e.Y);
        }

        private void tmrDragon_Tick(object sender, EventArgs e)
        {
            if (turnRight)
            {
                dragon.rotationAngle += 5;
            }
            if (turnLeft)
            {
                dragon.rotationAngle -= 5;
            }

            Invalidate(); //makes the paint event fire to redraw the panel
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = true; }
            if (e.KeyData == Keys.Right) { turnRight = true; }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                fires.Add(new Fire(dragon.dragonRec, dragon.rotationAngle));
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false; }
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
           
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
                }

                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (marshmallow[i].y >= ClientSize.Height)
                {
                    marshmallow[i].y = 30;
                }
            }
            Invalidate();//makes the paint event fire to redraw the panel
        }

        private void MnuStart_Click(object sender, EventArgs e)
        {
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

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // get the graphics used to paint on the Form control
            g = e.Graphics;

            for (int i = 0; i < 7; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(5, 20);
                marshmallow[i].y += rndmspeed;


                //call the Planet class's drawPlanet method to draw the images
                marshmallow[i].DrawMarshmallow(g);
                dragon.drawDragon(g);
            }
            
            foreach (Fire m in fires)
            {
                m.drawFire(g);
                m.moveFire(g);
            }
        }
    }
}
