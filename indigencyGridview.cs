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
    public partial class indigencyGridview : Form
    {
        public indigencyGridview()
        {
            InitializeComponent();
        }

        private void indigencyGridview_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocumentRequest documentRequest = new DocumentRequest();
            documentRequest.Show();
        }
    }
}
