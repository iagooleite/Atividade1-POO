using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace canhao
{
    public partial class Form1 : Form
    {
        double v0x, v0y;
        int Sx0, Sy0;
        double t;
        double a = 9.81;
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 20;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;

            v0x = Convert.ToDouble(textBox1.Text);
            v0y = -Convert.ToDouble(textBox2.Text);

            Sx0 = pictureBox2.Location.X;
            Sy0 = pictureBox2.Location.Y;

            t = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += 0.2;

            double Sx = Sx0 + (v0x * t);
            double Sy = Sy0 + (v0y * t) + ((a / 2) * Math.Pow(t, 2));

            pictureBox2.Location = new Point((int) Sx, (int) Sy);

            if(pictureBox2.Location.Y >= this.Height)
            {
                timer1.Stop();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
