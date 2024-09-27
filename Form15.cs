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
            string query = "INSERT INTO brgy_id (Fname, contact_num, home, height, weight, blood_type, birthday, sex, civil_status, emergency_contact_name, emergency_contact_number, precinct_number) VALUES (@Fullname, @ContactNumber, @home, @height, @weight, @bloodType, @birthday, @sex, @civilStatus, @emergency_name, @emergency_Con, @precinctNumber)";

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
                return null; // or handle as needed
        }


        private void backId_Click(object sender, EventArgs e)
        {
            DocuReq docureq = new DocuReq();
            docureq.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Damn");
            GetDataFromMySQL();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerBirthday_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
