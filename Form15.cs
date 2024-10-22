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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

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

        private void GeneratePDF()
        {
            // Define the dimensions of the portrait ID card
            Rectangle idCardSizePortrait = new Rectangle(54f * 2.835f, 85.6f * 2.835f);

            Document doc = new Document(idCardSizePortrait);
            string pdfPath = "PortraitIDCard.pdf";

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
                doc.Open();

                // Add the background image and scale it to fit the ID card size
                try
                {
                    iTextSharp.text.Image background = iTextSharp.text.Image.GetInstance("C:\\Barangay Picture\\Caloocan_City.png");
                    background.ScaleToFit(idCardSizePortrait.Width, idCardSizePortrait.Height);
                    background.SetAbsolutePosition(0f, 50f);
                    doc.Add(background);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading background image: " + ex.Message);
                    return; // exit if image loading fails
                }

                PdfContentByte canvas = writer.DirectContent;

                // Add the image with opacity
                PdfGState gState = new PdfGState { FillOpacity = 0.1f, StrokeOpacity = 0.1f };
                canvas.SaveState();
                canvas.SetGState(gState);
                canvas.RestoreState();

                // Define fonts
                iTextSharp.text.Font fontHeader = FontFactory.GetFont(FontFactory.TIMES_BOLD, 8, BaseColor.BLACK);
                iTextSharp.text.Font fontRegular = FontFactory.GetFont(FontFactory.TIMES, 6, BaseColor.BLACK);
                iTextSharp.text.Font fontBold = FontFactory.GetFont(FontFactory.TIMES_BOLD, 5, BaseColor.BLACK);

                // Add header text
                ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("Republic of the Philippines", fontHeader), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 30f, 0);
                ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("City of Caloocan", fontHeader), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 45f, 0);
                ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("OFFICE OF THE PUNONG BARANGAY", fontBold), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 60f, 0);
                ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("Barangay 22, Zone 2, District II", fontRegular), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 75f, 0);

                // Add full name and details text
                ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase(textBox1.Text, fontBold), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 150f, 0);
                ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("FULL NAME", fontRegular), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 165f, 0);

                // Move the line under the name higher
                canvas.MoveTo(10f, idCardSizePortrait.Height - 160f); // Raised by 10 points
                canvas.LineTo(idCardSizePortrait.Width - 10f, idCardSizePortrait.Height - 160f);
                canvas.Stroke();

                ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase(textBox4.Text, fontBold), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 195f, 0);
                ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("RESIDENCE ADDRESS", fontRegular), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 205f, 0);

                // Move the line under the address higher
                canvas.MoveTo(10f, idCardSizePortrait.Height - 200f); // Raised by 10 points
                canvas.LineTo(idCardSizePortrait.Width - 10f, idCardSizePortrait.Height - 200f);
                canvas.Stroke();

                // Add signature label
                ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("SIGNATURE", fontRegular), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 240f, 0);

                // Add profile picture
                try
                {
                    iTextSharp.text.Image profilePic = iTextSharp.text.Image.GetInstance("C:\\Users\\natha\\OneDrive\\Documents\\Pictures\\Screenshots\\unggoy.png");
                    profilePic.ScaleAbsolute(40f, 40f);
                    profilePic.SetAbsolutePosition(idCardSizePortrait.Width - 45f, 120f);
                    PdfContentByte underCanvas = writer.DirectContentUnder;
                    underCanvas.AddImage(profilePic);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading profile picture: " + ex.Message);
                }
            }
            catch (DocumentException de)
            {
                MessageBox.Show("Document Exception: " + de.Message);
            }
            catch (IOException ioe)
            {
                MessageBox.Show("IO Exception: " + ioe.Message);
            }
            finally
            {
                // Ensure the document is closed properly
                doc.Close();
            }
        }

        private void GetDataFromMySQL()
        {
            string connectionString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string query = "INSERT INTO request_ (Fname, contact_num, home, height, weight, blood_type, birthday, sex, civil_status, emergency_contact_name, emergency_contact_number, precinct_number, user_id, yrsofrecidency, typeOfDocu, reason) " +
                "VALUES (@Fullname, @ContactNumber, @home, @height, @weight, @bloodType, @birthday, @sex, @civilStatus, @emergency_name, @emergency_Con, @precinctNumber, @userID, @yrsofrecidency, @typeOfDocu, @reason)";

            int userId = LoggedInUser.UserId;
            string selectedDocumentType = comboBox1.SelectedItem.ToString();
            double height, weight;

            // Only parse height and weight if they are required
            bool heightAndWeightRequired = !(
                selectedDocumentType.Equals("barangay certificate", StringComparison.OrdinalIgnoreCase) ||
                selectedDocumentType.Equals("barangay clearance", StringComparison.OrdinalIgnoreCase) ||
                selectedDocumentType.Equals("barangay indigency", StringComparison.OrdinalIgnoreCase)
            );

            if (heightAndWeightRequired)
            {
                if (!double.TryParse(txt_Height.Text, out height) || !double.TryParse(txt_Weight.Text, out weight))
                {
                    MessageBox.Show("Please enter valid numbers for height and weight.");
                    return; // exit if parsing fails
                }
            }
            else
            {
                height = weight = 0; // default values, will not be used if not required
            }

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
                        cmd.Parameters.AddWithValue("@reason", textBox3.Text);

                        // Conditionally add height and weight
                        if (heightAndWeightRequired)
                        {
                            cmd.Parameters.AddWithValue("@height", height);
                            cmd.Parameters.AddWithValue("@weight", weight);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@height", DBNull.Value);
                            cmd.Parameters.AddWithValue("@weight", DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue("@bloodType", bloodTypeBox.Text);
                        cmd.Parameters.AddWithValue("@birthday", dateTimePickerBirthday.Value.Date);
                        cmd.Parameters.AddWithValue("@sex", GetSelectedSex());
                        cmd.Parameters.AddWithValue("@civilStatus", GetSelectedCivilStatus());
                        cmd.Parameters.AddWithValue("@emergency_name", Fname_Em.Text);
                        cmd.Parameters.AddWithValue("@emergency_Con", contact_Em.Text);
                        cmd.Parameters.AddWithValue("@precinctNumber", textBoxPrecinctNumber.Text);
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@yrsofrecidency", textBox5.Text);
                        cmd.Parameters.AddWithValue("@typeOfDocu", selectedDocumentType);

                        // Open the connection
                        conn.Open();

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data successfully inserted!");
                        }
                        else
                        {
                            MessageBox.Show("No rows affected.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Input format error: " + ex.Message);
            }
        }


        private string GetSelectedSex()
        {
            if (radioButtonMale.Checked)
                return "Male";
            else if (radioButtonFemale.Checked)
                return "Female";
            else
                return null; // Handle as needed
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
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                GeneratePDF();
                GetDataFromMySQL();
                MessageBox.Show("Your information has been successfully submitted!", "Submission Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form20 form20 = new Form20();
                form20.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please complete all required fields before submitting.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateInputs()
        {
            // Check that textboxes are not empty
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                return false;
            }



            return true;
        }

        private void txt_Height_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "BARANGAY CLEARANCE" || comboBox1.Text == "BARANGAY INDIGENCY" || comboBox1.Text == "BARANGAY CERTIFICATE")
            {
                labelHeight.Hide();
                txt_Height.Hide();
                panel5.Hide();

                labelPrecinctNumber.Hide();
                textBoxPrecinctNumber.Hide();
                panel8.Hide();

                labelWeight.Hide();
                txt_Weight.Hide();
                panel6.Hide();

                labelBloodType.Hide();
                bloodTypeBox.Hide();
                panel7.Hide();

                label15.Hide();
                label14.Hide();
                Fname_Em.Hide();
                panel10.Hide();

                label12.Hide();
                label13.Hide();
                label11.Hide();
                label10.Hide();
                contact_Em.Hide();
                panel11.Hide();

                labelBirthday.Hide();
                dateTimePickerBirthday.Hide();
                panel9.Hide();

                groupBox2.Hide();
                radioButtonMale.Hide();
                radioButtonFemale.Hide();
                radioButtonOthers.Hide();

                groupBox1.Hide();
                radioButtonSingle.Hide();
                radioButtonDivorced.Hide();
                Married.Hide();
                radioButtonWidowed.Hide();
            }
            else 
            {
                labelHeight.Show();
                txt_Height.Show();
                panel5.Show();

                labelPrecinctNumber.Show();
                textBoxPrecinctNumber.Show();
                panel8.Show();

                labelWeight.Show();
                txt_Weight.Show();
                panel6.Show();

                labelBloodType.Show();
                bloodTypeBox.Show();
                panel7.Show();

                label15.Show();
                label14.Show();
                Fname_Em.Show();
                panel10.Show();

                label12.Show();
                label13.Show();
                label11.Show();
                label10.Show();
                contact_Em.Show();
                panel11.Show();

                labelBirthday.Show();
                dateTimePickerBirthday.Show();
                panel9.Show();

                groupBox2.Show();
                radioButtonMale.Show();
                radioButtonFemale.Show();
                radioButtonOthers.Show();

                groupBox1.Show();
                radioButtonSingle.Show();
                radioButtonDivorced.Show();
                Married.Show();
                radioButtonWidowed.Show();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
