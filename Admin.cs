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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Announcements_Click(object sender, EventArgs e)
        {

        }

        private void EmergencyRes_Click(object sender, EventArgs e)
        {

        }

        private void DocuReq_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocumentRequest documentRequest = new DocumentRequest();
            documentRequest.Show();
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

        private void Events_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            reg_approval approval = new reg_approval();
            approval.Show();
            this.Hide();
        }
    }
}
