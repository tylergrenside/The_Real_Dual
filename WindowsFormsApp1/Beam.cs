using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Beam
    {
        public int x, y, width, height;

        public Image beam;//variable for the beam's image

        public Rectangle beamRec;//variable for a rectangle to place our image in

        // in the following constructor we pass in the values of spaceRec which
        // gives us the position of the spaceship which we can then use to place the
        // missile where the spaceship is located
        public Beam(Rectangle swordRec)
        {
            x = swordRec.X + 37; // move beam to sword
            y = swordRec.Y;
            width = 20;
            height = 20;
            beam = Properties.Resources.Beam;
            beamRec = new Rectangle(x, y, width, height);
        }
        public void draw(Graphics g)
        {
            x += 30;//speed of beam
            beamRec = new Rectangle(x, y, width, height);
            g.DrawImage(beam, beamRec);
        }
    }
}
