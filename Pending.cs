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
    public partial class Pending : Form
    {
        public Pending()
        {
            InitializeComponent();
        }

        private void back2Login_Click(object sender, EventArgs e)
        {
            login mLog = new login();
            mLog.Show();
            this.Hide();
        }

        private void Pending_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
