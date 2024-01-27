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
    public partial class Form5_Sug : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\AYAT COMPUTER\Documents\Suggestion.mdf"";Integrated Security=True;");
        SqlCommand cmd;
        public Form5_Sug()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show("Connection is working");
            cmd = new SqlCommand("Insert into user_data(Post_Id,Suggestion) values ('" + textBox1.Text + "','" + sugg_txt.Text + "')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your post has been submitted, Thanks!", "post Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        private void btn_viewData_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * from user_data", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete user_data Where Post_Id ='" + textBox1.Text + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Post has been deleted Successfully.", "post deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            sugg_txt.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cnn = new SqlCommand("UPDATE user_data SET Suggestion= @suggestion where Post_id=@ID", conn);
            cnn.Parameters.AddWithValue("@suggestion", sugg_txt.Text);
            cnn.Parameters.AddWithValue("@ID", textBox1.Text);

            cnn.ExecuteNonQuery();
            MessageBox.Show("Record is updated Successfully!", "Record updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        private void serach_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cnn = new SqlCommand("select * from user_data where Post_Id = @ID", conn);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            SqlDataAdapter sd = new SqlDataAdapter(cnn);
            DataTable Table = new DataTable();
            sd.Fill(Table);
            dataGridView1.DataSource = Table;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form4_Sname().Show();
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
