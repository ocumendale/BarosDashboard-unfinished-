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

namespace BarosDashboard
{
    public partial class userRegistration : Form
    {
        public userRegistration()
        {
            InitializeComponent();
        }

        private void fullname_txtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_Btn_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-0VUJ82CU;Initial Catalog=userregcs;Integrated Security=True;TrustServerCertificate=True";
            string query = "INSERT INTO [dbo].[register] ([fullname], [email], [contactNumber], [password]) VALUES (@FullName, @Email, @ContactNumber, @Password)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullname_txtb.Text);
                    cmd.Parameters.AddWithValue("@Email", email_txtb.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", contact_txtb.Text);
                    cmd.Parameters.AddWithValue("@Password", password_txtb.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            MessageBox.Show("Register Successfully");
        }

        private void userRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backtolog_lbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            Visible = false;
        }
    }
}
