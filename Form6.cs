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
    public partial class ManageTransaction : Form
    {
        public ManageTransaction()
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services services = new Services();
            services.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation reserve = new Reservation();
            reserve.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            manageReq req = new manageReq();
            req.Show();
            Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
