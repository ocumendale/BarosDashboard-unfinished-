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
    public partial class FormBas : Form
    {
        private string selectedTimeSlot = string.Empty; // Store the selected time slot

        public FormBas()
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
            reserve res = new reserve();
            res.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                selectedTimeSlot = comboBox1.Text; // Store the currently selected time slot

                if (!IsTimeSlotAvailable(dateTimePicker1.Value.Date, selectedTimeSlot))
                {
                    MessageBox.Show("The selected time slot is already reserved. Please choose another time.", "Time Slot Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GetDataFromMySQL(selectedTimeSlot);
                MessageBox.Show("Your information has been successfully submitted!", "Submission Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload available time slots to ensure the selected slot is removed for others
                LoadAvailableTimeSlots();

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

        private bool ValidateInputs()
        {
            return IsNotNullOrWhiteSpace(textBox1.Text) &&
                   IsNotNullOrWhiteSpace(textBox2.Text) &&
                   IsNotNullOrWhiteSpace(textBox3.Text) &&
                   comboBox1.SelectedItem != null;
        }

        private bool IsTimeSlotAvailable(DateTime reservationDate, string selectedTimeSlot)
        {
            string[] timeRange = selectedTimeSlot.Split('-');
            string startTime = timeRange[0].Trim();
            string endTime = timeRange[1].Trim();

            TimeSpan start = TimeSpan.Parse(DateTime.Parse(startTime).ToString("HH:mm:ss"));
            TimeSpan end = TimeSpan.Parse(DateTime.Parse(endTime).ToString("HH:mm:ss"));

            string connectionString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string query = "SELECT reservation_start_time, reservation_end_time FROM basketball_court WHERE reservation_date = @reserveDate";

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

                                // Debugging: Log the reserved time slots
                                Console.WriteLine($"Reserved Start: {reservedStart}, Reserved End: {reservedEnd}");

                                // Check for overlap
                                if ((start < reservedEnd && end > reservedStart))
                                {
                                    Console.WriteLine($"Overlap detected with reserved slot: {reservedStart} - {reservedEnd}");
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
            string query = "INSERT INTO basketball_court (Fname, contact_num, reason, user_id, reservation_date, reservation_start_time, reservation_end_time) " +
                           "VALUES (@Fullname, @Contactnumber, @reason, @userID, @reserveDate, @startTime, @endTime)";

            int userId = LoggedInUser.UserId;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Fullname", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Contactnumber", textBox2.Text);
                        cmd.Parameters.AddWithValue("@reason", textBox3.Text);
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@reserveDate", dateTimePicker1.Value.Date);

                        string[] timeRange = selectedTimeSlot.Split('-');
                        string startTime = timeRange[0].Trim();
                        string endTime = timeRange[1].Trim();

                        cmd.Parameters.AddWithValue("@startTime", DateTime.Parse(startTime).ToString("HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@endTime", DateTime.Parse(endTime).ToString("HH:mm:ss"));

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

            Console.WriteLine("Taken Time Slots: " + string.Join(", ", takenTimeSlots));

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
                    if (!takenTimeSlots.Contains(timeSlot) && timeSlot != selectedTimeSlot)
                    {
                        comboBox1.Items.Add(timeSlot);
                        Console.WriteLine($"Available time slot: {timeSlot}");
                    }
                    else
                    {
                        Console.WriteLine($"Time slot {timeSlot} is already taken or is selected by the current user.");
                    }
                }
            }

            button1.Enabled = comboBox1.Items.Count > 0;

            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("No available time slots for the selected date.", "Fully Booked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List<string> GetTakenTimeSlots(DateTime reservationDate)
        {
            List<string> takenTimeSlots = new List<string>();

            string connectionString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string query = "SELECT reservation_start_time, reservation_end_time FROM basketball_court WHERE reservation_date = @reserveDate";

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
                                string startTime = DateTime.Parse(reader["reservation_start_time"].ToString()).ToString("hh:mm tt");
                                string endTime = DateTime.Parse(reader["reservation_end_time"].ToString()).ToString("hh:mm tt");
                                string takenSlot = $"{startTime} - {endTime}";

                                Console.WriteLine($"Adding taken slot: {takenSlot}");
                                takenTimeSlots.Add(takenSlot);
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

            return takenTimeSlots;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadAvailableTimeSlots();
        }

        private void FormBas_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            LoadAvailableTimeSlots();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
