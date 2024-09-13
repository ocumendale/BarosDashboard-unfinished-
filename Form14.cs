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
    public partial class FormCertif : Form
    {
        public FormCertif()
        {
            InitializeComponent();
        }

        private void backCer_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.Show();
            Visible = false;
        }
    }
}
