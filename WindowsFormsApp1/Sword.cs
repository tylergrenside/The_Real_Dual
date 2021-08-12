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

        public void MoveSword(string move)
        {
            swordRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (swordRec.Location.X > 450) // is Sword within 450 of right side
                {

                    x = 450;
                    swordRec.Location = new Point(x, y);
                }
                else
                {
                    x += 5;
                    swordRec.Location = new Point(x, y);
                }


            }
            if (move == "left")
            {
                if (swordRec.Location.X < 10) // is sword within 10 of left side
                {

                    x = 10;
                    swordRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 5;
                    swordRec.Location = new Point(x, y);
                }

            }
            if (move == "up")
            {
                if (swordRec.Location.Y > 450) // is sword within 450 of top side
                {

                    y = 450;
                    swordRec.Location = new Point(x, y);
                }
                else
                {
                    y -= 5;
                    swordRec.Location = new Point(x, y);
                }

            }
            if (move == "down")
            {
                if (swordRec.Location.Y < 10) // is sword within 10 of bottom side
                {

                    y = -10;
                    swordRec.Location = new Point(x, y);
                }
                else
                {
                    y += 5;
                    swordRec.Location = new Point(x, y);
                }

            }
        }
    }
}
