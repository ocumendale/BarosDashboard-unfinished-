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
    public partial class manageReq : Form
    {
        public manageReq()
        {
            InitializeComponent();
        }

        private void backReq_Click(object sender, EventArgs e)
        {
            
        }

        private void manageReq_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }
    }
}
