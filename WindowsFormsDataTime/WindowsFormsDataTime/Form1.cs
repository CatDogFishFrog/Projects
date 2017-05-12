using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDataTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker2.MaxDate = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            DateTime time_b = Convert.ToDateTime(maskedTextBox1.Text);
            int days_l = Convert.ToInt32(textBox3.Text);
            DateTime dt1 = dateTimePicker2.Value;
            DateTime dt2 = DateTime.Now;
            int DaysLive = (dt2-dt1).Days;
            listBox1.Items.Add("Вы - " + name);
            listBox1.Items.Add(String.Format("Вы прожили {0} дней", DaysLive));
            listBox1.Items.Add(String.Format("Вы хотите еще учится {0} дней", days_l));
            dt1 = dt1.AddDays(days_l);
            listBox1.Items.Add("Вы станете умным " + dt1);
            listBox1.Items.Add("Это будет в " + dt1.DayOfWeek);
        }
    }
}
