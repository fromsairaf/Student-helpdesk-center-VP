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
    public partial class Form0_Main : Form
    {
        public Form0_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1_Register().Show();
            this.Hide();
        }

        private void Form0_Main_Load(object sender, EventArgs e)
        {

        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            new Form1_Register().Show();
            this.Hide();
        }

        private void btn_viewData_Click(object sender, EventArgs e)
        {
            new Form1_Register().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2_Login().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form3_dboard().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            new Form7_Finish().Show();
                this.Hide();
        }
    }
}
