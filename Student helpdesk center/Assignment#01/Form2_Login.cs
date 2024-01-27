using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment_01
{
    public partial class Form2_Login : Form
    {
        //Creating Connection with database
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\AYAT COMPUTER\Documents\Registration.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        public Form2_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            conn.Open();
            string login = "SELECT * FROM user_data WHERE username = @username AND Password = @password";
            SqlCommand cmd = new SqlCommand(login, conn);
            cmd.Parameters.AddWithValue("@username", textU_name.Text);
            cmd.Parameters.AddWithValue("@password", text_password.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                new Form3_dboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username and password, please try Again", "Login couldn't take place.", MessageBoxButtons.OK, MessageBoxIcon.Error );
                textU_name.Text = "";
                text_password.Text = "";
                textU_name.Focus();
            }
            conn.Close();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textU_name.Text = "";
            text_password.Text = "";
            textU_name.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked)
                {
                      text_password.PasswordChar = '\0';
                    
                }
                else
                {
                    text_password.PasswordChar = '•';
                    
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
