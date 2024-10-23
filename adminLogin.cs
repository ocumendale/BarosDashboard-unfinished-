using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace BarosDashboard
{
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void adminLogin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void signBtn_Click(object sender, EventArgs e)
        {



            string conn = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string username = txt_Username.Text.Trim();
            string password = txt_Pass.Text.Trim();


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
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
                    string query = "SELECT * FROM admin1 WHERE username=@username AND password=@password";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DocumentRequest admin = new DocumentRequest();
                                admin.Show();
                                this.Hide();
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

        private void clear_btn_Click(object sender, EventArgs e)
        {
            txt_Username.Clear();
            txt_Pass.Clear();

            txt_Username.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_Pass.PasswordChar = '\0'; // Show password
            }
            else
            {
                txt_Pass.PasswordChar = '*'; // Hide password
            }

        }

        private void txt_Contact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

