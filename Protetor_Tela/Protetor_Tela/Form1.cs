using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protetor_Tela
{
    public partial class Form1 : Form
    {
        int contador = 0;        
        int delta_x = 1;       
        int delta_y = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int window_width = this.Size.Width;
            int window_height = this.Size.Height - 25;

            int pic_width = pictureBox1.Size.Width;
            int pic_height = pictureBox1.Size.Height;

            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            x = x + delta_x;
            y = y + delta_y;

            if((x >(window_width - pic_width)) || x < 0)
            {
                delta_x = -delta_x;
            }
            else
            {
                pictureBox1.Location = new Point(x, y);
            }

            if ((y > (window_height - pic_height)) || y < 0)
            {
                delta_y = -delta_y;
            }
            else
            {
                pictureBox1.Location = new Point(x, y);
            }
        }
    }
}
