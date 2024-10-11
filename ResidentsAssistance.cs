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

        private void MyProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void DocuReq_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocumentRequest documentRequest = new DocumentRequest();
            documentRequest.Show();
        }

        private void ResComplaints_Click(object sender, EventArgs e)
        {

        }

        private void EmergencyRes_Click(object sender, EventArgs e)
        {

        }

        private void Announcements_Click(object sender, EventArgs e)
        {

        }

        private void Events_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void Basketball_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM reservations WHERE reservation_type = 'BASKETBALL COURT';", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.Columns["fname"].Width = 150; // 
            dataGridView2.Columns["reason"].Width = 50; // 

        }

        private void Tent_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM reservations WHERE reservation_type = 'TENT';", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.Columns["fname"].Width = 150; // 
            dataGridView2.Columns["quantity"].Width = 50; // 
        }

        private void Table_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM reservations WHERE reservation_type = 'TABLE';", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.Columns["fname"].Width = 150; // 
            dataGridView2.Columns["quantity"].Width = 50; // 
        }

        private void Chair_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM reservations WHERE reservation_type = 'CHAIR';", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.Columns["fname"].Width = 150; //
            dataGridView2.Columns["quantity"].Width = 50; //                                            
        }

        private void ResidentsAssistance_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            reg_approval approval = new reg_approval();
            approval.Show();
            this.Hide();
        }

        private void rejectbtn_Click(object sender, EventArgs e)
        {

        }

        private void acceptbtn_Click_1(object sender, EventArgs e)
        {
            // Update the status to "Accepted" when the accept button is clicked
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["user_id"].Value);
                UpdateUserStatus(userId, "Accepted");
            }
        }
        private void UpdateUserStatus(int userId, string newStatus)
        {
            string conn = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            using (MySqlConnection con = new MySqlConnection(conn))
            {
                con.Open();
                string query = "UPDATE users SET stats = @newStatus WHERE user_id = @userId";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@newStatus", newStatus);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rejectbtn_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["user_id"].Value);
                UpdateUserStatus(userId, "Rejected");
            }
        }
    }
}
