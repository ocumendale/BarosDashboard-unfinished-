﻿using System;
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
        // Method to load reservations by reservation type with specific columns
        private void LoadReservations(string reservationType)
        {
            string query = string.Empty;

            // Define the query based on the reservation type
            if (reservationType == "BASKETBALL COURT")
            {
                query = "SELECT reservation_id, Fname, contact_num, reason, user_id, reservation_date, reservation_start_time, reservation_end_time, reservation_type, reservation_status " +
                        "FROM reservations_ " +
                        "WHERE reservation_type = @reservationType";
            }
            else if (reservationType == "TENT" || reservationType == "TABLE" || reservationType == "CHAIR")
            {
                query = "SELECT reservation_id, Fname, contact_num, reason, user_id, reservation_date, quantity, reservation_type, reservation_status " +
                        "FROM reservations_ " +
                        "WHERE reservation_type = @reservationType";
            }

            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@reservationType", reservationType);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            // Adjust column widths
            dataGridView2.Columns["Fname"].Width = 150;
        }

        // Button click event for Basketball
        private void Basketball_Click(object sender, EventArgs e)
        {
            // Load reservations for "BASKETBALL COURT"
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
        private bool UserHasAcceptedReservation(int userId)
        {
            string query = "SELECT COUNT(*) FROM reservations_ WHERE user_id = @userId AND reservation_status = 'Accepted'";
            using (MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;"))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0; // Returns true if there are accepted reservations
                }
            }
        }

        // Accept the selected reservation
        private void acceptbtn_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Get the selected reservation data
                int reservationId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["reservation_id"].Value);

                // Accept the selected reservation based on reservation_id
                UpdateReservationStatus(reservationId, "Accepted");
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
                int reservationId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["reservation_id"].Value);

                // Reject the selected reservation based on reservation_id
                UpdateReservationStatus(reservationId, "Rejected");
            }
            else
            {
                MessageBox.Show("Please select a reservation to reject.");
            }
        }
        private bool UserHasPendingReservation(int userId)
        {
            string query = "SELECT COUNT(*) FROM reservations_ WHERE user_id = @userId AND reservation_status = 'Accepted'";
            using (MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;"))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0; // Returns true if there are accepted reservations
                }
            }
        }

        // Update the reservation status in the database for the specific selected reservation type
        private void UpdateReservationStatus(int reservationId, string newStatus)
        {
            try
            {
                string query = "UPDATE reservations_ SET reservation_status = @newStatus WHERE reservation_id = @reservationId";
                using (MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;"))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@newStatus", newStatus);
                        cmd.Parameters.AddWithValue("@reservationId", reservationId);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Reload reservations after status update
                LoadReservations(dataGridView2.SelectedRows[0].Cells["reservation_type"].Value.ToString());
                MessageBox.Show($"Reservation {newStatus.ToLower()} successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating reservation: " + ex.Message);
            }
        }

        private void GenerateTablePDF(int userId, string reservationType)
        {

            string connString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string FULLNAME;
            string CONTACTNUMBER;
            string REASON;
            string QUANT;
            string DATERESERVE;
            string STARTTIMERESERVE;
            string ENDTIMERESERVE;
            string STATUS = "Accepted";


            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                    string query = $"SELECT * FROM reservations_ WHERE reservation_type = '{reservationType}' AND reservation_status = '{STATUS}';";
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
        private void GenerateChairPDF(int userId, string reservationType)
        {

            string connString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string FULLNAME;
            string CONTACTNUMBER;
            string REASON;
            string QUANT;
            string DATERESERVE;
            string STARTTIMERESERVE;
            string ENDTIMERESERVE;
            string STATUS = "Accepted";


            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                    string query = $"SELECT * FROM reservations_ WHERE reservation_type = '{reservationType}' AND reservation_status = '{STATUS}';";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        FULLNAME = dataGridView2.SelectedRows[0].Cells["Fname"].Value.ToString();
                        CONTACTNUMBER = dataGridView2.SelectedRows[0].Cells["contact_num"].Value.ToString();
                        REASON = dataGridView2.SelectedRows[0].Cells["reason"].Value.ToString();
                        QUANT = dataGridView2.SelectedRows[0].Cells["quantity"].Value.ToString();
                        DATERESERVE = dataGridView2.SelectedRows[0].Cells["reservation_date"].Value.ToString();
                        STARTTIMERESERVE = dataGridView2.SelectedRows[0].Cells["reservation_start_time"].Value.ToString();
                        ENDTIMERESERVE = dataGridView2.SelectedRows[0].Cells["reservation_end_time"].Value.ToString();



                        string outputPath = $"ChairReservationDetails{FULLNAME}.pdf";
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
                        Paragraph title = new Paragraph("CHAIR RESERVATION DETAILS", titleFont);
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
        private void GenerateTentPDF(int userId, string reservationType)
        {

            string connString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string FULLNAME;
            string CONTACTNUMBER;
            string REASON;
            string QUANT;
            string DATERESERVE;
            string STARTTIMERESERVE;
            string ENDTIMERESERVE;
            string STATUS = "Accepted";


            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                    string query = $"SELECT * FROM reservations_ WHERE reservation_type = '{reservationType}' AND reservation_status = '{STATUS}';";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        FULLNAME = dataGridView2.SelectedRows[0].Cells["Fname"].Value.ToString();
                        CONTACTNUMBER = dataGridView2.SelectedRows[0].Cells["contact_num"].Value.ToString();
                        REASON = dataGridView2.SelectedRows[0].Cells["reason"].Value.ToString();
                        QUANT = dataGridView2.SelectedRows[0].Cells["quantity"].Value.ToString();
                        DATERESERVE = dataGridView2.SelectedRows[0].Cells["reservation_date"].Value.ToString();
                        STARTTIMERESERVE = dataGridView2.SelectedRows[0].Cells["reservation_start_time"].Value.ToString();
                        ENDTIMERESERVE = dataGridView2.SelectedRows[0].Cells["reservation_end_time"].Value.ToString();



                        string outputPath = $"TentReservationDetails{FULLNAME}.pdf";
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
                        Paragraph title = new Paragraph("TENT RESERVATION DETAILS", titleFont);
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
        private void GenerateBasketballPDF(int userId, string reservationType)
        {

            string connString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string FULLNAME;
            string CONTACTNUMBER;
            string REASON;
            string QUANT;
            string DATERESERVE;
            string STARTTIMERESERVE;
            string ENDTIMERESERVE;
            string STATUS = "Accepted";


            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                    string query = $"SELECT * FROM reservations_ WHERE reservation_type = '{reservationType}' AND reservation_status = '{STATUS}';";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        FULLNAME = dataGridView2.SelectedRows[0].Cells["Fname"].Value.ToString();
                        CONTACTNUMBER = dataGridView2.SelectedRows[0].Cells["contact_num"].Value.ToString();
                        REASON = dataGridView2.SelectedRows[0].Cells["reason"].Value.ToString();
                        DATERESERVE = dataGridView2.SelectedRows[0].Cells["reservation_date"].Value.ToString();
                        STARTTIMERESERVE = dataGridView2.SelectedRows[0].Cells["reservation_start_time"].Value.ToString();
                        ENDTIMERESERVE = dataGridView2.SelectedRows[0].Cells["reservation_end_time"].Value.ToString();



                        string outputPath = $"BasketballReservationDetails{FULLNAME}.pdf";
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
                        Paragraph title = new Paragraph("Basketball RESERVATION DETAILS", titleFont);
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
                        AddTableRow(table, $"DATE OF RESERVATION", DATERESERVE, labelFont, contentFont);
                        AddTableRow(table, " ", " ", labelFont, contentFont);
                        AddTableRow(table, $"START TIME OF RESERVATION", STARTTIMERESERVE, labelFont, contentFont);
                        AddTableRow(table, " ", " ", labelFont, contentFont);
                        AddTableRow(table, $"END TIME OF RESERVATION", ENDTIMERESERVE, labelFont, contentFont);
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

            if (dataGridView2.SelectedRows.Count == 1)
            {

                int userId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["user_id"].Value);
                string reservationType = dataGridView2.SelectedRows[0].Cells["reservation_type"].Value.ToString();
                string RStats = dataGridView2.SelectedRows[0].Cells["reservation_status"].Value.ToString();

                if (reservationType == "TABLE" && RStats == "Accepted")
                {
                    GenerateTablePDF(userId, reservationType);
                }
                else if (reservationType == "CHAIR" && RStats == "Accepted")
                {
                    GenerateChairPDF(userId, reservationType);
                }
                else if (reservationType == "TENT" && RStats == "Accepted")
                {
                    GenerateTentPDF(userId, reservationType);
                }
                else if (reservationType == "BASKETBALL COURT" && RStats == "Accepted") //BASKETBALL COURT ba yung nasa database? kung hindi palitan mo
                {
                    GenerateBasketballPDF(userId, reservationType);
                }
                else
                {
                    MessageBox.Show("This Reservation is not yet Accepted!");
                }
            }
            else
            {
                MessageBox.Show("Please select an entire row to generate a PDF.");
            }
        }

        private void MyProfile_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void DocuReq_Click(object sender, EventArgs e)
        {
            DocumentRequest res = new DocumentRequest();
            res.Show();
            this.Hide();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            reg_approval reg = new reg_approval();
            reg.Show();
            this.Hide();
        }

        private void Events_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                login loginForm = new login();
                loginForm.Show();
                this.Close();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


