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
    public partial class brgyIdNext : Form
    {
        public brgyIdNext()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPrecinctNumber_Click(object sender, EventArgs e)
        {

        }


        private void Form20_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void backId_Click(object sender, EventArgs e)
        {
            FormId next = new FormId();
            next.Show();
            Visible = false;
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            submitId submit = new submitId();
            submit.Show();
            Visible = false;
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
