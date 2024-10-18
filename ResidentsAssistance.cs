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

namespace BarosDashboard
{
    public partial class ResidentsAssistance : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;");

        public ResidentsAssistance()
        {
            InitializeComponent();
        }

        private void ResidentsAssistance_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        // Method to load reservations by reservation type
        private void LoadReservations(string reservationType)
        {
            string query = $"SELECT * FROM basketball_court WHERE reservation_type = '{reservationType}';";
            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            dataGridView2.Columns["fname"].Width = 150;
            if (dataGridView2.Columns.Contains("quantity"))
            {
                dataGridView2.Columns["quantity"].Width = 50;
            }
        }

        private void Basketball_Click(object sender, EventArgs e)
        {
            LoadReservations("BASKETBALL COURT");
        }

        private void Tent_Click(object sender, EventArgs e)
        {
            LoadReservations("TENT");
        }

        private void Table_Click(object sender, EventArgs e)
        {
            LoadReservations("TABLE");
        }

        private void Chair_Click(object sender, EventArgs e)
        {
            LoadReservations("CHAIR");
        }

        // Accept the selected reservation
        private void acceptbtn_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Get the selected reservation data
                int userId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["user_id"].Value);
                string reservationType = dataGridView2.SelectedRows[0].Cells["reservation_type"].Value.ToString();

                // Accept only the selected reservation type for the user
                UpdateReservationStatus(userId, reservationType, "Accepted");
            }
            else
            {
                MessageBox.Show("Please select a reservation to accept.");
            }
        }

        // Reject the selected reservation
        private void rejectbtn_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Get the selected reservation data
                int userId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["user_id"].Value);
                string reservationType = dataGridView2.SelectedRows[0].Cells["reservation_type"].Value.ToString();

                // Reject only the selected reservation type for the user
                UpdateReservationStatus(userId, reservationType, "Rejected");
            }
            else
            {
                MessageBox.Show("Please select a reservation to reject.");
            }
        }

        // Update the reservation status in the database for the specific selected reservation type
        private void UpdateReservationStatus(int userId, string reservationType, string newStatus)
        {
            try
            {
                string query = "UPDATE basketball_court SET reservation_status = @newStatus WHERE user_id = @userId AND reservation_type = @reservationType";
                using (MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;"))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@newStatus", newStatus);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@reservationType", reservationType);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Reload reservations after status update, but only for the current reservation type
                LoadReservations(reservationType);
                MessageBox.Show($"Reservation {newStatus.ToLower()} successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating reservation: " + ex.Message);
            }
        }
    }
}


