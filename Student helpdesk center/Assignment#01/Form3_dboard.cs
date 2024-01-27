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
    public partial class Form3_dboard : Form
    {
        public Form3_dboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form4_Sname().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form4_Sname().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form4_Sname().Show();
            this.Hide();
        }

        private void Form3_dboard_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form2_Login().Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            new Form0_Main().Show();
            this.Hide();
        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            new Form7_Finish().Show();
            this.Hide();
        }
    }
}
