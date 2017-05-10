using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karkulator
{
    public partial class Form1 : Form
    {
        bool plus = false;
        bool minus = false;
        bool gam = false;
        bool gay = false;

        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Double k;
                k = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Sqrt(k));
            }
            else
            {
                return;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Double x;
                x = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(x);
            }
            else
            {
                return;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                plus = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                minus = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                gam = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                gay = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            plus = minus = gam = gay = false;
            textBox1.Text = "";
            textBox1.Tag = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(","))
            {
                return;
            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += 3.14159;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Double k;
                k = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Sin(k));
            }
            else
            {
                return;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Double k;
                k = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Asin(k));
            }
            else
            {
                return;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Double k;
                k = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Cos(k));
            }
            else
            {
                return;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Double k;
                k = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Acos(k));
            }
            else
            {
                return;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Double k;
                k = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Tan(k));
            }
            else
            {
                return;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Double k;
                k = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Atan(k));
            }
            else
            {
                return;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Double k;
                k = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (1/k) ;
            }
            else
            {
                return;
            }
        }
    }
}
