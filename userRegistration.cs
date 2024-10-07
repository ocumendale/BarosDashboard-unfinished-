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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            string connString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string fullName = fullname_txtb.Text.Trim();
            string contact = contact_txtb.Text.Trim();
            string email = email_txtb.Text.Trim();
            string password = password_txtb.Text.Trim();
            string address = address_txb.Text.Trim();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields.");
                
                return;
            }
            else
            

            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                        string query = "INSERT INTO users (fullName, contact, password, email, address) VALUES (@fullName, @contact, @password, @email, @address)";
                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@fullName", fullName);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@address", address);

                        cmd.ExecuteNonQuery();
                        

                            Pending pend = new Pending();
                            pend.Show();
                            this.Hide();
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

        private void userRegistration_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
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

        private void contact_lbl_Click(object sender, EventArgs e)
        {

        }

        private void password_txtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            fullname_txtb.Clear();
            email_txtb.Clear();
            contact_txtb.Clear();
            password_txtb.Clear();

            
        }

        private void email_txtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                password_txtb.PasswordChar = '\0'; // Show password
            }
            else
            {
                password_txtb.PasswordChar = '*'; // Hide password
            }
        }
    }
}
