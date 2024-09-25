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
    public partial class FormBas : Form
    {
        public FormBas()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void backCourt_Click(object sender, EventArgs e)
        {
            reserve res = new reserve();
            res.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Basketball.pdf", FileMode.Create));

            // Open the document to write content
            doc.Open();


            // Add a paragraph
            Paragraph name = new Paragraph($"Full Name: {textBox1.Text}");
            Paragraph cnum = new Paragraph($"Contact Number: {textBox2.Text}");
            Paragraph reas = new Paragraph($"Reason: {textBox3.Text}");
            Paragraph dateNtime = new Paragraph($"Date: {textBox4.Text} Time: {textBox6.Text}");
            doc.Add(name);
            doc.Add(cnum);
            doc.Add(reas);
            doc.Add(dateNtime);

            // Close the document
            doc.Close();

            MessageBox.Show("Your PDF has been successfully Generated!");
            GetDataFromMySQL();
        }
        private void GetDataFromMySQL()
        {
            string connectionString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
            string query = "INSERT INTO basketball_court (Fname, contact_num, reason, date, time) VALUES (@Fullname, @Contactnumber, @reason, @date, @time)";

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
