using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace Assessment_Game
{
    class Fire
    {
        public int x, y, width, height;
        public int fireRotated;
        public double xSpeed, ySpeed;
        public Image fire;//variable for the missile's image
        public Rectangle fireRec;//variable for a rectangle to place our image in
        public Matrix matrixFire;//matrix to enable us to rotate missile in the same angle as the spaceship
        Point centreFire;//centre of missile
                         // in the following constructor we pass in the values of spaceRec and the rotation angle of the spaceship
                         // this gives us the position of the spaceship which we can then use to place the
                         // missile where the spaceship is located and at the correct angle

        public Fire(Rectangle spaceRec, int fireRotate)
        {
            width = 35;
            height = 30;
            fire = Properties.Resources.fire;
            fireRec = new Rectangle(x, y, width, height);
            //this code works out the speed of the missile to be used in the moveMissile method
            xSpeed = 30 * (Math.Cos((fireRotate - 90) * Math.PI / 180));
            ySpeed = 30 * (Math.Sin((fireRotate + 90) * Math.PI / 180));
            //calculate x,y to move missile to middle of spaceship in drawMissile method
            x = spaceRec.X + spaceRec.Width / 2;
            y = spaceRec.Y + spaceRec.Height / 2;
            //pass missileRotate angle to missileRotated so that it can be used in the drawMissile method
            fireRotated = fireRotate;
        }

        public void drawFire(Graphics g)
        {
            //centre missile 
            centreFire = new Point(x, y);
            //instantiate a Matrix object called matrixMissile
            matrixFire = new Matrix();
            //rotate the matrix (in this case missileRec) about its centre
            matrixFire.RotateAt(fireRotated, centreFire);
            //Set the current draw location to the rotated matrix point i.e. where missileRec is now
            g.Transform = matrixFire;
            //Draw the missile
            g.DrawImage(fire, fireRec);

        }
        public void moveFire(Graphics g)
        {
            x += (int)xSpeed;//cast double to an integer value
            y -= (int)ySpeed;
            fireRec.Location = new Point(x, y);//missiles new location

        }
    }

}
