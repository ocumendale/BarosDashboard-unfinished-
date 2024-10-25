using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using MySql.Data.MySqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using Rectangle = iTextSharp.text.Rectangle;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;

namespace BarosDashboard
{
    public partial class FormRes : Form
    {
        private string selectedTimeSlot = string.Empty; // Store the selected time slot

        public FormRes()
        {
            InitializeComponent();
        }

        private void FormBas_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;

            LoadAvailableTimeSlots();
        }

        private void backCourt_Click(object sender, EventArgs e)
        {
            Services serve = new Services();
            serve.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                // Ensure that resType.SelectedItem is not null before calling ToString()
                if (resType.SelectedItem != null && resType.SelectedItem.ToString() == "BASKETBALL COURT")
                {
                    selectedTimeSlot = comboBox1.Text; // Store the currently selected time slot

                    if (!IsTimeSlotAvailable(dateTimePicker1.Value.Date, selectedTimeSlot))
                    {
                        MessageBox.Show("The selected time slot is already reserved. Please choose another time.", "Time Slot Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                GetDataFromMySQL(selectedTimeSlot);
                MessageBox.Show("Your information has been successfully submitted!", "Submission Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload available time slots only for basketball court
                if (resType.SelectedItem != null && resType.SelectedItem.ToString() == "BASKETBALL COURT")
                {
                    LoadAvailableTimeSlots();
                }

                Form20 form20 = new Form20();
                form20.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Please complete all required fields before submitting.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private bool IsNotNullOrWhiteSpace(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        // Validate inputs based on the reservation type
        private bool ValidateInputs()
        {
            bool isReservationTypeWithTimeSlot = resType.SelectedItem != null && resType.SelectedItem.ToString() == "BASKETBALL COURT";

            return IsNotNullOrWhiteSpace(textBox1.Text) &&  // Validate Fullname
                   IsNotNullOrWhiteSpace(textBox2.Text) &&  // Validate Contact number
                   IsNotNullOrWhiteSpace(textBox3.Text) &&  // Validate Reason
                   (!isReservationTypeWithTimeSlot || IsNotNullOrWhiteSpace(comboBox1.Text)) && // Only validate time slot for BASKETBALL COURT
                   (IsValidQuantity()); // Validate quantity if necessary
        }


        private bool IsValidQuantity()
        {
            // Only validate quantity for Tent, Chair, and Table reservations
            string reservationType = resType.SelectedItem.ToString();
            if (reservationType == "Tent" || reservationType == "Chair" || reservationType == "Table")
            {
                // Check if quantity is a valid integer
                return int.TryParse(quantybox.Text, out int quantity) && quantity > 0;
            }
            return true; // Valid if not relevant
        }

        private bool IsTimeSlotAvailable(DateTime reservationDate, string selectedTimeSlot)
        {
            string[] timeRange = selectedTimeSlot.Split('-');
            string startTime = timeRange[0].Trim();
            string endTime = timeRange[1].Trim();

            TimeSpan start = TimeSpan.Parse(DateTime.Parse(startTime).ToString("HH:mm:ss"));
            TimeSpan end = TimeSpan.Parse(DateTime.Parse(endTime).ToString("HH:mm:ss"));

            string connectionString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string query = "SELECT reservation_start_time, reservation_end_time FROM reservations_ WHERE reservation_date = @reserveDate";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@reserveDate", reservationDate);
                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TimeSpan reservedStart = TimeSpan.Parse(reader["reservation_start_time"].ToString());
                                TimeSpan reservedEnd = TimeSpan.Parse(reader["reservation_end_time"].ToString());

                                // Check for overlap
                                if ((start < reservedEnd && end > reservedStart))
                                {
                                    return false;
                                }
                            }
                        }

                        conn.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error retrieving time slots: {ex.Message}");
            }

            return true;
        }

        private void GetDataFromMySQL(string selectedTimeSlot)
        {
            string connectionString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string query = "INSERT INTO reservations_ (Fname, contact_num, reason, user_id, reservation_date, reservation_start_time, reservation_end_time, quantity, reservation_type) " +
                           "VALUES (@Fullname, @Contactnumber, @reason, @userID, @reserveDate, @startTime, @endTime, @quantity, @resType)";

            int userId = LoggedInUser.UserId;  // Get the user ID of the logged-in user

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Adding parameters
                        cmd.Parameters.AddWithValue("@Fullname", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Contactnumber", textBox2.Text);
                        cmd.Parameters.AddWithValue("@reason", textBox3.Text);
                        cmd.Parameters.AddWithValue("@userID", userId);  // Assign the correct user ID
                        cmd.Parameters.AddWithValue("@reserveDate", dateTimePicker1.Value.Date);

                        // Only add time slot if the reservation is for a basketball court
                        if (resType.SelectedItem.ToString() == "BASKETBALL COURT")
                        {
                            string[] timeRange = selectedTimeSlot.Split('-');
                            string startTime = timeRange[0].Trim();
                            string endTime = timeRange[1].Trim();

                            cmd.Parameters.AddWithValue("@startTime", DateTime.Parse(startTime).ToString("HH:mm:ss"));
                            cmd.Parameters.AddWithValue("@endTime", DateTime.Parse(endTime).ToString("HH:mm:ss"));
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@startTime", DBNull.Value);
                            cmd.Parameters.AddWithValue("@endTime", DBNull.Value);
                        }

                        // Get the reservation type from the ComboBox (resType)
                        string reservationType = resType.SelectedItem.ToString();
                        cmd.Parameters.AddWithValue("@resType", reservationType);

                        // If quantity is used (in cases like "Tent"), set it; otherwise set to NULL
                        if (reservationType == "TENT" || reservationType == "CHAIR" || reservationType == "TABLE")
                        {
                            cmd.Parameters.AddWithValue("@quantity", int.Parse(quantybox.Text)); // Parse to int
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@quantity", DBNull.Value);
                        }

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LoadAvailableTimeSlots()
        {
            comboBox1.Items.Clear();

            List<string> allTimeSlots = new List<string>
            {
                "09:00 AM - 11:00 AM",
                "11:00 AM - 01:00 PM",
                "01:00 PM - 03:00 PM",
                "03:00 PM - 05:00 PM",
                "05:00 PM - 07:00 PM",
                "07:00 PM - 09:00 PM",
                "09:00 PM - 11:00 PM"
            };

            DateTime selectedDate = dateTimePicker1.Value.Date;
            List<string> takenTimeSlots = GetTakenTimeSlots(selectedDate);

            if (selectedDate < DateTime.Now.Date)
            {
                foreach (string timeSlot in allTimeSlots)
                {
                    comboBox1.Items.Add(timeSlot);
                }
            }
            else
            {
                foreach (string timeSlot in allTimeSlots)
                {
                    if (!takenTimeSlots.Contains(timeSlot))
                    {
                        comboBox1.Items.Add(timeSlot);
                    }
                }
            }
        }

        private List<string> GetTakenTimeSlots(DateTime selectedDate)
        {
            List<string> timeSlots = new List<string>();

            string connectionString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string query = "SELECT reservation_start_time, reservation_end_time FROM reservations_ WHERE reservation_date = @reserveDate";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@reserveDate", selectedDate);
                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string startTime = reader["reservation_start_time"].ToString();
                                string endTime = reader["reservation_end_time"].ToString();
                                timeSlots.Add($"{startTime} - {endTime}");
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error retrieving time slots: {ex.Message}");
            }

            return timeSlots;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadAvailableTimeSlots();
        }

        private void resType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resType.SelectedItem != null && resType.SelectedItem.ToString() == "BASKETBALL COURT")
            {
                quantybox.Hide();          // Hide the quantity input
                panel6.Hide();             // Hide the quantity panel
                label12.Hide();            // Hide the quantity label

                comboBox1.Show();          // Ensure the combo box is shown
                comboBox1.Enabled = true;  // Enable time slot selection for basketball court
                label10.Show();            // Ensure the label for the combo box (if any) is also shown
            }
            else
            {
                quantybox.Show();          // Show the quantity input
                panel6.Show();             // Show the quantity panel
                label12.Show();            // Show the quantity label

                comboBox1.Hide();          // Hide the combo box
                label10.Hide();            // Hide the label for the combo box (if any)
            }
        }

        private void FormRes_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }
    }
}
