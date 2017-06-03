using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МногоОконность
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
