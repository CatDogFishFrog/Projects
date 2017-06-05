using System;
using System.Windows.Forms;

namespace Опасный_Вирус
{
    public partial class Form1 : Form
    {

        Timer time = new Timer();
        public Form1()
        {
            time.Tick += new EventHandler(IncresaProgressBar);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            time.Interval = 250;
            //time.Tick += new EventHandler(IncresaProgressBar);
            time.Start();
            label1.Text = "Заражение началось!";
            button1.Enabled = false;
            button3.Enabled = true;
            button2.Enabled = true;
        }

        private void IncresaProgressBar(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            toolStripStatusLabel1.Text ="Немного      информации:      "+ progressBar1.Value.ToString() +"%   Выполнено                                                              ";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                time.Stop();
                progressBar1.Value = 0;
                label1.Text = "Ахаха! Ваш компьютер заражен!";
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не клацай, блэ!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            time.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
            label1.Text = "Заражение приостановлено...";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = true;
            time.Stop();
            progressBar1.Value = 0;
            toolStripStatusLabel1.Text = "Немного      информации:      0%   Выполнено                                                              ";
            label1.Text = "Вирус обезврежен...";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
