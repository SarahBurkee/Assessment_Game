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
using System.Reflection;

namespace Assessment_Game
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g so we can draw on the Form
       
        Random yspeed = new Random();
        Dragon dragon = new Dragon(); //create an instance of the Dragon Class called dragon
        //declare a list fire from the Fire class
        List<Fire> fire = new List<Fire>();
        List<Marshmallow> marshmallow = new List<Marshmallow>();

      
        bool left, right;
        int score, lives;
        string move;

        public Form1()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty
            | System.Reflection.BindingFlags.Instance 
            | System.Reflection.BindingFlags.NonPublic, null, PnlGame, new object[] { true });

            for (int i = 0; i < 6; i++)
            {
                int displacement = 10 + (i * 75);

                marshmallow.Add(new Marshmallow(displacement));
            }
        }

        private void CheckScore()
        {
            if (score == 50)
            {
                tmrMarshmallow.Enabled = false;
                tmrDragon.Enabled = false;
                tmrShoot.Enabled = false;
                new YouWin().Show();
                this.Hide();
            }
        }

    private void CheckLives()
        {
            if (lives == 0)
            {
                tmrMarshmallow.Enabled = false;
                tmrDragon.Enabled = false;
                tmrShoot.Enabled = false;
                new FormGameOver().Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        public string _textName
        {
            set { label.Text = value; }
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
            if (e.KeyCode == Keys.Left) 
            { 
                left = true;
               
            }
           
            if (e.KeyCode == Keys.Right) 
            { 
                right = true;
                

            }
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { left = false; }
            if (e.KeyCode == Keys.Right) { right = false; }
        }

        private void tmrMarshmallow_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < 6; i++)
            {
                //if a marshmallow reaches the bottom of the Game Area reposition it at the top
                if (marshmallow[i].y >= PnlGame.Height)
                {
                    lives -= 1;// lose a life
                    LblLives.Text = lives.ToString();// display number of lives
                    CheckLives();
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
            tmrShoot.Enabled = true;

        }

        private void MnuStop_Click(object sender, EventArgs e)
        {
            tmrDragon.Enabled = false;
            tmrMarshmallow.Enabled = false;
            tmrShoot.Enabled = false;
        }

        private void tmrShoot_Tick(object sender, EventArgs e)
        {

            foreach (Fire m in fire) // for movement and updating the score and lives for marshmallows
            {
                foreach (Marshmallow p in marshmallow) // for movement and updating the score and lives for marshmallows

                {
                    if (p.marshmallowRec.IntersectsWith(m.fireRec))
                    {
                        score += 1;// update the score
                        CheckScore();
                        LblScore.Text = score.ToString();// display score

                        p.y = 0;

                        m.killFire(g); // move fire so it's out of the game panel
                        break;

                    }
                }
            }


            PnlGame.Invalidate();
        }

        private void MnuEasy_Click(object sender, EventArgs e)
        {
            lives = 15;
            LblLives.Text = lives.ToString();
            LblDifficulty.Text = "Easy"; LblDifficulty.Refresh();

        }

        private void LblDifficulty_Click(object sender, EventArgs e)
        {

        }

        private void MnuMedium_Click(object sender, EventArgs e)
        {
            lives = 10;
            LblLives.Text = lives.ToString();
            LblDifficulty.Text = "Medium"; LblDifficulty.Refresh();

        }

        private void MnuHard_Click(object sender, EventArgs e)
        {
            lives = 5;
            LblLives.Text = lives.ToString();
            LblDifficulty.Text = "Hard"; LblDifficulty.Refresh();
         
        }
         
        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            // get the graphics used to paint on the Form control
            g = e.Graphics;

            for (int i = 0; i < 6; i++)
            {
                // generate a random number from 4 to 8 and put it in rndmspeed
                int rndmspeed = yspeed.Next(4, 8);
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

        private void PnlGame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                fire.Add(new Fire(dragon.dragonRec, dragon.rotationAngle));
            }
        }
    }
}
