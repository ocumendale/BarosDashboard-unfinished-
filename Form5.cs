using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarosDashboard
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUsForm aboutUsForm = new AboutUsForm();
            aboutUsForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact contact = new Contact();
            contact.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HowItWorks hitw = new HowItWorks();
            hitw.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            reserve reserve = new reserve();
            reserve.Show();
            Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DocuReq docuReq = new DocuReq();
            docuReq.Show();
            Visible = false;
        }

        private void Services_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                LoggedInUser.UserId = 0;
                LoggedInUser.Uname = string.Empty;


                login loginForm = new login();
                loginForm.Show();


                this.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageTransaction manageTransaction = new ManageTransaction();
            manageTransaction.Show();
        }
    }
}
