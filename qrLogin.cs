using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
namespace BarosDashboard
{

    public partial class qrLogin : Form
    {
        private string qrDataBuffer = ""; // Buffer to hold scanned QR code data
        public qrLogin()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void qrLogin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void qrLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Process the QR code once 'Enter' is pressed
                LoginWithQRCode(qrDataBuffer);
                qrDataBuffer = ""; // Clear buffer after login attempt
            }
            else
            {
                // Accumulate characters for QR code
                qrDataBuffer += e.KeyChar;
            }
        }
        private void LoginWithQRCode(string qrData)
        {
            if (!string.IsNullOrEmpty(qrData))
            {
                using (MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;"))
                {
                    connection.Open();
                    string query = "SELECT * FROM users WHERE QRCode = @qrData";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@qrData", qrData);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            LoggedInUser.UserId = Convert.ToInt32(reader["user_id"]); // Convert user_id to int                          
                            string username = reader["fullName"].ToString();
                            MessageBox.Show($"Welcome, {username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Proceed to main form or dashboard
                            this.Hide();
                            Form1 mainForm = new Form1();
                            mainForm.Show();
                           
                        }
                        else
                        {
                            MessageBox.Show("Invalid QR Code. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                            
                        }
                    }
                }
            }

        }

        
    }
}
