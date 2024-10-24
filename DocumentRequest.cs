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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Rectangle = iTextSharp.text.Rectangle; // Change this line

namespace BarosDashboard
{
    public partial class DocumentRequest : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;");
        public DocumentRequest()
        {
            InitializeComponent();
        }

        private void MyProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void ResAssist_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResidentsAssistance residentsAssistance = new ResidentsAssistance();
            residentsAssistance.Show();
        }

        private void DocumentRequest_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadReservations("BARANGAY CERTIFICATE");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadReservations("BARANGAY INDIGENCY");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadReservations("BARANGAY CLEARANCE");
        }

        private void brgy_id_Click(object sender, EventArgs e)
        {
            LoadReservations("BARANGAY ID");
        }

        private void button4_Click(object sender, EventArgs e) // Accept button
        {
            try
            {
                // Open your database connection
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Get the selected row's ID
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    string selectedBrgyId = dataGridView2.SelectedRows[0].Cells["brgyid_id"].Value.ToString();
                    string currentTypeOfDocu = dataGridView2.SelectedRows[0].Cells["typeofDocu"].Value.ToString();

                    // SQL Query to update the request status to 'Accepted'
                    string query = "UPDATE request_ SET request_status = 'Accepted' WHERE brgyid_id = @brgyid_id";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@brgyid_id", selectedBrgyId);

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    // Refresh the DataGridView with the current document type
                    LoadReservations(currentTypeOfDocu);

                    MessageBox.Show("Request accepted successfully.");
                }
                else
                {
                    MessageBox.Show("Please select a row to accept.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e) // Reject button
        {
            try
            {
                // Open your database connection
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Get the selected row's ID
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    string selectedBrgyId = dataGridView2.SelectedRows[0].Cells["brgyid_id"].Value.ToString();
                    string currentTypeOfDocu = dataGridView2.SelectedRows[0].Cells["typeofDocu"].Value.ToString();

                    // SQL Query to update the request status to 'Rejected'
                    string query = "UPDATE request_ SET request_status = 'Rejected' WHERE brgyid_id = @brgyid_id";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@brgyid_id", selectedBrgyId);

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    // Refresh the DataGridView with the current document type
                    LoadReservations(currentTypeOfDocu);

                    MessageBox.Show("Request rejected successfully.");
                }
                else
                {
                    MessageBox.Show("Please select a row to reject.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void LoadReservations(string typeOfDocu)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query;

                // If the document type is 'BARANGAY ID', retrieve all columns
                if (typeOfDocu == "BARANGAY ID")
                {
                    query = $"SELECT * FROM request_ WHERE typeOfDocu = '{typeOfDocu}';";
                }
                else
                {
                    // For other document types, retrieve specific columns
                    query = $"SELECT typeofDocu, brgyid_id, Fname, contact_num, home, reason, yrsofrecidency, request_status FROM request_ WHERE typeOfDocu = '{typeOfDocu}';";
                }

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];

                dataGridView2.Columns["Fname"].Width = 150;
                if (dataGridView2.Columns.Contains("quantity"))
                {
                    dataGridView2.Columns["quantity"].Width = 50;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


    }
}
