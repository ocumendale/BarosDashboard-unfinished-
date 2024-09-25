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
    public partial class reserve : Form
    {
        public reserve()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageTransaction manage = new ManageTransaction();
            manage.ShowDialog();
        }

        private void Request_Click(object sender, EventArgs e)
        {

        }

        private void reserveCourt_Click(object sender, EventArgs e)
        {
            FormBas formbas = new FormBas();
            formbas.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTable table = new FormTable();
            table.Show();
            Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormChair chair = new FormChair();
            chair.Show();
            Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTent tent = new FormTent();
            tent.Show();
            Visible = false;
        }

        private void backReq_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.Show();
            Visible = false;
        }

        private void reserve_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;           
            this.TopMost = true;
        }
    }
}
