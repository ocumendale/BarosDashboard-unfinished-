using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BarosDashboard
{
    public partial class ManageTransaction : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
        int userId = LoggedInUser.UserId;
        string Chair_ = reserve.chair_;


        public ManageTransaction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // SQL Query to select specific columns for basketball court reservations
                string query = @"
            SELECT reservation_id, reservation_type, user_id, Fname, contact_num, reason, reservation_date, 
                   reservation_start_time, reservation_end_time, reservation_status
            FROM reservations_ 
            WHERE user_id = @userId AND reservation_type = 'BASKETBALL COURT';";

                // Create a new MySqlDataAdapter
                MySqlDataAdapter da = new MySqlDataAdapter(query, connectionString);

                // Use a parameter to safely pass the userId
                da.SelectCommand.Parameters.AddWithValue("@userId", userId);

                // Fill the dataset
                DataSet ds = new DataSet();
                da.Fill(ds);

                // Bind the data to the DataGridView
                dataGridView1.DataSource = ds.Tables[0];

                // Optional: Adjust column widths or other settings if needed
                dataGridView1.Columns["Fname"].Width = 150;
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ManageTransaction_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUsForm aboutUsForm = new AboutUsForm();
            aboutUsForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact contact = new Contact();
            contact.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HowItWorks hitw = new HowItWorks();
            hitw.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services services = new Services();
            services.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                LoggedInUser.UserId = 0;
                LoggedInUser.Uname = string.Empty;


                login loginForm = new login();
                loginForm.Show();


                this.Close();
            }
        }

        private void table_Click(object sender, EventArgs e)
        {

            try
            {
                string query = @"
            SELECT reservation_id, reservation_type, user_id, Fname, contact_num, reason, reservation_date, reservation_status
            FROM reservations_ 
            WHERE user_id = @userId AND reservation_type = 'TABLE';";

                // Create a new MySqlDataAdapter
                MySqlDataAdapter da = new MySqlDataAdapter(query, connectionString);

                // Use a parameter to safely pass the userId
                da.SelectCommand.Parameters.AddWithValue("@userId", userId);

                // Fill the dataset
                DataSet ds = new DataSet();
                da.Fill(ds);

                // Bind the data to the DataGridView
                dataGridView1.DataSource = ds.Tables[0];

                // Optional: Adjust column widths or other settings if needed
                dataGridView1.Columns["Fname"].Width = 150;
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Chair_Click(object sender, EventArgs e)
        {
            try
            {
                // SQL Query to select specific columns for basketball court reservations
                string query = @"
            SELECT reservation_id, reservation_type, user_id, Fname, contact_num, reason, reservation_date, reservation_status
            FROM reservations_ 
            WHERE user_id = @userId AND reservation_type = 'CHAIR';";

                // Create a new MySqlDataAdapter
                MySqlDataAdapter da = new MySqlDataAdapter(query, connectionString);

                // Use a parameter to safely pass the userId
                da.SelectCommand.Parameters.AddWithValue("@userId", userId);

                // Fill the dataset
                DataSet ds = new DataSet();
                da.Fill(ds);

                // Bind the data to the DataGridView
                dataGridView1.DataSource = ds.Tables[0];

                // Optional: Adjust column widths or other settings if needed
                dataGridView1.Columns["Fname"].Width = 150;
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tent_Click(object sender, EventArgs e)
        {

            try
            {
                // SQL Query to select specific columns for basketball court reservations
                string query = @"
            SELECT reservation_id, reservation_type, user_id, Fname, contact_num, reason, reservation_date, reservation_status
            FROM reservations_ 
            WHERE user_id = @userId AND reservation_type = 'TENT';";

                // Create a new MySqlDataAdapter
                MySqlDataAdapter da = new MySqlDataAdapter(query, connectionString);

                // Use a parameter to safely pass the userId
                da.SelectCommand.Parameters.AddWithValue("@userId", userId);

                // Fill the dataset
                DataSet ds = new DataSet();
                da.Fill(ds);

                // Bind the data to the DataGridView
                dataGridView1.DataSource = ds.Tables[0];

                // Optional: Adjust column widths or other settings if needed
                dataGridView1.Columns["Fname"].Width = 150;
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // SQL Query to select specific columns
                string query = @"
                    SELECT brgyid_id, typeofDocu, Fname, contact_num, home, reason, yrsofrecidency, request_status 
                    FROM request_ 
                    WHERE user_id = @userId AND typeOfDocu = 'BARANGAY CERTIFICATE';";

                // Create a new MySqlDataAdapter
                MySqlDataAdapter da = new MySqlDataAdapter(query, connectionString);

                // Use a parameter to safely pass the userId
                da.SelectCommand.Parameters.AddWithValue("@userId", userId);

                // Fill the dataset
                DataSet ds = new DataSet();
                da.Fill(ds);

                // Bind the data to the DataGridView
                dataGridView1.DataSource = ds.Tables[0];

                // Optional: Adjust column widths or other settings if needed
                dataGridView1.Columns["Fname"].Width = 150;
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void indigency_Click(object sender, EventArgs e)
        {

            try
            {
                // SQL Query to select specific columns
                string query = @"
                    SELECT brgyid_id, typeofDocu, Fname, contact_num, home, reason, yrsofrecidency, request_status 
                    FROM request_ 
                    WHERE user_id = @userId AND typeOfDocu = 'BARANGAY INDIGENCY';";

                // Create a new MySqlDataAdapter
                MySqlDataAdapter da = new MySqlDataAdapter(query, connectionString);

                // Use a parameter to safely pass the userId
                da.SelectCommand.Parameters.AddWithValue("@userId", userId);

                // Fill the dataset
                DataSet ds = new DataSet();
                da.Fill(ds);

                // Bind the data to the DataGridView
                dataGridView1.DataSource = ds.Tables[0];

                // Optional: Adjust column widths or other settings if needed
                dataGridView1.Columns["Fname"].Width = 150;
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void clearance_Click(object sender, EventArgs e)
        {


            try
            {
                // SQL Query to select specific columns
                string query = @"
                    SELECT brgyid_id, typeofDocu, Fname, contact_num, home, reason, yrsofrecidency, request_status 
                    FROM request_ 
                    WHERE user_id = @userId AND typeOfDocu = 'BARANGAY CLEARANCE';";

                // Create a new MySqlDataAdapter
                MySqlDataAdapter da = new MySqlDataAdapter(query, connectionString);

                // Use a parameter to safely pass the userId
                da.SelectCommand.Parameters.AddWithValue("@userId", userId);

                // Fill the dataset
                DataSet ds = new DataSet();
                da.Fill(ds);

                // Bind the data to the DataGridView
                dataGridView1.DataSource = ds.Tables[0];

                // Optional: Adjust column widths or other settings if needed
                dataGridView1.Columns["Fname"].Width = 150;
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ID_Click(object sender, EventArgs e)
        {


            MySqlDataAdapter da = new MySqlDataAdapter($"SELECT * FROM request_ WHERE user_id = {userId} AND typeOfDocu = 'BARANGAY ID';", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
