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
        List<Planet> planets = new List<Planet>();
        Random yspeed = new Random();
        int ammo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
