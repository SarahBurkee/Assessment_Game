using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_Game
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g so we can draw on the Form
        Dragon dragon = new Dragon(); //create an instance of the Spaceship Class called spaceship
        bool turnLeft, turnRight;
        //declare a list  missiles from the Missile class
        List<Missile> missiles = new List<Missile>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

            Invalidate();
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
                missiles.Add(new Missile(dragon.dragonRec, dragon.rotationAngle));
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false; }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // get the graphics used to paint on the Form control
            g = e.Graphics;
            //Draw the spaceship
            dragon.drawDragon(g);

            foreach (Missile m in missiles)
            {
                m.drawMissile(g);
                m.moveMissile(g);
            }
        }
    }
}
