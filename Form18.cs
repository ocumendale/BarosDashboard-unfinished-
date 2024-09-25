using iTextSharp.text.pdf;
using iTextSharp.text;
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

namespace BarosDashboard
{
    public partial class FormChair : Form
    {
        public FormChair()
        {
            InitializeComponent();
        }

        private void backChair_Click(object sender, EventArgs e)
        {
            reserve res = new reserve();
            res.Show();
            Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FormChair_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Tables.pdf", FileMode.Create));

            // Open the document to write content
            doc.Open();


            // Add a paragraph
            Paragraph name = new Paragraph($"Full Name: {textBox1.Text}");
            Paragraph cnum = new Paragraph($"Contact Number: {textBox2.Text}");
            Paragraph reas = new Paragraph($"Reason: {textBox3.Text}");
            Paragraph dateNtime = new Paragraph($"Date: {textBox4.Text} \n Time: {textBox5.Text}");
            Paragraph quanti = new Paragraph($"Quantity: {textBox6.Text}");
            doc.Add(name);
            doc.Add(cnum);
            doc.Add(reas);
            doc.Add(dateNtime);
            doc.Add(quanti);

            // Close the document
            doc.Close();

            MessageBox.Show("Your PDF has been successfully Generated!");
            GetDataFromMySQL();
        }
        private void GetDataFromMySQL()
        {
            string connectionString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string query = "INSERT INTO chair (Fname, contact_num, reason, date, time, quantity) VALUES (@Fullname, @Contactnumber, @reason, @date, @time, @quantity)";

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
                        cmd.Parameters.AddWithValue("@time", textBox6.Text);
                        cmd.Parameters.AddWithValue("@quantity", textBox5.Text);

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
    }
}
