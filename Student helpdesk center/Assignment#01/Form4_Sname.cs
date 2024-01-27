using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_01
{
    public partial class Form4_Sname : Form
    {
        public Form4_Sname()
        {
            InitializeComponent();
        }

        private void Form4_Sname_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form5_Sug().Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            new Form0_Main().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3_dboard().Show();
            this.Hide();
        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            new Form7_Finish().Show();
            this.Hide();
        }
    }
}
