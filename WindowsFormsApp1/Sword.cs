using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Sword
    {
        public int x, y, width, height;//variables for the rectangle
        public Image sword;//variable for the swords's image

        public Rectangle swordRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)

        public Sword()
        {
            x = 10;
            y = 350;
            width = 73;
            height = 39;
            sword = Properties.Resources.Sword;
            swordRec = new Rectangle(x, y, width, height);
        }

        public void drawSword(Graphics g)
        {
            g.DrawImage(sword, swordRec);
        }

       
    }
}
