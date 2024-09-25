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

namespace BarosDashboard
{
    public partial class FormCertif : Form
    {
        public FormCertif()
        {
            InitializeComponent();
        }

        private void backCer_Click(object sender, EventArgs e)
        {
            DocuReq docureq = new DocuReq();
            docureq.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* using (Document doc = new Document())
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("BRGY-Cert.pdf", FileMode.Create));
                doc.Open();

                // Add background image
                var background = iTextSharp.text.Image.GetInstance("D:\\Barangay Picture\\Caloocan_City.png");
                background.ScaleAbsolute(500f, 300f);
                background.SetAbsolutePosition((doc.PageSize.Width - background.ScaledWidth) / 2, (doc.PageSize.Height - background.ScaledHeight) / 2);

                PdfGState gState = new PdfGState { FillOpacity = 0.1f };
                PdfContentByte canvas = writer.DirectContent;
                canvas.SaveState();
                canvas.SetGState(gState);
                canvas.AddImage(background);
                canvas.RestoreState();

                // Define fonts
                var fonts = new Dictionary<string, iTextSharp.text.Font>
{
   { "bold16", FontFactory.GetFont(FontFactory.TIMES_BOLD, 16) },
    { "bold14", FontFactory.GetFont(FontFactory.TIMES_BOLD, 14) },
    { "bold13", FontFactory.GetFont(FontFactory.TIMES_BOLD, 13) },
    { "bold11", FontFactory.GetFont(FontFactory.TIMES_BOLD, 11) }
};

                // Create paragraphs
                var paragraphs = new List<Paragraph>
{
    new Paragraph("Republic City of the Philippines", fonts["bold16"]) { Alignment = Element.ALIGN_CENTER },
    new Paragraph("City of Caloocan", fonts["bold11"]) { Alignment = Element.ALIGN_CENTER },
    new Paragraph("OFFICE OF THE PUNONG BARANGAY", fonts["bold11"]) { Alignment = Element.ALIGN_CENTER },
    new Paragraph("Barangay 22, Zone 2, District II", fonts["bold11"]) { Alignment = Element.ALIGN_CENTER },
    new Paragraph("\n\nBARANGAY CERTIFICATION", fonts["bold14"]) { Alignment = Element.ALIGN_CENTER },
    new Paragraph($"\n\n\n\n\n\n\n\n\t\t\tThis is to Certify that {textBox1.Text}, a resident of {textBox4.Text} will use this Barangay Certification.\n" +
                  "\n\t\tThis certification is issued for whatever legal purpose or purposes this may serve.\n" +
                  "\n\t\tSigned this on the (Date Today) at BARANGAY 22 ZONE 2 DISTRICT II, CALOOCAN CITY, NATIONAL CAPITAL REGION, PHILIPPINES.\n" +
                  "\n\t\tThis certification is valid only for 1 year from the issuance.\n"),
    new Paragraph("\n\nSIGNATURE", fonts["bold14"]) { Alignment = Element.ALIGN_RIGHT },
    new Paragraph("Punong Barangay", fonts["bold11"]) { Alignment = Element.ALIGN_RIGHT },
    new Paragraph("RONALDO B. BAUTISTA", fonts["bold13"]) { Alignment = Element.ALIGN_RIGHT },
    new Paragraph("DATE TODAY", fonts["bold11"]) { Alignment = Element.ALIGN_RIGHT },
    new Paragraph("\n\nWitnessed by:", fonts["bold11"]) { Alignment = Element.ALIGN_RIGHT },
    new Paragraph("SIGNATURE", fonts["bold14"]) { Alignment = Element.ALIGN_RIGHT },
    new Paragraph("ANTHONY S. MULAWIN", fonts["bold13"]) { Alignment = Element.ALIGN_RIGHT },
    new Paragraph("Secretary", fonts["bold11"]) { Alignment = Element.ALIGN_RIGHT }
};

                // Add all paragraphs to document
                foreach (var paragraph in paragraphs)
                {
                    doc.Add(paragraph);
                }

                // Close the document
                doc.Close();
            }
  */

            MessageBox.Show("PDF GENERATED SUCCESSFULLY!");
            GetDataFromMySQL();
        }
        private void GetDataFromMySQL()
        {
            string connectionString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string query = "INSERT INTO brgy_cert (Fname, contact_num, home, reason, years) VALUES (@Fullname, @Contactnumber, @home, @reason, @years)";

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
                        cmd.Parameters.AddWithValue("@years", textBox5.Text);


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

        private void FormCertif_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }
    }
}
