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
    public partial class Scanner : Form
    {
        public Scanner()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnToMlogin_Click(object sender, EventArgs e)
        {
            login mlogin = new login();
            mlogin.Show();
            this.Close();
        }
    }
}
