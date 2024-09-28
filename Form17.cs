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

namespace BarosDashboard
{
    public partial class FormTable : Form
    {
        public FormTable()
        {
            InitializeComponent();
        }

        private void backTable_Click(object sender, EventArgs e)
        {
            reserve res = new reserve();
            res.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormTable_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate inputs before processing
            if (ValidateInputs())
            {
                GetDataFromMySQL();
                MessageBox.Show("Your information has been successfully submitted!", "Submission Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GeneratePDF();
                MessageBox.Show("Your PDF has been successfully Generated!");
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
            return IsNotNullOrWhiteSpace(textBox1.Text) &&   // Full name
                   IsNotNullOrWhiteSpace(textBox2.Text) &&   // Contact number
                   IsNotNullOrWhiteSpace(textBox3.Text) &&   // Reason
                   IsNotNullOrWhiteSpace(textBox4.Text) &&   // Date
                   IsNotNullOrWhiteSpace(textBox5.Text) &&   // Time
                   IsNotNullOrWhiteSpace(textBox6.Text);     // Quantity
        }


        private void GetDataFromMySQL()
        {
            string connectionString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string query = "INSERT INTO table_ (Fname, contact_num, reason, date, time, quantity) VALUES (@Fullname, @Contactnumber, @reason, @date, @time, @quantity)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@Fullname", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Contactnumber", textBox2.Text);
                        cmd.Parameters.AddWithValue("@reason", textBox3.Text);
                        cmd.Parameters.AddWithValue("@date", textBox4.Text);
                        cmd.Parameters.AddWithValue("@time", textBox5.Text);
                        cmd.Parameters.AddWithValue("@quantity", textBox6.Text);

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
        private void GeneratePDF()
        {
            string outputPath = "TableReservationDetails.pdf";
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
            AddTableRow(table, $"FULL NAME", textBox1.Text, labelFont, contentFont);
            AddTableRow(table, " ", " ", labelFont, contentFont);
            AddTableRow(table, $"CONTACT NUMBER", textBox2.Text, labelFont, contentFont);
            AddTableRow(table, " ", " ", labelFont, contentFont);
            AddTableRow(table, $"REASON OF REQUEST", textBox3.Text, labelFont, contentFont);
            AddTableRow(table, " ", " ", labelFont, contentFont);
            AddTableRow(table, $"DATE OF TRANSACTION", currentDate.ToString("yyyy-MM-dd"), labelFont, contentFont);
            AddTableRow(table, " ", " ", labelFont, contentFont);
            AddTableRow(table, $"TIME OF TRANSACTION", currentDate.ToString("hh:mm tt"), labelFont, contentFont);
            AddTableRow(table, " ", " ", labelFont, contentFont);
            AddTableRow(table, $"LOCATION", "475 Tilapia St. CC", labelFont, contentFont);
            AddTableRow(table, " ", " ", labelFont, contentFont);
            AddTableRow(table, $"QUANTITY", textBox5.Text, labelFont, contentFont);  // Added quantity field
            AddTableRow(table, " ", " ", labelFont, contentFont);
            AddTableRow(table, $"DATE OF RESERVATION", textBox4.Text, labelFont, contentFont);
            AddTableRow(table, " ", " ", labelFont, contentFont);
            AddTableRow(table, $"TIME OF RESERVATION", textBox6.Text, labelFont, contentFont);
            AddTableRow(table, " ", " ", labelFont, contentFont);
            AddTableRow(table, $"SIZE", "Good for 10", labelFont, contentFont);  // Added size field
            AddTableRow(table, " ", " ", labelFont, contentFont);
            AddTableRow(table, $"TRANSACTION STATUS", "Pending", labelFont, contentFont);
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
        }
        // Helper method for adding rows to the table
        private static void AddTableRow(PdfPTable table, string label, string content, Font labelFont, Font contentFont)
        {
            PdfPCell labelCell = new PdfPCell(new Phrase(label, labelFont));
            labelCell.Border = Rectangle.NO_BORDER;
            table.AddCell(labelCell);

            PdfPCell contentCell = new PdfPCell(new Phrase(content, contentFont));
            contentCell.Border = Rectangle.NO_BORDER;
            table.AddCell(contentCell);
        }
    }
}
