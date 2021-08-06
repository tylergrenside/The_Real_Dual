using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g
        Sword sword = new Sword();//create object called Sword
        //declare a list  missiles from the missile class
        List<Beam> beams = new List<Beam>();
        List<Fireball> fireballs = new List<Fireball>();
        Random xspeed = new Random();

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int displacement = 10 + (i * 70);
                fireballs.Add(new Fireball(displacement));
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            sword.drawSword(g);
            foreach (Beam m in beams)
            {
                m.draw(g);
            }
            foreach (Fireball p in fireballs)
            {

                //if the Fireball reaches the left side of the form relocate it back to the top
                if (p.x >= ClientSize.Width) //The hyphen inverts the coordinates
                {
                    p.x = 400;
                   
                    
                }

            }
            for (int i = 0; i < 7; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed

                int rndmspeed = xspeed.Next(5, 20);
                fireballs[i].x += -(rndmspeed);



                //call the firebell's class's drawFirebeall method to draw the images
                fireballs[i].draw(g);
            }
            
        }

        private void tmrSword_Tick(object sender, EventArgs e)
        {
           /* for (int i = 0; i < 7; i++)
            {


                *//*if (sword.swordRec.IntersectsWith(fireballs[i].fireballRec))
                {
                    //reset planet[i] back to top of panel
                    fireballs[i].y = 30; // set  y value of planetRec
                    tmrShoot.Enabled = false;
                    tmrFireball.Enabled = false;
                }*//*
            }*/

            this.Invalidate();
        }

        private void tmrFireball_Tick(object sender, EventArgs e)
        {

        }
    }
}
