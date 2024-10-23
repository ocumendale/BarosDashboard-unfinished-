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
using System.Data;
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
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                login loginForm = new login();
                loginForm.Show();
                this.Close();
            }
        }

        private void DocumentRequest_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void DocuReq_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Open your database connection
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // SQL Query
                string query = @"
                SELECT typeofDocu, brgyid_id, Fname, contact_num, home, reason, yrsofrecidency, request_status
                FROM request_ 
                WHERE typeOfDocu = 'BARANGAY CERTIFICATE';";

                // Execute Query
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                // Bind to DataGridView
                dataGridView2.DataSource = ds.Tables[0];

                // Optional: Adjust column widths or other settings
                dataGridView2.Columns["Fname"].Width = 150;
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Open your database connection
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // SQL Query
                string query = @"
            SELECT typeofDocu, brgyid_id, Fname, contact_num, home, reason, yrsofrecidency, request_status
            FROM request_ 
            WHERE typeOfDocu = 'BARANGAY INDIGENCY';";

                // Execute Query
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                // Bind to DataGridView
                dataGridView2.DataSource = ds.Tables[0];

                // Optional: Adjust column widths or other settings
                dataGridView2.Columns["Fname"].Width = 150;
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Open your database connection
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // SQL Query
                string query = @"
            SELECT typeofDocu, brgyid_id, Fname, contact_num, home, reason, yrsofrecidency, request_status
            FROM request_ 
            WHERE typeOfDocu = 'BARANGAY CLEARANCE';";

                // Execute Query
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                // Bind to DataGridView
                dataGridView2.DataSource = ds.Tables[0];

                // Optional: Adjust column widths or other settings
                dataGridView2.Columns["Fname"].Width = 150;
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void brgy_id_Click(object sender, EventArgs e)
        {
            LoadReservations("BARANGAY ID");

        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            reg_approval approval = new reg_approval();
            approval.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Get the selected reservation data
                int userId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["user_id"].Value);
                string typeOfDocu = dataGridView2.SelectedRows[0].Cells["typeOfDocu"].Value.ToString();

                // Accept only the selected reservation type for the user
                UpdateReservationStatus(userId, typeOfDocu, "Accepted");
            }
            else
            {
                MessageBox.Show("Please select a Request to accept.");
            }
        }
        private void UpdateReservationStatus(int userId, string typeOfDocu, string newStatus)
        {
            try
            {
                string query = "UPDATE request_ SET request_status = @newStatus WHERE user_id = @userId AND typeOfDocu = @typeOfDocu";
                using (MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;"))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@newStatus", newStatus);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@typeOfDocu", typeOfDocu);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Reload reservations after status update, but only for the current reservation type
                LoadReservations(typeOfDocu);
                MessageBox.Show($"Document Request {newStatus.ToLower()} successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Request: " + ex.Message);
            }
        }
        private void LoadReservations(string typeOfDocu)
        {
            string query = $"SELECT * FROM request_ WHERE typeOfDocu = '{typeOfDocu}';";
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Get the selected reservation data
                int userId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["user_id"].Value);
                string typeOfDocu = dataGridView2.SelectedRows[0].Cells["typeOfDocu"].Value.ToString();

                // Reject only the selected reservation type for the user
                UpdateReservationStatus(userId, typeOfDocu, "Rejected");
            }
            else
            {
                MessageBox.Show("Please select a Request to reject.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            


            string typeOfDocu = dataGridView2.SelectedRows[0].Cells["brgyid_id"].Value.ToString();
            string RStats = dataGridView2.SelectedRows[0].Cells["Fname"].Value.ToString();

            
        }

        private void GenerateCertPDF(int userId, string typeOfDocu)
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
                    string query = $"SELECT * FROM request_ WHERE reservation_type = '{typeOfDocu}' AND request_status = '{STATUS}';";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Retrieve selected row data
                        FULLNAME = dataGridView2.SelectedRows[0].Cells["Fname"].Value.ToString();
                        CONTACTNUMBER = dataGridView2.SelectedRows[0].Cells["contact_num"].Value.ToString();
                        REASON = dataGridView2.SelectedRows[0].Cells["reason"].Value.ToString();
                        ADDRESS = dataGridView2.SelectedRows[0].Cells["home"].Value.ToString();

                        DateTime currentDate = DateTime.Now;

                        // Create a PDF document
                        Document doc = new Document();
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream($"{FULLNAME}_CERTIFICATE.pdf", FileMode.Create));

                        // Open the document to write content
                        doc.Open();

                        iTextSharp.text.Image background = iTextSharp.text.Image.GetInstance("C:\\Barangay Picture\\Caloocan_City.png");
                        float imageWidth = 500f;
                        float imageHeight = 300f;
                        background.ScaleAbsolute(imageWidth, imageHeight);

                        // Get the page size from iTextSharp
                        iTextSharp.text.Rectangle pageSize = doc.PageSize;
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

                        // Header of the document
                        iTextSharp.text.Font font1bold = FontFactory.GetFont(FontFactory.TIMES_BOLD, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font font1 = FontFactory.GetFont(FontFactory.TIMES, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font font = FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font fontTitle = FontFactory.GetFont(FontFactory.TIMES_BOLD, 18, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font fontRight = FontFactory.GetFont(FontFactory.TIMES_BOLD, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        // Create paragraphs for the document
                        Paragraph headerCertificate = new Paragraph($"Republic City of the Philippines", font1bold);
                        Paragraph headerCertificate1= new Paragraph($"City of Caloocan", font);
                        Paragraph headerCertificate2 = new Paragraph($"OFFICE OF THE PUNONG BARANGAY", font1);
                        Paragraph headerCertificate3 = new Paragraph($"Barangay 22, Zone 2, District II", font);
                        Paragraph title = new Paragraph($"\n\nBARANGAY CERTIFICATE", fontTitle);
                        Paragraph whom = new Paragraph($"\n\nTO WHOM MAY IT CONCERN:", fontTitle);
                        Paragraph bodyIndigency = new Paragraph($"\n\n\t\t\tThis is to Certify that {FULLNAME}, A resident of {ADDRESS} will use this Barangay Certificate.\n" +
                            $"\nPurpose: {REASON}" + $"\n\t\tThis Certificate is issued for whatever legal purpose or purposes this may serve.\n" +
                            $"\nRemarks: NO RECORDS OF ANY OFFENSE AND THAT THE SAID PERSON IS OF GOOD MORAL CHARACTER AND A LAW ABIDING CITIZEN OF THE COMMUNITY.\n" +
                            $"\n\t\tSigned this on the {currentDate.ToString("yyyy-MM-dd")} at BARANGAY 22 ZONE 2 DISTRICT II , CALOOCAN CITY, NATIONAL CAPITAL REGION, PHILIPPINES.\n" +
                            $"\n\t\tThis Indigency is valid only for 1 year from the issuance.\n", font);

                        Paragraph dateRight = new Paragraph($"DATE TODAY", font);
                        Paragraph verify = new Paragraph($"\n\n\n\n\nVERIFIED BY:", font);
                        Paragraph witnessMan = new Paragraph($"ANTHONY S. MULAWIN", fontRight);
                        Paragraph pos = new Paragraph($"Secretary", font);
                        Paragraph dateLeft = new Paragraph($"\t\t\t{currentDate.ToString("yyyy-MM-dd")}", font);
                        Paragraph attest = new Paragraph($"\n\n\t\t\tATTESTED BY:", font);
                        Paragraph punongBarangay = new Paragraph($"\t\t\tPunong Barangay", font);
                        Paragraph chairMan = new Paragraph($"\t\t\tRONALD BAUTISTA", fontRight);

                        // Alignments
                        headerCertificate.Alignment = Element.ALIGN_CENTER;
                        headerCertificate1.Alignment = Element.ALIGN_CENTER;
                        headerCertificate2.Alignment = Element.ALIGN_CENTER;
                        headerCertificate3.Alignment = Element.ALIGN_CENTER;
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

                        // Add content to the document
                        doc.Add(headerCertificate);
                        doc.Add(headerCertificate1);
                        doc.Add(headerCertificate2);
                        doc.Add(headerCertificate3);
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
        private void GenerateIndiPDF(int userId, string typeOfDocu)
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
                    string query = $"SELECT * FROM request_ WHERE reservation_type = '{typeOfDocu}' AND request_status = '{STATUS}';";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Retrieve selected row data
                        FULLNAME = dataGridView2.SelectedRows[0].Cells["Fname"].Value.ToString();
                        CONTACTNUMBER = dataGridView2.SelectedRows[0].Cells["contact_num"].Value.ToString();
                        REASON = dataGridView2.SelectedRows[0].Cells["reason"].Value.ToString();
                        ADDRESS = dataGridView2.SelectedRows[0].Cells["home"].Value.ToString();

                        DateTime currentDate = DateTime.Now;

                        // Create a PDF document
                        Document doc = new Document();
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream($"{FULLNAME}_INDIGENCY.pdf", FileMode.Create));

                        // Open the document to write content
                        doc.Open();

                        iTextSharp.text.Image background = iTextSharp.text.Image.GetInstance("C:\\Barangay Picture\\Caloocan_City.png");
                        float imageWidth = 500f;
                        float imageHeight = 300f;
                        background.ScaleAbsolute(imageWidth, imageHeight);

                        // Get the page size from iTextSharp
                        iTextSharp.text.Rectangle pageSize = doc.PageSize;
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

                        // Header of the document
                        iTextSharp.text.Font font1bold = FontFactory.GetFont(FontFactory.TIMES_BOLD, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font font1 = FontFactory.GetFont(FontFactory.TIMES, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font font = FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font fontTitle = FontFactory.GetFont(FontFactory.TIMES_BOLD, 18, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        iTextSharp.text.Font fontRight = FontFactory.GetFont(FontFactory.TIMES_BOLD, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        // Create paragraphs for the document
                        Paragraph headerIndigency = new Paragraph($"Republic City of the Philippines", font1bold);
                        Paragraph headerIndigency1 = new Paragraph($"City of Caloocan", font);
                        Paragraph headerIndigency2 = new Paragraph($"OFFICE OF THE PUNONG BARANGAY", font1);
                        Paragraph headerIndigency3 = new Paragraph($"Barangay 22, Zone 2, District II", font);
                        Paragraph title = new Paragraph($"\n\nBARANGAY INDIGENCY", fontTitle);
                        Paragraph whom = new Paragraph($"\n\nTO WHOM MAY IT CONCERN:", fontTitle);
                        Paragraph bodyIndigency = new Paragraph($"\n\n\t\t\tThis is to Certify that {FULLNAME}, A resident of {ADDRESS} will use this Barangay Indigency.\n" +
                            $"\nPurpose: {REASON}" + $"\n\t\tThis Indigency is issued for whatever legal purpose or purposes this may serve.\n" +
                            $"\nRemarks: NO RECORDS OF ANY OFFENSE AND THAT THE SAID PERSON IS OF GOOD MORAL CHARACTER AND A LAW ABIDING CITIZEN OF THE COMMUNITY.\n" +
                            $"\n\t\tSigned this on the {currentDate.ToString("yyyy-MM-dd")} at BARANGAY 22 ZONE 2 DISTRICT II , CALOOCAN CITY, NATIONAL CAPITAL REGION, PHILIPPINES.\n" +
                            $"\n\t\tThis Indigency is valid only for 1 year from the issuance.\n", font);

                        Paragraph dateRight = new Paragraph($"DATE TODAY", font);
                        Paragraph verify = new Paragraph($"\n\n\n\n\nVERIFIED BY:", font);
                        Paragraph witnessMan = new Paragraph($"ANTHONY S. MULAWIN", fontRight);
                        Paragraph pos = new Paragraph($"Secretary", font);
                        Paragraph dateLeft = new Paragraph($"\t\t\t{currentDate.ToString("yyyy-MM-dd")}", font);
                        Paragraph attest = new Paragraph($"\n\n\t\t\tATTESTED BY:", font);
                        Paragraph punongBarangay = new Paragraph($"\t\t\tPunong Barangay", font);
                        Paragraph chairMan = new Paragraph($"\t\t\tRONALD BAUTISTA", fontRight);

                        // Alignments
                        headerIndigency.Alignment = Element.ALIGN_CENTER;
                        headerIndigency1.Alignment = Element.ALIGN_CENTER;
                        headerIndigency2.Alignment = Element.ALIGN_CENTER;
                        headerIndigency3.Alignment = Element.ALIGN_CENTER;
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

                        // Add content to the document
                        doc.Add(headerIndigency);
                        doc.Add(headerIndigency1);
                        doc.Add(headerIndigency2);
                        doc.Add(headerIndigency3);
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


        private void GenerateClearPDF(int userId, string typeOfDocu)
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
                    string query = $"SELECT * FROM request_ WHERE reservation_type = '{typeOfDocu}' AND request_status = '{STATUS}';";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        FULLNAME = dataGridView2.SelectedRows[0].Cells["Fname"].Value.ToString();
                        CONTACTNUMBER = dataGridView2.SelectedRows[0].Cells["contact_num"].Value.ToString();
                        REASON = dataGridView2.SelectedRows[0].Cells["reason"].Value.ToString();
                        ADDRESS = dataGridView2.SelectedRows[0].Cells["home"].Value.ToString();

                        //palitan mo yung template

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

                        // Get the page size from iTextSharp
                        iTextSharp.text.Rectangle pageSize = doc.PageSize;
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

            MessageBox.Show("PDF GENERATED SUCCESSFULLY!");
        }
    }
}
