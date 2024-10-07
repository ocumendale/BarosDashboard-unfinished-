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
            this.Hide();
            login log = new login();
            log.Show();
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
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM brgy_cert", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM brgy_in", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM brgy_clear", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

        }

        private void brgy_id_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM brgy_id", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

        }

    }
}
