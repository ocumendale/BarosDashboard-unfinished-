﻿using System;
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
    public partial class Contact : Form
    {
        public Contact()
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HowItWorks hitw = new HowItWorks();
            hitw.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //dsds
            this.Hide();
            Services services = new Services();
            services.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageTransaction manage = new ManageTransaction();
            manage.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void contactbtn_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/profile.php?id=100063713499582";

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // This ensures the system opens it with the default web browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Contact_Load(object sender, EventArgs e)
        {

        }
    }
}
