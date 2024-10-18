using System;
using System.Collections;
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
using System.IO;
using Rectangle = iTextSharp.text.Rectangle;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static QRCoder.PayloadGenerator.SwissQrCode;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic.ApplicationServices;

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
            string query = $"SELECT * FROM reservations_ WHERE reservation_type = '{reservationType}';";
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
                string query = "UPDATE reservations_ SET reservation_status = @newStatus WHERE user_id = @userId AND reservation_type = @reservationType";
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

        private void GenerateTablePDF(int userId, string reservationType)
        {
            if (dataGridView2.SelectedRows.Count > 0 && reservationType == "TABLE")
            {
                string connString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
                string FULLNAME;
                string CONTACTNUMBER;
                string REASON;
                string QUANT;
                string DATERESERVE;
                string STARTTIMERESERVE;
                string ENDTIMERESERVE;
                string STATS = "Accepted";


                try
                {
                    using (MySqlConnection con = new MySqlConnection(connString))
                    {
                        con.Open();
                        string query = $"SELECT * FROM reservations_ WHERE reservation_type = '{reservationType}' AND reservation_status = '{STATS}';";
                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            FULLNAME = dataGridView2.SelectedRows[0].Cells["Fname"].Value.ToString();
                            CONTACTNUMBER = dataGridView2.SelectedRows[0].Cells["contact_num"].Value.ToString();
                            REASON = dataGridView2.SelectedRows[0].Cells["reason"].Value.ToString();
                            QUANT = dataGridView2.SelectedRows[0].Cells["quantity"].Value.ToString();
                            DATERESERVE = dataGridView2.SelectedRows[0].Cells["reservation_date"].Value.ToString();
                            STARTTIMERESERVE = dataGridView2.SelectedRows[0].Cells["reservation_start_time"].Value.ToString();
                            ENDTIMERESERVE = dataGridView2.SelectedRows[0].Cells["reservation_end_time"].Value.ToString();



                            string outputPath = $"TableReservationDetails{FULLNAME}.pdf";
                            DateTime currentDate = DateTime.Now;

                            // Create a new document
                            Document document = new Document(PageSize.A4);
                            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));

                            // Open the document to enable writing
                            document.Open();

                            //background image with opacity
                            iTextSharp.text.Image background = iTextSharp.text.Image.GetInstance("C:\\Barangay Picture\\Caloocan_City.png");

                            float imageWidth = 500f;
                            float imageHeight = 300f;
                            background.ScaleAbsolute(imageWidth, imageHeight);

                            // Get the page size
                            Rectangle pageSize = document.PageSize;
                            float pageWidth = pageSize.Width;
                            float pageHeight = pageSize.Height;

                            // Calculate the center position
                            float xPosition = (pageWidth - imageWidth) / 2;
                            float yPosition = (pageHeight - imageHeight) / 2;

                            // Set the absolute position to center the image
                            background.SetAbsolutePosition(xPosition, yPosition);

                            // Create a PdfGState to control the opacity
                            PdfGState gState = new PdfGState();
                            gState.FillOpacity = 0.1f; // Set opacity (0.0f to 1.0f, where 1.0 is fully opaque)

                            // Add the background image with opacity
                            PdfContentByte canvas = writer.DirectContent;
                            canvas.SaveState();
                            canvas.SetGState(gState);
                            canvas.AddImage(background);
                            canvas.RestoreState();

                            // Set up fonts and colors
                            Font titleFont = FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                            Font contentFont = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                            Font labelFont = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);


                            // Title Section
                            Paragraph title = new Paragraph("TABLE RESERVATION DETAILS", titleFont);
                            title.Alignment = Element.ALIGN_CENTER;
                            document.Add(title);

                            // Adding Spacing
                            document.Add(new Paragraph("\n"));
                            document.Add(new Paragraph("\n"));
                            document.Add(new Paragraph("\n"));
                            // Table for content
                            PdfPTable table = new PdfPTable(2);
                            table.WidthPercentage = 90;

                            AddTableRow(table, " ", " ", labelFont, contentFont);
                            // Add cells to the table with borders
                            AddTableRow(table, $"FULL NAME", FULLNAME, labelFont, contentFont);
                            AddTableRow(table, " ", " ", labelFont, contentFont);
                            AddTableRow(table, $"CONTACT NUMBER", CONTACTNUMBER, labelFont, contentFont);
                            AddTableRow(table, " ", " ", labelFont, contentFont);
                            AddTableRow(table, $"REASON OF REQUEST", REASON, labelFont, contentFont);
                            AddTableRow(table, " ", " ", labelFont, contentFont);
                            AddTableRow(table, $"DATE OF TRANSACTION", currentDate.ToString("yyyy-MM-dd"), labelFont, contentFont);
                            AddTableRow(table, " ", " ", labelFont, contentFont);
                            AddTableRow(table, $"TIME OF TRANSACTION", currentDate.ToString("hh:mm tt"), labelFont, contentFont);
                            AddTableRow(table, " ", " ", labelFont, contentFont);
                            AddTableRow(table, $"LOCATION", "475 Tilapia St. CC", labelFont, contentFont);
                            AddTableRow(table, " ", " ", labelFont, contentFont);
                            AddTableRow(table, $"QUANTITY", QUANT, labelFont, contentFont);  // Added quantity field
                            AddTableRow(table, " ", " ", labelFont, contentFont);
                            AddTableRow(table, $"DATE OF RESERVATION", DATERESERVE, labelFont, contentFont);
                            AddTableRow(table, " ", " ", labelFont, contentFont);
                            AddTableRow(table, $"START TIME OF RESERVATION", STARTTIMERESERVE, labelFont, contentFont);
                            AddTableRow(table, " ", " ", labelFont, contentFont);
                            AddTableRow(table, $"END TIME OF RESERVATION", ENDTIMERESERVE, labelFont, contentFont);
                            AddTableRow(table, " ", " ", labelFont, contentFont);
                            AddTableRow(table, $"SIZE", "Good for 10", labelFont, contentFont);  // Added size field
                            AddTableRow(table, " ", " ", labelFont, contentFont);
                            AddTableRow(table, " ", " ", labelFont, contentFont);

                            // Add the table to the document
                            document.Add(table);

                            // Closing instructions
                            document.Add(new Paragraph("\n"));
                            document.Add(new Paragraph("\n"));
                            Paragraph instruction = new Paragraph("Please present this copy to the Brgy. Hall, hours before the reservation", contentFont);
                            instruction.Alignment = Element.ALIGN_CENTER;
                            document.Add(instruction);

                            // Close the document
                            document.Close();

                            MessageBox.Show("PDF GENERATED SUCCESSFULY!");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
        }
        private static void AddTableRow(PdfPTable table, string label, string content, Font labelFont, Font contentFont)
        {
            PdfPCell labelCell = new PdfPCell(new Phrase(label, labelFont));
            labelCell.Border = Rectangle.NO_BORDER;
            table.AddCell(labelCell);

            PdfPCell contentCell = new PdfPCell(new Phrase(content, contentFont));
            contentCell.Border = Rectangle.NO_BORDER;
            table.AddCell(contentCell);
        }

        private void GeneratePDF_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["user_id"].Value);
            string reservationType = dataGridView2.SelectedRows[0].Cells["reservation_type"].Value.ToString();

            GenerateTablePDF(userId, reservationType);
        }
    }
}


