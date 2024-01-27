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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            new Form7_Finish().Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            new Form0_Main().Show();
            this.Hide();
        }

        
    }
}
