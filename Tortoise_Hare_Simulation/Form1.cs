using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortoise_Hare_Simulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Tortoise T = new Tortoise();
        Hare H = new Hare();

        public class Contender
        {
            //position # of contender
            protected int iPosition;
            //number of steps in the race
            protected int iNumberSteps;
            //color of contender
            protected Color Colour;

            //constructors
            public Contender()
            {
                iPosition = 0;
                iNumberSteps = 70;
                Colour = Color.OrangeRed;
            }
            public Contender(int position, int numbersteps, Color c)
            {
                setiPosition(position);
                setiNumberSteps(numbersteps);
                setColour(c);
            }
            public Contender(Contender clone)
            {
                iPosition = clone.iPosition;
                iNumberSteps = clone.iNumberSteps;
                Colour = clone.Colour;
            }


            public void setiNumberSteps(int steps)
            {
                if (steps <= 0)
                    throw (new FormatException());

                else
                    iNumberSteps = steps;
            }
            public int GetiNumberSteps()
            {
                return iNumberSteps;
            }

            public void setColour(Color c)
            {
                Colour = c;
            }
            public Color GetColour()
            {
                return Colour;
            }

            public void setiPosition(int p)
            {
                if (p < 0)
                    iPosition=0;

                else
                    iPosition = p;


            }
            public int GetiPosition()
            {
                return iPosition;
            }

            public bool IsWinner()
            {
                if (iPosition >= iNumberSteps)
                    return true;
                else
                    return false;

            }

        }

        public class Tortoise : Contender
        {

            Random r=new Random();
            
            public void UpdatePosition()
            {
                //rnd number upto 100
                int iPercentage = r.Next(100);

                if (iPercentage < 50) 
                {
                    //Fast plod
                }
                else if (iPercentage >=50 && iPercentage < 70) 
                {
                    //Slip
                }
                else
                {
                    //slow plod
                }
            }

            public void Draw(Graphics g)
            {
                SolidBrush myBrush = new SolidBrush(Colour);
                g.FillEllipse(myBrush, iPosition * 5, 175, 15, 15);
            }
        }

        public class Hare : Contender
        {
            Random r = new Random();
            public void UpdatePosition()
            {
                //rnd number upto 100
                int iPercentage = r.Next(100);

                if (iPercentage < 20)
                {
                    //Sleep
                }
                else if (iPercentage >= 20 && iPercentage < 40)
                {
                    //Big hop
                }
                else if (iPercentage >= 40 && iPercentage < 50)
                {
                    //Big slip
                }
                else if (iPercentage >= 50 && iPercentage < 80)
                {
                    //Small hop
                }
                else
                {
                    //small slip
                }
            }

            public void Draw(Graphics e)
            {

            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            H.Draw(e.Graphics);
            T.Draw(e.Graphics);
        }
    }

    

}
