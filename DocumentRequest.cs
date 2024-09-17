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
    public partial class DocumentRequest : Form
    {
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
            this.Hide();
            ResidentsComplaints residentsComplaints = new ResidentsComplaints();
            residentsComplaints.Show();
        }

        private void EmergencyRes_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmergencyResponses emergencyResponses = new EmergencyResponses();
            emergencyResponses.Show();
        }

        private void Announcements_Click(object sender, EventArgs e)
        {
            this.Hide();
            Announcements announcements = new Announcements();
            announcements.Show();
        }

        private void Events_Click(object sender, EventArgs e)
        {
            this.Hide();
            Events events = new Events();
            events.Show();
        }
    }
}
