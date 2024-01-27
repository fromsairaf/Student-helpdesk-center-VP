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
    public partial class Form1_Register : Form
    {
        //Creating Connection with database
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\AYAT COMPUTER\Documents\Registration.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        public Form1_Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textU_name.Text=="" && text_password.Text=="" && text_cnfrmPassword.Text=="")
            {

                MessageBox.Show("Username and password fields are empty", "Registration couldn't be taken place", MessageBoxButtons.OK, MessageBoxIcon.Error);
               

            }
           
           
            else if (text_password.Text == text_cnfrmPassword.Text)
            {
                conn.Open();
                //these code work to send user credentials to the database we created
                MessageBox.Show("Connection is Working");
                cmd = new SqlCommand("Insert into user_data (username, Password) values ('" + textU_name.Text + "', '" + text_password.Text + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                textU_name.Text = "";
                text_cnfrmPassword.Text = "";
                text_password.Text = "";


                MessageBox.Show("Your Account has been created successfully!", "Resgistration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password is not same, please re-enter password", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_password.Text = "";
                text_cnfrmPassword.Text = "";
                text_password.Focus();
            }    
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked){
                text_password.PasswordChar = '\0';
                text_cnfrmPassword.PasswordChar = '\0';
            }
            else
            {
                text_password.PasswordChar = '•';
                text_cnfrmPassword.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textU_name.Text = "";
            text_cnfrmPassword.Text = "";
            text_password.Text = "";
            textU_name.Focus();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //adding these lines to move to Login page
            new Form2_Login().Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
