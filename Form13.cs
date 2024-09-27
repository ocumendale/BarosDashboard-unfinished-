using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Rectangle = iTextSharp.text.Rectangle;

namespace BarosDashboard
{
    public partial class FormClear : Form
    {
        public FormClear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocuReq docureq = new DocuReq();
            docureq.Show();
            Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
        private void GetDataFromMySQL()
        {
            string connectionString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string query = "INSERT INTO brgy_clear (Fname, contact_num, home, reason) VALUES (@Fullname, @Contactnumber, @home, @reason)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@Fullname", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Contactnumber", textBox2.Text);
                        cmd.Parameters.AddWithValue("@home", textBox4.Text);
                        cmd.Parameters.AddWithValue("@reason", textBox3.Text);

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

        private void FormClear_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            GeneratePDF();
            MessageBox.Show("PDF GENERATED SUCCESSFULLY!");
            GetDataFromMySQL();
        }
        private void GeneratePDF()
        {
            DateTime currentDate = DateTime.Now;
            // Create a PDF document
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream($"{textBox1.Text}_CLEARANCE.pdf", FileMode.Create));

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
            Paragraph bodyIndigency = new Paragraph($"\n\n\t\t\tThis is to Certify that {textBox1.Text}., A resident of {textBox4.Text} will use this Barangay Clearance.\n" +
                $"\nPurpose: {textBox3.Text}" + $"\n\t\tThis Clearance is issued for whatever legal purpose or purposes this may serve.\n" +
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
        }
    }
}
