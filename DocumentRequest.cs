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
        iTextSharp.text.Font fontHeader = FontFactory.GetFont(FontFactory.TIMES_BOLD, 8, BaseColor.BLACK);
        iTextSharp.text.Font fontRegular = FontFactory.GetFont(FontFactory.TIMES, 6, BaseColor.BLACK);
        iTextSharp.text.Font fontBold = FontFactory.GetFont(FontFactory.TIMES_BOLD, 5, BaseColor.BLACK);

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
                    query = $"SELECT typeofDocu, brgyid_id, user_id, Fname, contact_num, home, reason, yrsofrecidency, request_status FROM request_ WHERE typeOfDocu = '{typeOfDocu}';";
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
        private static void AddTableRow(PdfPTable table, string label, string content, iTextSharp.text.Font labelFont, iTextSharp.text.Font contentFont)
        {
            PdfPCell labelCell = new PdfPCell(new Phrase(label, labelFont));
            labelCell.Border = Rectangle.NO_BORDER;
            table.AddCell(labelCell);

            PdfPCell contentCell = new PdfPCell(new Phrase(content, contentFont));
            contentCell.Border = Rectangle.NO_BORDER;
            table.AddCell(contentCell);
        }
        private void GenerateBgyClearPDF(int userId, string typeOfDocu)
        {

            string connString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string FULLNAME;
            string CONTACTNUMBER;
            string REASON;
            string STATUS = "Accepted";
            string ADDRESS;


            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                    string query = $"SELECT * FROM request_ WHERE typeOfDocu = '{typeOfDocu}' AND request_status = '{STATUS}';";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        FULLNAME = dataGridView2.SelectedRows[0].Cells["Fname"].Value.ToString();
                        CONTACTNUMBER = dataGridView2.SelectedRows[0].Cells["contact_num"].Value.ToString();
                        REASON = dataGridView2.SelectedRows[0].Cells["reason"].Value.ToString();
                        ADDRESS = dataGridView2.SelectedRows[0].Cells["home"].Value.ToString();



                        DateTime currentDate = DateTime.Now;
                        // Create a PDF document
                        Document doc = new Document();
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream($"{FULLNAME}_CLEARANCE.pdf", FileMode.Create));

                        // Open the document to write content
                        doc.Open();


                        iTextSharp.text.Image background = iTextSharp.text.Image.GetInstance("C:\\Barangay Picture\\Caloocan_City.png");

                        float imageWidth = 500f;
                        float imageHeight = 300f;
                        background.ScaleAbsolute(imageWidth, imageHeight);

                        // Get the page size
                        Rectangle pageSize = doc.PageSize;
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


                        background.ScaleToFit(doc.PageSize.Width, doc.PageSize.Height);
                        background.SetAbsolutePosition(0, 0); // Position it at the bottom-left corner
                                                              // Add the image to the document



                        // Header of the document
                        iTextSharp.text.Font font1bold = FontFactory.GetFont(FontFactory.TIMES_BOLD, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font font1 = FontFactory.GetFont(FontFactory.TIMES, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font font = FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font fontTitle = FontFactory.GetFont(FontFactory.TIMES_BOLD, 18, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font fontRight = FontFactory.GetFont(FontFactory.TIMES_BOLD, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        Paragraph headerClearance = new Paragraph($"Republic City of the Philippines", font1bold);
                        Paragraph headerClearance1 = new Paragraph($"City of Caloocan", font);
                        Paragraph headerClearance2 = new Paragraph($"OFFICE OF THE PUNONG BARANGAY", font1);
                        Paragraph headerClearance3 = new Paragraph($"Barangay 22, Zone 2, District II", font);
                        Paragraph title = new Paragraph($"\n\nBARANGAY CLEARANCE", fontTitle);
                        Paragraph whom = new Paragraph($"\n\nTO WHOM MAY IT CONCERN:", fontTitle);
                        Paragraph bodyIndigency = new Paragraph($"\n\n\t\t\tThis is to Certify that {FULLNAME}., A resident of {ADDRESS} will use this Barangay Clearance.\n" +
                            $"\nPurpose: {REASON}" + $"\n\t\tThis Clearance is issued for whatever legal purpose or purposes this may serve.\n" +
                            $"\nRemarks: NO RECORDS OF ANY OFFENSE AND THAT THE SAID PERSON IS OF GOOD MORAL CHARACTER AND A LAW ABIDING CITIZEN OF THE COMMUNITY.\n" +
                            $"\n\t\tSigned this on the {currentDate.ToString("yyyy-MM-dd")} at BARANGAY 22 ZONE 2 DISTRICT II , CALOOCAN CITY, NATIONAL CAPITAL REGION, PHILIPPINES.\n" +
                            $"\n\t\tThis Clearance is valid only for 1 year from the issuance.\n", font);


                        Paragraph dateRight = new Paragraph($"DATE TODAY", font);

                        Paragraph verify = new Paragraph($"\n\n\n\n\nVERIFIED BY:", font);
                        Paragraph witnessMan = new Paragraph($"ANTHONY S. MULAWIN", fontRight);
                        Paragraph pos = new Paragraph($"Secretary", font);

                        Paragraph dateLeft = new Paragraph($"\t\t\t{currentDate.ToString("yyyy-MM-dd")}", font);
                        Paragraph attest = new Paragraph($"\n\n\t\t\tATTESTED BY:", font);
                        Paragraph punongBarangay = new Paragraph($"\t\t\tPunong Barangay", font);
                        Paragraph chairMan = new Paragraph($"\t\t\tRONALD BAUTISTA", fontRight);

                        headerClearance.Alignment = Element.ALIGN_CENTER;
                        headerClearance1.Alignment = Element.ALIGN_CENTER;
                        headerClearance2.Alignment = Element.ALIGN_CENTER;
                        headerClearance3.Alignment = Element.ALIGN_CENTER;
                        title.Alignment = Element.ALIGN_CENTER;

                        verify.Alignment = Element.ALIGN_RIGHT;
                        chairMan.Alignment = Element.ALIGN_RIGHT;
                        dateRight.Alignment = Element.ALIGN_RIGHT;
                        witnessMan.Alignment = Element.ALIGN_RIGHT;
                        pos.Alignment = Element.ALIGN_RIGHT;

                        dateLeft.Alignment = Element.ALIGN_LEFT;
                        attest.Alignment = Element.ALIGN_LEFT;
                        chairMan.Alignment = Element.ALIGN_LEFT;
                        punongBarangay.Alignment = Element.ALIGN_LEFT;

                        doc.Add(headerClearance);
                        doc.Add(headerClearance1);
                        doc.Add(headerClearance2);
                        doc.Add(headerClearance3);
                        doc.Add(title);
                        doc.Add(whom);
                        doc.Add(bodyIndigency);

                        doc.Add(verify);
                        doc.Add(witnessMan);
                        doc.Add(pos);
                        doc.Add(dateRight);

                        doc.Add(attest);
                        doc.Add(chairMan);
                        doc.Add(punongBarangay);
                        doc.Add(dateLeft);





                        // --------------------------------------------------------




                        // Close the document
                        doc.Close();

                        MessageBox.Show("PDF GENERATED SUCCESSFULLY!");
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

        private void GenerateBgyCertPDF(int userId, string typeOfDocu)
        {

            string connString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string FULLNAME;
            string CONTACTNUMBER;
            string REASON;
            string STATUS = "Accepted";
            string ADDRESS;


            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                    string query = $"SELECT * FROM request_ WHERE typeOfDocu = '{typeOfDocu}' AND request_status = '{STATUS}';";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        FULLNAME = dataGridView2.SelectedRows[0].Cells["Fname"].Value.ToString();
                        CONTACTNUMBER = dataGridView2.SelectedRows[0].Cells["contact_num"].Value.ToString();
                        REASON = dataGridView2.SelectedRows[0].Cells["reason"].Value.ToString();
                        ADDRESS = dataGridView2.SelectedRows[0].Cells["home"].Value.ToString();



                        DateTime currentDate = DateTime.Now;
                        // Create a PDF document
                        Document doc = new Document();
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("BRGY-Cert.pdf", FileMode.Create));

                        // Open the document to write content
                        doc.Open();


                        iTextSharp.text.Image background = iTextSharp.text.Image.GetInstance("C:\\Barangay Picture\\Caloocan_City.png");

                        float imageWidth = 500f;
                        float imageHeight = 300f;
                        background.ScaleAbsolute(imageWidth, imageHeight);

                        // Get the page size
                        Rectangle pageSize = doc.PageSize;
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


                        background.ScaleToFit(doc.PageSize.Width, doc.PageSize.Height);
                        background.SetAbsolutePosition(0, 0); // Position it at the bottom-left corner
                                                              // Add the image to the document



                        // Header of the document
                        iTextSharp.text.Font font1bold = FontFactory.GetFont(FontFactory.TIMES_BOLD, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font font1 = FontFactory.GetFont(FontFactory.TIMES, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font font = FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font fontTitle = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font fontRight = FontFactory.GetFont(FontFactory.TIMES_BOLD, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        Paragraph headerClearance = new Paragraph($"Republic City of the Philippines", font1bold);
                        Paragraph headerClearance1 = new Paragraph($"City of Caloocan", font);
                        Paragraph headerClearance2 = new Paragraph($"OFFICE OF THE PUNONG BARANGAY", font1);
                        Paragraph headerClearance3 = new Paragraph($"Barangay 22, Zone 2, District II", font);
                        Paragraph title = new Paragraph($"\n\nBARANGAY CERTIFICATION", fontTitle);
                        Paragraph bodyIndigency = new Paragraph($"\n\n\n\n\n\n\n\n\t\t\tThis is to Certify that {FULLNAME}., A resident of {ADDRESS} will use this Barangay Certification.\n" +
                            $"\n\t\tThis certification is issued for whatever legal purpose or purposes this may serve.\n" +
                            $"\n\t\tSigned this on the {currentDate.ToString("yyyy-MM-dd")} at BARANGAY 22 ZONE 2 DISTRICT II , CALOOCAN CITY, NATIONAL CAPITAL REGION, PHILIPPINES.\n" +
                            $"\n\t\tThis certification is valid only for 1 year from the issuance.\n");

                        Paragraph signature = new Paragraph($"\n\nSIGNATURE", fontTitle);
                        Paragraph punongBarangay = new Paragraph($"Punong Barangay", font);
                        Paragraph chairMan = new Paragraph($"RONALDO B. BAUTISTA", fontRight);
                        Paragraph dateRight = new Paragraph($"{currentDate.ToString("yyyy-MM-dd")}", font);

                        Paragraph witness = new Paragraph($"\n\nWitnessed by:", font);
                        Paragraph wSignature = new Paragraph($"SIGNATURE", fontTitle);
                        Paragraph witnessMan = new Paragraph($"ANTHONY S. MULAWIN", fontRight);
                        Paragraph pos = new Paragraph($"Secretary", font);


                        headerClearance.Alignment = Element.ALIGN_CENTER;
                        headerClearance1.Alignment = Element.ALIGN_CENTER;
                        headerClearance2.Alignment = Element.ALIGN_CENTER;
                        headerClearance3.Alignment = Element.ALIGN_CENTER;
                        title.Alignment = Element.ALIGN_CENTER;

                        signature.Alignment = Element.ALIGN_RIGHT;
                        punongBarangay.Alignment = Element.ALIGN_RIGHT;
                        chairMan.Alignment = Element.ALIGN_RIGHT;
                        dateRight.Alignment = Element.ALIGN_RIGHT;
                        witness.Alignment = Element.ALIGN_RIGHT;
                        chairMan.Alignment = Element.ALIGN_RIGHT;
                        dateRight.Alignment = Element.ALIGN_RIGHT;
                        witness.Alignment = Element.ALIGN_RIGHT;
                        wSignature.Alignment = Element.ALIGN_RIGHT;
                        witnessMan.Alignment = Element.ALIGN_RIGHT;
                        pos.Alignment = Element.ALIGN_RIGHT;

                        doc.Add(headerClearance);
                        doc.Add(headerClearance1);
                        doc.Add(headerClearance2);
                        doc.Add(headerClearance3);
                        doc.Add(title);
                        doc.Add(bodyIndigency);

                        doc.Add(signature);
                        doc.Add(chairMan);
                        doc.Add(punongBarangay);
                        doc.Add(dateRight);

                        doc.Add(witness);
                        doc.Add(wSignature);
                        doc.Add(witnessMan);
                        doc.Add(pos);
                        doc.Add(dateRight);



                        // --------------------------------------------------------




                        // Close the document
                        doc.Close();

                        MessageBox.Show("PDF GENERATED SUCCESSFULLY!");
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
        private void GenerateBgyIndigencyPDF(int userId, string typeOfDocu)
        {

            string connString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string FULLNAME;
            string CONTACTNUMBER;
            string REASON;
            string STATUS = "Accepted";
            string ADDRESS;


            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                    string query = $"SELECT * FROM request_ WHERE typeOfDocu = '{typeOfDocu}' AND request_status = '{STATUS}';";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        FULLNAME = dataGridView2.SelectedRows[0].Cells["Fname"].Value.ToString();
                        CONTACTNUMBER = dataGridView2.SelectedRows[0].Cells["contact_num"].Value.ToString();
                        REASON = dataGridView2.SelectedRows[0].Cells["reason"].Value.ToString();
                        ADDRESS = dataGridView2.SelectedRows[0].Cells["home"].Value.ToString();



                        DateTime currentDate = DateTime.Now;
                        // Create a PDF document
                        Document doc = new Document();
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream($"{FULLNAME}_Indigency.pdf", FileMode.Create));

                        // Open the document to write content
                        doc.Open();


                        iTextSharp.text.Image background = iTextSharp.text.Image.GetInstance("C:\\Barangay Picture\\Caloocan_City.png");

                        float imageWidth = 500f;
                        float imageHeight = 300f;
                        background.ScaleAbsolute(imageWidth, imageHeight);

                        // Get the page size
                        Rectangle pageSize = doc.PageSize;
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


                        background.ScaleToFit(doc.PageSize.Width, doc.PageSize.Height);
                        background.SetAbsolutePosition(0, 0); // Position it at the bottom-left corner
                                                              // Add the image to the document



                        // Header of the document
                        iTextSharp.text.Font font1bold = FontFactory.GetFont(FontFactory.TIMES_BOLD, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font font1 = FontFactory.GetFont(FontFactory.TIMES, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font font = FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font fontTitle = FontFactory.GetFont(FontFactory.TIMES_BOLD, 18, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font fontRight = FontFactory.GetFont(FontFactory.TIMES_BOLD, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        Paragraph headerClearance = new Paragraph($"Republic City of the Philippines", font1bold);
                        Paragraph headerClearance1 = new Paragraph($"City of Caloocan", font);
                        Paragraph headerClearance2 = new Paragraph($"OFFICE OF THE PUNONG BARANGAY", font1);
                        Paragraph headerClearance3 = new Paragraph($"Barangay 22, Zone 2, District II", font);
                        Paragraph title = new Paragraph($"\n\nCERTIFICATE OF INDIGENCY", fontTitle);
                        Paragraph whom = new Paragraph($"\n\n\nTO WHOM MAY IT CONCERN:", fontTitle);
                        Paragraph bodyIndigency = new Paragraph($"\n\n\t\t\tThis is to Certify that {FULLNAME}., A resident of {ADDRESS} will use this Barangay Clearance.\n" +
                            $"\n\t\tThis Clearance is issued for whatever legal purpose or purposes this may serve.\n" +
                            $"\n\t\tSigned this on the {currentDate.ToString("yyyy-MM-dd")} at BARANGAY 22 ZONE 2 DISTRICT II , CALOOCAN CITY, NATIONAL CAPITAL REGION, PHILIPPINES.\n" +
                            $"\n\t\tThis Clearance is valid only for 1 year from the issuance.\n", font);


                        Paragraph dateRight = new Paragraph($"{currentDate.ToString("yyyy-MM-dd")}", font);

                        Paragraph verify = new Paragraph($"\n\n\n\n\nVERIFIED BY:", font);
                        Paragraph witnessMan = new Paragraph($"ANTHONY S. MULAWIN", fontRight);
                        Paragraph pos = new Paragraph($"Secretary", font);

                        Paragraph dateLeft = new Paragraph($"\t\t\t{currentDate.ToString("yyyy-MM-dd")}", font);
                        Paragraph attest = new Paragraph($"\n\n\t\t\tATTESTED BY:", font);
                        Paragraph punongBarangay = new Paragraph($"\t\t\tPunong Barangay", font);
                        Paragraph chairMan = new Paragraph($"\t\t\tRONALD BAUTISTA", fontRight);

                        headerClearance.Alignment = Element.ALIGN_CENTER;
                        headerClearance1.Alignment = Element.ALIGN_CENTER;
                        headerClearance2.Alignment = Element.ALIGN_CENTER;
                        headerClearance3.Alignment = Element.ALIGN_CENTER;
                        title.Alignment = Element.ALIGN_CENTER;

                        verify.Alignment = Element.ALIGN_RIGHT;
                        chairMan.Alignment = Element.ALIGN_RIGHT;
                        dateRight.Alignment = Element.ALIGN_RIGHT;
                        witnessMan.Alignment = Element.ALIGN_RIGHT;
                        pos.Alignment = Element.ALIGN_RIGHT;

                        dateLeft.Alignment = Element.ALIGN_LEFT;
                        attest.Alignment = Element.ALIGN_LEFT;
                        chairMan.Alignment = Element.ALIGN_LEFT;
                        punongBarangay.Alignment = Element.ALIGN_LEFT;

                        doc.Add(headerClearance);
                        doc.Add(headerClearance1);
                        doc.Add(headerClearance2);
                        doc.Add(headerClearance3);
                        doc.Add(title);
                        doc.Add(whom);
                        doc.Add(bodyIndigency);

                        doc.Add(verify);
                        doc.Add(witnessMan);
                        doc.Add(pos);
                        doc.Add(dateRight);

                        doc.Add(attest);
                        doc.Add(chairMan);
                        doc.Add(punongBarangay);
                        doc.Add(dateLeft);





                        // --------------------------------------------------------
                        doc.Close();

                        MessageBox.Show("PDF GENERATED SUCCESSFULLY!");




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
        private void AddFirstPageContent(Document doc, PdfWriter writer, Rectangle idCardSizePortrait, string imagePath)
        {

            string connString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string FULLNAME;
            string CONTACTNUMBER;
            string REASON;
            string STATUS = "Accepted";
            string ADDRESS;
            string typeOfDocu = "BARANGAY ID";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                    string query = $"SELECT * FROM request_ WHERE typeOfDocu = '{typeOfDocu}' AND request_status = '{STATUS}';";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        FULLNAME = dataGridView2.SelectedRows[0].Cells["Fname"].Value.ToString();
                        CONTACTNUMBER = dataGridView2.SelectedRows[0].Cells["contact_num"].Value.ToString();
                        REASON = dataGridView2.SelectedRows[0].Cells["reason"].Value.ToString();
                        ADDRESS = dataGridView2.SelectedRows[0].Cells["home"].Value.ToString();
                        string HEIGHT = dataGridView2.SelectedRows[0].Cells["height"].Value.ToString();
                        string WEIGHT = dataGridView2.SelectedRows[0].Cells["weight"].Value.ToString();
                        string BIRTHDAY = dataGridView2.SelectedRows[0].Cells["birthday"].Value.ToString();
                        string SEX = dataGridView2.SelectedRows[0].Cells["sex"].Value.ToString();
                        string CSTATUS = dataGridView2.SelectedRows[0].Cells["civil_status"].Value.ToString();
                        string EMERGENCYNAME = dataGridView2.SelectedRows[0].Cells["emergency_contact_name"].Value.ToString();
                        string EMERGENCYNUMBER = dataGridView2.SelectedRows[0].Cells["emergency_contact_number"].Value.ToString();
                        string BLOODTYPE = dataGridView2.SelectedRows[0].Cells["blood_type"].Value.ToString();
                        string PRECINTNUMBER = dataGridView2.SelectedRows[0].Cells["precinct_number"].Value.ToString();


                        iTextSharp.text.Image background = iTextSharp.text.Image.GetInstance("C:\\Barangay Picture\\Caloocan_City.png");
                        background.ScaleToFit(idCardSizePortrait.Width, idCardSizePortrait.Height);
                        background.SetAbsolutePosition(0f, 50f);

                        PdfContentByte canvas = writer.DirectContent;

                        // Add the image with opacity
                        PdfGState gState = new PdfGState { FillOpacity = 0.1f, StrokeOpacity = 0.1f };
                        canvas.SaveState();
                        canvas.SetGState(gState);
                        canvas.AddImage(background);
                        canvas.RestoreState();



                        // Add header text
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("Republic of the Philippines", fontHeader), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 30f, 0);
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("City of Caloocan", fontHeader), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 45f, 0);
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("OFFICE OF THE PUNONG BARANGAY", fontBold), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 60f, 0);
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("Barangay 22, Zone 2, District II", fontRegular), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 75f, 0);

                        // Add full name and details text
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase($"{FULLNAME}", fontBold), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 150f, 0);
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("FULL NAME", fontRegular), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 165f, 0);

                        // Move the line under the name higher
                        canvas.MoveTo(10f, idCardSizePortrait.Height - 160f); // Raised by 10 points
                        canvas.LineTo(idCardSizePortrait.Width - 10f, idCardSizePortrait.Height - 160f);
                        canvas.Stroke();

                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase($"{ADDRESS}", fontBold), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 195f, 0);
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("RESIDENCE ADDRESS", fontRegular), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 205f, 0);

                        // Move the line under the address higher
                        canvas.MoveTo(10f, idCardSizePortrait.Height - 200f); // Raised by 10 points
                        canvas.LineTo(idCardSizePortrait.Width - 10f, idCardSizePortrait.Height - 200f);
                        canvas.Stroke();

                        // Add signature label
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("SIGNATURE", fontRegular), idCardSizePortrait.Width / 2, idCardSizePortrait.Height - 240f, 0);

                        // Add profile picture
                        iTextSharp.text.Image profilePic = iTextSharp.text.Image.GetInstance(imagePath); // Use the selected image path
                        profilePic.ScaleAbsolute(40f, 40f);
                        profilePic.SetAbsolutePosition(idCardSizePortrait.Width - 45f, 120f);
                        PdfContentByte underCanvas = writer.DirectContentUnder;
                        underCanvas.AddImage(profilePic);

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
        private void AddSecondPageContent(Document doc, PdfWriter writer, Rectangle idCardSizePortrait)
        {

            string connString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string FULLNAME;
            string CONTACTNUMBER;
            string REASON;
            string STATUS = "Accepted";
            string ADDRESS;
            string typeOfDocu = "BARANGAY ID";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                    string query = $"SELECT * FROM request_ WHERE typeOfDocu = '{typeOfDocu}' AND request_status = '{STATUS}';";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        FULLNAME = dataGridView2.SelectedRows[0].Cells["Fname"].Value.ToString();
                        CONTACTNUMBER = dataGridView2.SelectedRows[0].Cells["contact_num"].Value.ToString();
                        REASON = dataGridView2.SelectedRows[0].Cells["reason"].Value.ToString();
                        ADDRESS = dataGridView2.SelectedRows[0].Cells["home"].Value.ToString();
                        string HEIGHT = dataGridView2.SelectedRows[0].Cells["height"].Value.ToString();
                        string WEIGHT = dataGridView2.SelectedRows[0].Cells["weight"].Value.ToString();
                        string BIRTHDAY = dataGridView2.SelectedRows[0].Cells["birthday"].Value.ToString();
                        string SEX = dataGridView2.SelectedRows[0].Cells["sex"].Value.ToString();
                        string CSTATUS = dataGridView2.SelectedRows[0].Cells["civil_status"].Value.ToString();
                        string EMERGENCYNAME = dataGridView2.SelectedRows[0].Cells["emergency_contact_name"].Value.ToString();
                        string EMERGENCYNUMBER = dataGridView2.SelectedRows[0].Cells["emergency_contact_number"].Value.ToString();
                        string BLOODTYPE = dataGridView2.SelectedRows[0].Cells["blood_type"].Value.ToString();
                        string PRECINTNUMBER = dataGridView2.SelectedRows[0].Cells["precinct_number"].Value.ToString();


                        DateTime currentDate = DateTime.Now;
                        string expiration = DateTime.Now.AddMonths(3).ToString("yyyy-MM-dd");

                        // Add the background image and scale it to fit the ID card size
                        iTextSharp.text.Image background = iTextSharp.text.Image.GetInstance("C:\\Barangay Picture\\Caloocan_City.png"); //palitan to
                        background.ScaleToFit(idCardSizePortrait.Width, idCardSizePortrait.Height);
                        background.SetAbsolutePosition(0f, 50f);

                        PdfContentByte canvas = writer.DirectContent;

                        // Add the image with opacity
                        PdfGState gState = new PdfGState { FillOpacity = 0.1f, StrokeOpacity = 0.1f };
                        canvas.SaveState();
                        canvas.SetGState(gState);
                        canvas.AddImage(background);
                        canvas.RestoreState();




                        // Create a smaller font for the header
                        iTextSharp.text.Font fontHeaderSmall = FontFactory.GetFont(FontFactory.TIMES, 4, BaseColor.BLACK);
                        iTextSharp.text.Font fontHeaderSmaller = FontFactory.GetFont(FontFactory.TIMES, 3, BaseColor.BLACK);

                        // Combine the four lines into one
                        string combined1 = "BIRTHDAY\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0  " +
                            "SEX \u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0 " +
                            "HEIGHT \u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0 WEIGHT";

                        string data1 = $"{BIRTHDAY}\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0  " +
                            $"{SEX} \u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0 " +
                            $"{HEIGHT} \u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0 {WEIGHT}"; ;

                        // Draw a line above the text (adjust the Y-position for the line as needed)
                        float yLinePosition = idCardSizePortrait.Height - 25f; // Position the line just above the text
                        float leftMargin = 10f; // Start position of the line (left side)
                        float rightMargin = idCardSizePortrait.Width - 10f; // End position of the line (right side)
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase(data1, fontHeaderSmall), idCardSizePortrait.Width / 2, yLinePosition + 5f, 0);
                        // Draw the line
                        canvas.MoveTo(leftMargin, yLinePosition);
                        canvas.LineTo(rightMargin, yLinePosition);
                        canvas.Stroke();
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase(combined1, fontHeaderSmall), idCardSizePortrait.Width / 2, yLinePosition - 10f, 0);

                        // Combine the second set of text into one line
                        string combined2 = "CIVIL STATUS\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0  " +
                                           "BLOOD TYPE\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0 DATE ISSUED";

                        string data2 = $"{CSTATUS}\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0  " +
                                           $"{BLOODTYPE}\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0 {currentDate.ToString("yyyy-MM-dd")}";

                        // Draw the second line above combined2 text, move down from the first text
                        float yLinePosition2 = yLinePosition - 35f; // Move it further down for combined2

                        // Draw the line above combined2
                        canvas.MoveTo(leftMargin, yLinePosition2);
                        canvas.LineTo(rightMargin, yLinePosition2);
                        canvas.Stroke();
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase(data2, fontHeaderSmall), idCardSizePortrait.Width / 2, yLinePosition2 + 5f, 0);
                        // Add the second combined header in one line
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase(combined2, fontHeaderSmall), idCardSizePortrait.Width / 2, yLinePosition2 - 10f, 0);

                        // Combine the second set of text into one line
                        string combined3 = "DATE OF EXPIRY\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0 " +
                                           "CONTACT NUMBER\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0 PRECINCT NUMBER";

                        string data3 = $"{expiration}\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0 " +
                                           $"{CONTACTNUMBER}\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0 {PRECINTNUMBER}";


                        // Draw the second line above combined2 text, move down from the first text
                        float yLinePosition3 = yLinePosition2 - 35f; // Move it further down for combined2

                        // Draw the line above combined2
                        canvas.MoveTo(leftMargin, yLinePosition3);
                        canvas.LineTo(rightMargin, yLinePosition3);
                        canvas.Stroke();
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase(data3, fontHeaderSmall), idCardSizePortrait.Width / 2, yLinePosition3 + 5f, 0);
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase(combined3, fontHeaderSmall), idCardSizePortrait.Width / 2, yLinePosition3 - 10f, 0);

                        // Add the second combined header in one line
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase($"CONTACT PERSON IN CASE OF EMERGENCY", fontRegular), idCardSizePortrait.Width / 2, yLinePosition3 - 30f, 0);



                        // Draw the second line above combined2 text, move down from the first text
                        float yLinePosition4 = yLinePosition3 - 50f; // Move it further down for combined2

                        // Draw the line above combined2
                        canvas.MoveTo(leftMargin, yLinePosition4);
                        canvas.LineTo(rightMargin, yLinePosition4);
                        canvas.Stroke();
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase($"{EMERGENCYNAME}", fontHeaderSmall), idCardSizePortrait.Width / 2, yLinePosition4 + 5f, 0);
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("NAME", fontHeaderSmall), idCardSizePortrait.Width / 2, yLinePosition4 - 10f, 0);


                        // Draw the second line above combined2 text, move down from the first text
                        float yLinePosition5 = yLinePosition4 - 25f; // Move it further down for combined2

                        // Draw the line above combined2
                        canvas.MoveTo(leftMargin, yLinePosition5);
                        canvas.LineTo(rightMargin, yLinePosition5);
                        canvas.Stroke();
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase($"{EMERGENCYNUMBER}", fontHeaderSmall), idCardSizePortrait.Width / 2, yLinePosition5 + 5f, 0);
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("CONTACT NUMBER", fontHeaderSmall), idCardSizePortrait.Width / 2, yLinePosition5 - 10f, 0);





                        // Define the text you want to center as a paragraph
                        string certify = "This is to certify that the person whose name, photograph,\n and signature appear herein is a bonafide resident of Barangay 22, Zone 2, District II, Caloocan City." +
                                         "\nIf lost and found, please return this ID to Barangay 22, Zone 2, District II, Caloocan City.";

                        // Create a Paragraph to hold the text
                        Paragraph paragraph = new Paragraph(certify, fontHeaderSmaller)
                        {
                            Alignment = Element.ALIGN_CENTER // Set paragraph alignment to center
                        };

                        // Define the Y-position of the paragraph
                        float yPosition = yLinePosition5 - 20f;

                        // Add the paragraph to the canvas, wrapped in a ColumnText object
                        ColumnText column = new ColumnText(canvas);
                        column.SetSimpleColumn(new Rectangle(idCardSizePortrait.Left, yPosition - 50f, idCardSizePortrait.Right, yPosition)); // Define the rectangle area where the text will fit
                        column.AddElement(paragraph);
                        column.Go(); // Render the paragraph

                        float footpos = yLinePosition5 - 40f;
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("ISSUED BY:", fontHeaderSmall), idCardSizePortrait.Width / 2, footpos, 0);
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("RONALD B. BAUTISTA", fontHeaderSmall), idCardSizePortrait.Width / 2, footpos - 13f, 0);



                        // Draw the line above combined2
                        canvas.MoveTo(leftMargin, footpos - 15f);
                        canvas.LineTo(rightMargin, footpos - 15f);
                        canvas.Stroke();
                        ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("Punong Barangay", fontHeaderSmall), idCardSizePortrait.Width / 2, footpos - 20f, 0);

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


        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {

                int userId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["user_id"].Value);
                string typeOfDocu = dataGridView2.SelectedRows[0].Cells["typeOfDocu"].Value.ToString();
                string RStats = dataGridView2.SelectedRows[0].Cells["request_status"].Value.ToString();

                if (typeOfDocu == "BARANGAY CERTIFICATE" && RStats == "Accepted")
                {
                    GenerateBgyCertPDF(userId, typeOfDocu);
                }
                else if (typeOfDocu == "BARANGAY CLEARANCE" && RStats == "Accepted")
                {
                    GenerateBgyClearPDF(userId, typeOfDocu);
                }
                else if (typeOfDocu == "BARANGAY INDIGENCY" && RStats == "Accepted")
                {
                    GenerateBgyIndigencyPDF(userId, typeOfDocu);
                }
                else if (typeOfDocu == "BARANGAY ID" && RStats == "Accepted")
                {
                    string imagePath = string.Empty;  // Variable to store the selected image path

                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Title = "Select an Image";
                        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            imagePath = openFileDialog.FileName;  // Get the selected image path
                        }
                        else
                        {
                            // If no image is selected, show an error and return
                            MessageBox.Show("Please select an image.");
                            return;
                        }
                    }

                    // Step 2: Define the ID card size (same as before)
                    Rectangle idCardSizePortrait = new Rectangle(54f * 2.835f, 85.6f * 2.835f);

                    // Step 3: Create and write to the PDF
                    using (Document doc = new Document(idCardSizePortrait))
                    {
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("PortraitIDCard.pdf", FileMode.Create));
                        doc.Open();

                        // Add the first page content (pass the image path to the method)
                        AddFirstPageContent(doc, writer, idCardSizePortrait, imagePath);


                        // Add a second page
                        doc.NewPage(); // Create a new page
                        AddSecondPageContent(doc, writer, idCardSizePortrait);

                        // Close the document
                        doc.Close();
                    }

                    MessageBox.Show("PDF GENERATED SUCCESSFULLY!");
                }

                else
                {
                    MessageBox.Show("This Request is not yet Accepted!");
                }
            }
            else
            {
                MessageBox.Show("Please select an entire row to generate a PDF.");
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
