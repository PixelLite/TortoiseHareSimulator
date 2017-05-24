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
    }

    public class Contender
    {
        protected int iPosition;
        //position # of contender
        protected int iNumberSteps;
        //number of steps in the race
        protected Color Colour;
        //colour of contender

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
        public int GetiNumberSteps ()
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
                throw (new FormatException());
            
            else
            iPosition = p;
            

        }
        public int GetiPosition()
        {
            return iPosition;
        }
        public bool IsWinner()
        {
            if (iPosition == iNumberSteps)
                return true;
            else
                return false;

        }

    }
    public class Tortoise: Contender
    {
        public void UpdatePosition()
        {

        }

    }

    public class Hare : Contender
    {
       
    }

}
