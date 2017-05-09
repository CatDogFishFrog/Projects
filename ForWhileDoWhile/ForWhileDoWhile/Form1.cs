using System;
using MetroFramework.Forms;

namespace ForWhileDoWhile
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonFor_Click(object sender, EventArgs e)
        {
            double S = 0, x = Convert.ToDouble(TextBoxWhenX.Text);
            for (int k = 1; k <= 5; k++)
                S += Math.Pow(x, k + 1) / (Math.Pow(2, k) + k);
            forfor.Text = Convert.ToString(S);

        }

        private void ButtonWhile_Click(object sender, EventArgs e)
        {
            double S = 0, x = Convert.ToDouble(TextBoxWhenX.Text);
            int k = 1;
            while (k <= 5)
            {
                S += Math.Pow(x, k + 1) / (Math.Pow(2, k) + k);
                k++;
            }
            forwhile.Text = Convert.ToString(S);
        }

        private void ButtonDoWhile_Click(object sender, EventArgs e)
        {
            double S = 0, x = Convert.ToDouble(TextBoxWhenX.Text);
            int k = 1;
            do
            {
                S += Math.Pow(x, k + 1) / (Math.Pow(2, k) + k);
                k++;
            } while (k <= 5);
            fordowhile.Text = Convert.ToString(S);
        }
    }
}
