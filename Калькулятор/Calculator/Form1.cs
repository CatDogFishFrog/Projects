using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace Calculator
{
    public partial class Form1 : MetroForm
    {
        bool plus = false;
        bool minus = false;
        bool gam = false;
        bool gay = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) { textBox1.Text += 1; }

        private void button2_Click(object sender, EventArgs e) { textBox1.Text += 2; }

        private void button3_Click(object sender, EventArgs e) { textBox1.Text += 3; }

        private void button4_Click(object sender, EventArgs e) { textBox1.Text += 4; }

        private void button5_Click(object sender, EventArgs e) { textBox1.Text += 5; }

        private void button6_Click(object sender, EventArgs e) { textBox1.Text += 6; }

        private void button7_Click(object sender, EventArgs e) { textBox1.Text += 7; }

        private void button8_Click(object sender, EventArgs e) { textBox1.Text += 8; }

        private void button9_Click(object sender, EventArgs e) { textBox1.Text += 9; }

        private void button10_Click(object sender, EventArgs e) { textBox1.Text += 0; }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") { textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text))); }
            else return;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") { textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text)); }
            else return;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                plus = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }
            else return;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                minus = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }
            else return;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                gam = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }
            else return;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                gay = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }
            else return;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (plus)
            {
                decimal x = Convert.ToDecimal(textBox1.Tag) + Convert.ToDecimal(textBox1.Text);
                textBox1.Text = x.ToString();
                plus = false;
            }
            if (minus)
            {
                decimal x = Convert.ToDecimal(textBox1.Tag) - Convert.ToDecimal(textBox1.Text);
                textBox1.Text = x.ToString();
                minus = false;
            }
            if (gam)
            {
                decimal x = Convert.ToDecimal(textBox1.Tag) * Convert.ToDecimal(textBox1.Text);
                textBox1.Text = x.ToString();
                gam = false;
            }
            if (gay)
            {
                decimal x = Convert.ToDecimal(textBox1.Tag) / Convert.ToDecimal(textBox1.Text);
                textBox1.Text = x.ToString();
                gay = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            plus = minus = gay = gam = false;
            textBox1.Text = "";
            textBox1.Tag = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(",")) { return; }
            else { textBox1.Text = textBox1.Text + ","; }
        }
    }
}
