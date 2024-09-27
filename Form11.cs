using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarosDashboard
{
    public partial class DocuReq : Form
    {
        public DocuReq()
        {
            InitializeComponent();
        }

        private void DocuReq_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormClear formClear = new FormClear();
            formClear.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormIn formIn = new FormIn();
            formIn.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCertif formCertif = new FormCertif();
            formCertif.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormId formId = new FormId();
            formId.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.Show();
            Visible = false;
        }
    }
}
