﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Fireball
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image fireballimage;//variable for the fireball's image

        public Rectangle fireballRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Fireball(int displacement)
        {
            x = 500;
            y = displacement;
            width = 30;
            height = 30;
            fireballimage = Properties.Resources.Fireball;
            fireballRec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void draw(Graphics g)
        {
            fireballRec = new Rectangle(x, y, width, height);

            g.DrawImage(fireballimage, fireballRec);
        }
        public void moveFireball(Graphics g)
        {
            x += 5;
            fireballRec.Location = new Point(x, y);

        }
    }

}

