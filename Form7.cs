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
            btnAdminLogin.Hide();
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
            LoggedInUser.Uname = txt_ContactNum.Text;

            if (string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both contact and password.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(conn))
                {
                    con.Open();
                    // Modified query to select the status along with the user_id
                    string query = "SELECT user_id, stats FROM users WHERE contact=@contact AND password=@password";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = reader.GetInt32("user_id");
                                string status = reader.GetString("stats");

                                // Check if the account is still pending
                                if (status == "Pending")
                                {
                                    Pending lpend = new Pending();
                                    lpend.Show();
                                    this.Hide();
                                    return; // Don't proceed with login
                                }

                                // Check if the account is accepted
                                if (status == "Accepted")
                                {
                                    LoggedInUser.UserId = userId;
                                    signin_Btn.Text = "Login successful!";
                                    Form1 form1 = new Form1();
                                    form1.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Your account has been rejected or is in an invalid state.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect contact or password.");
                            }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_password.PasswordChar = '\0'; // Show password
            }
            else
            {
                txt_password.PasswordChar = '*'; // Hide password
            }
        }

        private void btnToScan_Click(object sender, EventArgs e)
        {
            qrLogin scanner = new qrLogin();
            scanner.Show();
            this.Hide();
        }



        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            adminLogin login = new adminLogin();
            login.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            btnAdminLogin.Show();
        }
    }
}