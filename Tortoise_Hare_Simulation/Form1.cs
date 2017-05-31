using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tortoise_Hare_Simulation
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            
        }

        Timer timer = new Timer();
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
            //counts # of wins
            protected int iWinCount;

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
            public int  GetiNumberSteps()
            {
                return iNumberSteps;
            }

            public void  setColour(Color c)
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
            public int  GetiPosition()
            {
                return iPosition;
            }

            public void SetWinCount(int w)
            {
                iWinCount = w;
            }
            public int  GetWinCount()
            {
                return iWinCount;
            }

            public void IncreaseWinCount()
            {
                iWinCount++;
                
            }
            public bool IsWinner()
            {
                if (iPosition >= iNumberSteps)
                    return true;
                else
                    return false;
            }
            public void CheckOutofBounds()
            {
                if (iPosition > iNumberSteps)
                {
                    iPosition = iNumberSteps;
                }
                else if (iPosition < 0)
                {
                    iPosition = 0;
                }
                else
                {

                }
            }

            public bool DidYaBite (Contender Other )
            {
                if (this.iPosition == Other.iPosition)
                    return true;
                else
                    return false;
                
            }
        }

        public class Tortoise : Contender
        {

            Random r;
            
            public Tortoise()
            {
                iPosition = 0;
                iNumberSteps = 70;
                Colour = Color.OrangeRed;
                r = new Random();
            }

            public Tortoise(int position, int numbersteps, Color c)
            {
                setiPosition(position);
                setiNumberSteps(numbersteps);
                setColour(c);
                r = new Random();
            }

            public void UpdatePosition()
            {
                //rnd number upto 100
                int iPercentage = r.Next(100);

                if (iPercentage < 50) 
                {
                    //fast plod
                    setiPosition(iPosition + 3);
                }
                else if (iPercentage >=50 && iPercentage < 70) 
                {
                    //slip
                    setiPosition(iPosition - 6);
                }
                else
                {
                    //slow plod
                    setiPosition(iPosition + 1);
                }
            }

            public void Draw(Graphics g)
            {
                SolidBrush myBrush = new SolidBrush(Colour);
                g.FillEllipse(myBrush, iPosition * 10, 50, 10, 10);
            }
        }

        public class Hare : Contender
        {
            Random r;

            public Hare()
            {
                iPosition = 0;
                iNumberSteps = 70;
                Colour = Color.OrangeRed;
                r=new Random();
            }

            public Hare(int position, int numbersteps, Color c)
            {
                setiPosition(position);
                setiNumberSteps(numbersteps);
                setColour(c);
                r=new Random();
            }

            public void UpdatePosition()
            {
                //rnd number up to 100
                int iPercentage = r.Next(100);

                if (iPercentage < 20)
                {
                    //Sleep
                    setiPosition(iPosition);
                }
                else if (iPercentage >= 20 && iPercentage < 40)
                {
                    //Big hop
                    setiPosition(iPosition + 9);
                }
                else if (iPercentage >= 40 && iPercentage < 50)
                {
                    //Big slip
                    setiPosition(iPosition - 12);

                }
                else if (iPercentage >= 50 && iPercentage < 80)
                {
                    //Small hop
                    setiPosition(iPosition + 1);
                }
                else
                {
                    //small slip
                    setiPosition(iPosition - 2);
                }
            }

            public void Draw(Graphics g)
            {
                SolidBrush myBrush = new SolidBrush(Colour);
                g.FillRectangle(myBrush, iPosition * 10, 50, 10, 10);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Black);

            float[] dashValues = {10, 10};
            myPen.DashPattern = dashValues;
            e.Graphics.DrawLine(myPen, 0, 70, 700, 70);

            //Changes position of tortoise graphic
            Point pTort;

            pTort = new Point();
            pTort.X = T.GetiPosition() * 10 + 12;
            pTort.Y = 85;
            picbox_Tortoise.Location = pTort;

            //Changes position of hare graphic
            Point pHare;

            pHare = new Point();
            pHare.X = H.GetiPosition() * 10 + 12;
            pHare.Y = 49;
            picbox_Hare.Location = pHare;

            //H.Draw(e.Graphics);
            //T.Draw(e.Graphics);
        }

        private void btnStartRace_Click(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000 / trckSpeed.Value;    // Timer speed changes with trckspeed bar
            timer.Enabled = true;                       // Enable the timer
            timer.Start();                              // Start the timer
            btnStartRace.Hide();
            btnPause.Visible = true;

        }

        void timer_Tick(object sender, EventArgs e)
        {
            T.UpdatePosition();
            H.UpdatePosition();

            pictureBox1.Invalidate();

            if (T.DidYaBite(H) == true)
            {
                lboxCommentary.Items.Add("OUCH");

            }

            T.CheckOutofBounds();
            H.CheckOutofBounds();

            if (T.IsWinner() == true && H.IsWinner() == true)
            {
                timer.Stop();
                btnStartRace.Visible = true;
                lboxCommentary.Items.Add("It's a tie.");
            }
            else if (T.IsWinner()== true)
            {
                T.SetWinCount(T.GetWinCount() + 1);
                lblScoreT.Text = T.GetWinCount().ToString();
                timer.Stop();
                btnStartRace.Visible = true;
                lboxCommentary.Items.Add("TORTOISE WINS!!!!! YAY!!!!!");
            } 
            else if (H.IsWinner() == true)
            {
                H.SetWinCount(H.GetWinCount() + 1);
                lblScoreH.Text = H.GetWinCount().ToString();
                timer.Stop();
                btnStartRace.Visible = true;
                lboxCommentary.Items.Add("Hare wins. Booooo");
            }
            else
            {

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Resets current simulation but keeps current score
            
            H.setiPosition(0);
            T.setiPosition(0);
            pictureBox1.Invalidate();
            timer.Stop();
            timer.Tick -= new EventHandler(timer_Tick);
            btnStartRace.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //New simulation, new score

            H.setiPosition(0);
            H.SetWinCount(0);
            lblScoreH.Text = 0.ToString();

            T.setiPosition(0);
            T.SetWinCount(0);
            lblScoreT.Text = 0.ToString();

            lboxCommentary.Items.Clear();
            pictureBox1.Invalidate();
            timer.Stop();
            timer.Tick -= new EventHandler(timer_Tick);
            btnStartRace.Visible = true; 
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Tick -= new EventHandler(timer_Tick);
            btnPause.Hide();
            btnStartRace.Visible = true;
        }
        
        private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string filename;
                SaveFileDialog SaveAs = new SaveFileDialog();
                SaveAs.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (SaveAs.ShowDialog() == DialogResult.OK)
                {
                    filename = SaveAs.FileName;

                    TextWriter tw = new StreamWriter(filename);
                    tw.WriteLine(DateTime.Now);

                    tw.WriteLine(Convert.ToString(T.GetWinCount()));
                    tw.WriteLine(Convert.ToString(H.GetWinCount()));

                    tw.Close();
                }
            }
            catch
            {
                MessageBox.Show("ERROR: Invalid file input.");
            }
        }

        private void binaryFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string filename;
                SaveFileDialog SaveAsBinary = new SaveFileDialog();
                SaveAsBinary.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";

                if (SaveAsBinary.ShowDialog() == DialogResult.OK)
                {
                    filename = SaveAsBinary.FileName;
                    FileStream fs = new FileStream(filename, FileMode.Create);

                    BinaryWriter binWriter = new BinaryWriter(fs);
                    binWriter.Write(DateTime.Now.ToString());
                    //writes the timestamp at the top

                    binWriter.Write(T.GetWinCount());
                    binWriter.Write(H.GetWinCount());

                    binWriter.Flush();
                    binWriter.Close();
                    //closes binWriter


                }


            }
            catch
            {
                MessageBox.Show("ERROR! TRY AGAIN!");
            }
        }

        private void textFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string filename;
                OpenFileDialog Open = new OpenFileDialog();
                Open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (Open.ShowDialog() == DialogResult.OK)
                {
                    filename = Open.FileName;
                    TextReader tr = new StreamReader(filename);
                    
                    MessageBox.Show("This file was created at " + tr.ReadLine());

                    T.SetWinCount(Convert.ToInt32(tr.ReadLine()));
                    H.SetWinCount(Convert.ToInt32(tr.ReadLine()));

                    //closes stream
                    tr.Close();

                }


            }
            catch
            {
                MessageBox.Show("ERROR! TRY AGAIN!");
            }
        }

        private void binaryFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string filename;
                long length;
                OpenFileDialog OpenBinary = new OpenFileDialog();
                OpenBinary.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";

                if (OpenBinary.ShowDialog() == DialogResult.OK)
                {
                    // It creates a new BinaryReader.
                    filename = OpenBinary.FileName;
                    FileStream fs = new FileStream(filename, FileMode.Open);
                    BinaryReader binReader = new BinaryReader(fs);

                    //It uses position and length variables.
                    // These two variables store the position in the binary file we are,
                    // and also the total size of the binary file.
                    length = binReader.BaseStream.Length;
                    
                    MessageBox.Show("This file was created at " + Convert.ToDateTime(binReader.ReadString()));
                    //shows the time the file was created in a message box


                    while (fs.Position < length)
                    {
                        T.SetWinCount(binReader.ReadInt32());
                        H.SetWinCount(binReader.ReadInt32());
                    }
                    binReader.Close();
                }
            }
            catch
            {
                MessageBox.Show("ERROR. TRY AGAIN!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

    

}
