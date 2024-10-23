using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using QRCoder;

namespace BarosDashboard
{
    public partial class reg_approval : Form
    {
        private string selectedUsername;
        private bool isGeneratingQR = false; // Flag to prevent multiple QR generations

        public reg_approval()
        {
            InitializeComponent();
            LoadUsers();

            btnSaveQR.Hide();
            // Hook the MouseClickChanged_ to the MouseClick event of the DataGridView
            dataGridView1.MouseClick += MouseClickChanged_;
        }

        private void reg_approval_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void LoadUsers()
        {
            string conn = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            using (MySqlConnection con = new MySqlConnection(conn))
            {
                con.Open();
                string query = "SELECT user_id, fullName, password, address, stats FROM users";
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt; // Bind the DataGridView to the DataTable
                    dataGridView1.Columns["address"].Width = 450; // Set width of address column
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocumentRequest admin = new DocumentRequest();
            admin.Show();
            this.Hide();
        }

        private void btnSaveQR_Click(object sender, EventArgs e)
        {
            if (pictureBoxQRCode.Image != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                    saveFileDialog.Title = "Save QR Code Image";
                    saveFileDialog.FileName = $"{selectedUsername}_QRCode"; // Automatically name it based on username

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pictureBoxQRCode.Image.Save(saveFileDialog.FileName);
                        MessageBox.Show("QR Code saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No QR Code image to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            btnSaveQR.Show(); // Show the "Save" button when QR code is generated
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Reject the selected user
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["user_id"].Value);
                UpdateUserStatus(userId, "Rejected");
            }
        }

        private void acceptbtn_Click(object sender, EventArgs e)
        {
            // Accept the selected user
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["user_id"].Value);
                UpdateUserStatus(userId, "Accepted");
            }
        }

        private void SaveQRCodeToDatabase(string userID, string qrData)
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=LOCALHOST; DATABASE=baros; UID=root; PASSWORD=Daiki002039!;"))
            {
                connection.Open();
                string query = "UPDATE users SET QRCode = @qrData WHERE user_id = @userID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@qrData", qrData);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.ExecuteNonQuery();
            }
        }

        // This method generates the QR code and handles row selection
        private void MouseClickChanged_(object sender, EventArgs e)
        {
            if (isGeneratingQR) return; // Prevent multiple QR generation
            isGeneratingQR = true;      // Set flag to indicate generation is in progress

            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get selected user's data
                    string selectedUserID = dataGridView1.SelectedRows[0].Cells["user_id"].Value.ToString();
                    selectedUsername = dataGridView1.SelectedRows[0].Cells["fullName"].Value.ToString(); // Store the selected username

                    // Get the current status of the selected user
                    string userStatus = dataGridView1.SelectedRows[0].Cells["stats"].Value.ToString();

                    // Check if the status is "Rejected" or "Pending"
                    if (userStatus.Equals("Rejected", StringComparison.OrdinalIgnoreCase) ||
                        userStatus.Equals("Pending", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("QR Code cannot be generated for users with 'Rejected' or 'Pending' status.",
                                        "Invalid Action",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return; // Exit the method if status is not eligible for QR generation
                    }

                    // Generate QR code based on user's data
                    string qrData = selectedUserID; // Use UserID for uniqueness
                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new QRCode(qrCodeData);
                    Bitmap qrCodeImage = qrCode.GetGraphic(20);

                    // Resize the QR code image to fit the PictureBox
                    Bitmap resizedImage = new Bitmap(qrCodeImage, new Size(856, 770)); // Set the size as per your requirements

                    // Display QR code in PictureBox
                    pictureBoxQRCode.Image = resizedImage;

                    // Save QR code data to the database
                    SaveQRCodeToDatabase(selectedUserID, qrData);

                    btnSaveQR.Show(); // Show the Save button
                }
                else
                {
                    MessageBox.Show("Please select a user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                isGeneratingQR = false; // Reset flag when done
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
            // Reload the user data to reflect the updated status
            LoadUsers();
        }

        private void pictureBoxQRCode_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
