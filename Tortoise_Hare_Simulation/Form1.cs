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
        //need second constructor
        public Contender()
        {

        }

        public Contender(Contender clone)
        {
            iPosition = clone.iPosition;
            iNumberSteps = clone.iNumberSteps;
            Colour = clone.Colour;
        }

        public void setiNumberSteps(int steps)
        {
            iNumberSteps = steps;
        }
        public int GetiNumberSteps ()
        {
            return iNumberSteps;
        }

        public void setColour(Color setcolour)
        {
            Colour = setcolour;
        }
        public Color GetColour()
        {
            return Colour;
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

    }

    public class Hare : Contender
    {
        //type type type
        //poo
    }

}
