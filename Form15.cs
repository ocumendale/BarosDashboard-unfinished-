using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Rectangle = iTextSharp.text.Rectangle;
using Org.BouncyCastle.Utilities.Encoders;

namespace BarosDashboard
{
    public partial class FormId : Form
    {
        public FormId()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }



        private void GetDataFromMySQL()
        {
            string connectionString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string query = "INSERT INTO brgy_id (Fname, contact_num, home, height, weight, blood_type, birthday, sex, civil_status, emergency_contact_name, emergency_contact_number, precinct_number, user_id) VALUES (@Fullname, @ContactNumber, @home, @height, @weight, @bloodType, @birthday, @sex, @civilStatus, @emergency_name, @emergency_Con, @precinctNumber, @userID)";

            int userId = LoggedInUser.UserId;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@Fullname", textBox1.Text);
                        cmd.Parameters.AddWithValue("@ContactNumber", textBox2.Text);
                        cmd.Parameters.AddWithValue("@home", textBox4.Text);
                        cmd.Parameters.AddWithValue("@height", Convert.ToDecimal(txt_Height.Text));
                        cmd.Parameters.AddWithValue("@weight", Convert.ToDecimal(txt_Weight.Text));
                        cmd.Parameters.AddWithValue("@bloodType", bloodTypeBox.Text);
                        cmd.Parameters.AddWithValue("@birthday", dateTimePickerBirthday.Value.Date);
                        cmd.Parameters.AddWithValue("@sex", GetSelectedSex());
                        cmd.Parameters.AddWithValue("@civilStatus", GetSelectedCivilStatus());
                        cmd.Parameters.AddWithValue("@emergency_name", Fname_Em.Text);
                        cmd.Parameters.AddWithValue("@emergency_Con", contact_Em.Text);
                        cmd.Parameters.AddWithValue("@precinctNumber", textBoxPrecinctNumber.Text);
                        cmd.Parameters.AddWithValue("@UserID", userId);



                        // Open the connection
                        conn.Open();

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Close the connection
                        conn.Close();

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private string GetSelectedSex()
        {
            if (radioButtonMale.Checked)
                return "Male";
            else if (radioButtonFemale.Checked)
                return "Female";
            else
                return null; // or handle as needed
        }

        private string GetSelectedCivilStatus()
        {
            if (radioButtonSingle.Checked)
                return "Single";
            else if (Married.Checked)
                return "Married";
            else if (radioButtonDivorced.Checked)
                return "Divorced";
            else if (radioButtonWidowed.Checked)
                return "Widowed";
            else
                return null;
        }


        private void backId_Click(object sender, EventArgs e)
        {
            DocuReq docureq = new DocuReq();
            docureq.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                GetDataFromMySQL();
                MessageBox.Show("Your information has been successfully submitted!", "Submission Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form20 form20 = new Form20();
                form20.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Please complete all required fields before submitting.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private bool ValidateInputs()
        {
            // Example validation: ensure the critical textboxes are not empty
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                return false;
            }
            // Add more validation checks as needed
            return true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void labelPrecinctNumber_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
