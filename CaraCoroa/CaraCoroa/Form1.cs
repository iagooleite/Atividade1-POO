using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaraCoroa
{
    public partial class Form1 : Form
    {
        Random sorteio= new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Selecione uma opção");
            }

            timer1.Interval = 30;
            timer1.Start();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void resultado()
        {
            int resultado = sorteio.Next(2);

            if (resultado == 0)
            {
                if (radioButton1.Checked)
                {
                    MessageBox.Show("Você ganhou! Que cagada!");
                }

                else
                {
                    MessageBox.Show("Você perdeu! Não jogue no tigrinho!");
                }
            }

            if (resultado == 1)
            {
                if (radioButton2.Checked)
                {
                    MessageBox.Show("Você ganhou! Que cagada!");
                }
                else
                {
                    MessageBox.Show("Você perdeu! Não jogue no tigrinho!");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = !pictureBox2.Visible;

            timer1.Interval += 20;
            
            if(timer1.Interval >= 400)
            {
                timer1.Stop();
                resultado();
            }
        }
    }
}
