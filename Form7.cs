using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BarosDashboard
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0VUJ82CU;Initial Catalog=userregcs;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void clear2_btn_Click(object sender, EventArgs e)
        {
            txt_ContactNum.Clear();
            txt_password.Clear();

            txt_ContactNum.Focus();
        }

        private void signin_Btn_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txt_ContactNum.Text;
            user_password = txt_password.Text;

            try
            {
                con.Open();
                String query = "SELECT * FROM register WHERE contactNumber = @contactNumber AND password = @password";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("@contactNumber", txt_ContactNum.Text);
                adapter.SelectCommand.Parameters.AddWithValue("@password", txt_password.Text);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = txt_ContactNum.Text;
                    user_password = txt_password.Text;

                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_ContactNum.Clear();
                    txt_password.Clear();

                    txt_ContactNum.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
