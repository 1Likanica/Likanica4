using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Likanica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            double Xo = Convert.ToDouble(textBox1.Text);
            double Xk = Convert.ToDouble(textBox2.Text);
            double Dx = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);

            if (Xo > Xk) (Xo, Xk) = (Xk, Xo);
            if (Dx <= 0)
            {
                MessageBox.Show("Неправильный шаг");
                return;
            }

            double x = Xo;

            while (x <= Xk)
            {
                double y = Math.Round((Math.Pow(x, 2.5)-b)*(Math.Log(Math.Pow(x, 2)+12.7)), 3);
                textBox5.Text += "x = " + x.ToString() + "   |   y = " + y.ToString() + Environment.NewLine;
                x += Dx;
            }
        }
    }
}
