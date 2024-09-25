using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace BarosDashboard
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void clear2_btn_Click(object sender, EventArgs e)
        {
            txt_ContactNum.Clear();
            txt_password.Clear();

            txt_ContactNum.Focus();
        }

        private void signin_Btn_Click(object sender, EventArgs e)
        {


            string conn = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string contact = txt_ContactNum.Text.Trim();
            string password = txt_password.Text.Trim();
            LoggedInUser.uname = txt_ContactNum.Text;
            if (string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(password))
            {
                signin_Btn.Text = "Please enter both contact and password.";
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(conn))
                {
                    con.Open();
                    string query = "SELECT COUNT(1) FROM users WHERE contact=@contact AND password=@password";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            signin_Btn.Text = "Login successful!";
                            Form1 form1 = new Form1();
                            form1.Show();
                            this.Hide();

                        }
                        else
                        {
                            signin_Btn.Text = "Incorrect contact or password.";
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void signUpLogo_Click(object sender, EventArgs e)
        {

        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            userRegistration userRegistration = new userRegistration();
            userRegistration.Show();
            this.Hide();
        }
    }
}