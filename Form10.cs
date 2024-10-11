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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using ZXing;

namespace BarosDashboard
{
    public partial class reserve : Form
    {
        public static string chair_ { get; set; }

        public reserve()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void Request_Click(object sender, EventArgs e) { }

        private void reserveCourt_Click(object sender, EventArgs e)
        {
            FormBas formbas = new FormBas();
            formbas.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTable table = new FormTable();
            table.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormChair chair = new FormChair();
            chair.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTent tent = new FormTent();
            tent.Show();
            Visible = false;
        }

        private void backReq_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.Show();
            Visible = false;
        }

        private void reserve_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void bloodTypeBox_SelectedIndexChanged(object sender, EventArgs e) { }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int userId = LoggedInUser.UserId;
            chair_ = resType.Text;

            string connectionString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";

            // Query to insert a reservation
            string query = "INSERT INTO reservations (fname, contact_num, reservation_type, reason, reservation_date, reservation_start_time, reservation_end_time, quantity, user_id, reservation_status) " +
                           "VALUES (@Fullname, @ContactNumber, @reservationType, @reason, @Resdate, @Restime, @Endtime, @quantity, @userID, @resStatus)";

            // Validate input fields
            if (string.IsNullOrWhiteSpace(Fname.Text) || string.IsNullOrWhiteSpace(contact.Text) ||
                string.IsNullOrWhiteSpace(resType.Text) || string.IsNullOrWhiteSpace(reqbox.Text) ||
                string.IsNullOrWhiteSpace(date1.Text)) // Validate endTime
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Try to parse the date input
            DateTime reservationDate;
            if (!DateTime.TryParse(date1.Text, out reservationDate))
            {
                MessageBox.Show("Invalid date format. Please use MM/DD/YYYY or DD/MM/YYYY.");
                return;
            }

            // Format the date to YYYY-MM-DD
            string formattedDate = reservationDate.ToString("yyyy-MM-dd");

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the user ID exists in the users table
                    string checkUserQuery = "SELECT COUNT(*) FROM users WHERE user_id = @userID";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkUserQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@userID", userId);
                        int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        // If user does not exist, show a message and return
                        if (userCount == 0)
                        {
                            MessageBox.Show("User does not exist. Please register the user first.");
                            return;
                        }
                    }

                    // Proceed with the reservation insert
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Fullname", Fname.Text);
                        cmd.Parameters.AddWithValue("@ContactNumber", contact.Text);
                        cmd.Parameters.AddWithValue("@reservationType", chair_);
                        cmd.Parameters.AddWithValue("@reason", reqbox.Text);
                        cmd.Parameters.AddWithValue("@Resdate", formattedDate);
                        cmd.Parameters.AddWithValue("@Restime", time.Text);
                        cmd.Parameters.AddWithValue("@Endtime", textBox1.Text);
                        cmd.Parameters.AddWithValue("@quantity", quantity.Text);
                        cmd.Parameters.AddWithValue("@userID", userId);  // Foreign key to user_id in users table
                        cmd.Parameters.AddWithValue("@resStatus", "Pending");


                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} record(s) inserted.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Display detailed error information
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void time_SelectedIndexChanged(object sender, EventArgs e) { }

        private void resType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resType.SelectedItem == "BASKETBALL COURT")
            { 
                quantity.Hide();
                panel6.Hide();
                label12.Hide();
            }
            else
            {
                quantity.Show();
                panel6.Show();
                label12.Show();
            }
        }
    }
}
