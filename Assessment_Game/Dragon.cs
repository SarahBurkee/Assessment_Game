using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace Assessment_Game
{
    class Dragon
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image dragon;//variable for the dragon's image
        public Image dragon2;//variable for the dragon's image
        public int rotationAngle;
        public Matrix matrix;
        Point centre;

        string dragonmovedirection;


        public Rectangle dragonRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)

        public Dragon()
        {
            x = 10;
            y = 380;
            width = 60;
            height = 60;
            rotationAngle = 0;
            dragon = Properties.Resources.dragon;
            dragon2 = Properties.Resources.dragon2;
            dragonRec = new Rectangle(x, y, width, height);
        }

     
        //methods
        public void drawDragon(Graphics g)
        {
            //find the centre point of dragonRec
            centre = new Point(dragonRec.X + width / 2, dragonRec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (spaceRec) about its centre
            matrix.RotateAt(rotationAngle, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the dragon

            if (dragonmovedirection == "left")
            {
                g.DrawImage(dragon2, dragonRec);
            }
            else
            {
                g.DrawImage(dragon, dragonRec);
            }
        }

        public void moveDragon(string move)
        {
            dragonRec.Location = new Point(x, y);

            if (move == "right")
            {
                dragonmovedirection = "right";

                if (dragonRec.Location.X > 450) // is dragon within 50 of right side
                {

                    x = 450;
                    dragonRec.Location = new Point(x, y);
                }
                else
                {
                    x += 10;
                    dragonRec.Location = new Point(x, y);
                }

            }

            if (move == "left")  
                {

                dragonmovedirection = "left";
                if (dragonRec.Location.X < 10) // is dragon within 10 of left side
                {

                    x = 8;
                    dragonRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 8;
                    dragonRec.Location = new Point(x, y);
                }

            }
        }
     }

    

}
