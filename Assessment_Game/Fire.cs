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
        public Image fire;//variable for the fire's image
        public Rectangle fireRec;//variable for a rectangle to place our image in
        public Matrix matrixFire;//matrix to enable us to rotate fire in the same angle as the spaceship
        Point centreFire;//centre of fire
                         // in the following constructor we pass in the values of dragonRec and the rotation angle of the dragon
                         // this gives us the position of the dragon which we can then use to place the
                         // fire where the dragon is located and at the correct angle

        public Fire(Rectangle dragonRec, int fireRotate)
        {
            width = 40;
            height = 35;
            fire = Properties.Resources.fire;
            fireRec = new Rectangle(x, y, width, height);
            //this code works out the speed of the fire to be used in the moveFire method
            xSpeed = 30 * (Math.Cos((fireRotate - 90) * Math.PI / 180));
            ySpeed = 30 * (Math.Sin((fireRotate + 90) * Math.PI / 180));
            //calculate x,y to move fire to middle of spaceship in drawFire method
            x = dragonRec.X + dragonRec.Width / 2;
            y = dragonRec.Y + dragonRec.Height / 2;
            //pass fireRotate angle to fireRotated so that it can be used in the drawFire method
            fireRotated = fireRotate;
        }

        public void drawFire(Graphics g)
        {
            //centre fire 
            centreFire = new Point(x, y);
            //instantiate a Matrix object called matrixFire
            matrixFire = new Matrix();
            //rotate the matrix (in this case fireRec) about its centre
            matrixFire.RotateAt(fireRotated, centreFire);
            //Set the current draw location to the rotated matrix point i.e. where fireRec is now
            g.Transform = matrixFire;
            //Draw the missile
            g.DrawImage(fire, fireRec);

        }
        public void moveFire(Graphics g)
        {
            x += (int)xSpeed;//cast double to an integer value
            y -= (int)ySpeed;
            fireRec.Location = new Point(x, y);//fires new location

        }
    }

}
