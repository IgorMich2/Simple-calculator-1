using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igor
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // label1.Text = "Работает! I want to be programmer!";
            //label1.Text = textBox1.Text;
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a+b;
            label3.Text = "Сумма = " + c;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a - b;
            label4.Text = "Разность = " + c;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a * b;
            label5.Text = "Произведение = " + c;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a / b;
            label6.Text = "Частное = " + c;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = a / b;
            string s = String.Format("{0:#.##}", c);
            label7.Text = "Частное целочисленное = " + s;
        }
    }
}
