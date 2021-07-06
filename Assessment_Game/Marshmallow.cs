using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Assessment_Game
{
    class Marshmallow
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image marshmallowImage;//variable for the planet's image

        public Rectangle marshmallowRec;//variable for a rectangle to place our image in

        // Methods for the Planet class
        public void DrawMarshmallow(Graphics g)
        {
            marshmallowRec = new Rectangle(x, y, width, height);
            g.DrawImage(marshmallowImage, marshmallowRec);
        }
        public void MoveMarshmallow()
        {
            marshmallowRec.Location = new Point(x, y);
        }


        //Create a constructor (initialises the values of the fields)
        public Marshmallow(int spacing)
        {
            x = spacing;
            y = 10;
            width = 60;
            height = 40;
            //planetImage contains the planet1.png image
            marshmallowImage = Properties.Resources.marshmallow;
            marshmallowRec = new Rectangle(x, y, width, height);
        }
    }
}
