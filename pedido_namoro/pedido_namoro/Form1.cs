using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pedido_namoro
{
    public partial class Form1 : Form
    {

        Random sorteio = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int x = button1.Location.X;
            int y = button1.Location.Y;

            int W = this.Size.Width - button1.Size.Width;
            int H = this.Size.Height - button1.Size.Height - 25;

            x = sorteio.Next(200, W);
            y = sorteio.Next(200, H);

            button1.Location = new Point(x, y);
        }
    }
}
