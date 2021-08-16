using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Cultist
    {
        public int x, y, width, height;//variables for the rectangle
        public Image cultist;
        public Rectangle cultistRec;//variable for a rectangle to place our image in
        public Cultist()
        {
            x = 550;
            y = 150;
            width = 100;
            height = 100;
            cultist = Properties.Resources.Cultist;
            cultistRec = new Rectangle(x, y, width, height);
        }

        public void drawCultist(Graphics g)
        {
            cultistRec = new Rectangle(x, y, width, height);
            g.DrawImage(cultist, cultistRec);
        }



    }
}

