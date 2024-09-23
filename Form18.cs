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
    public partial class FormChair : Form
    {
        public FormChair()
        {
            InitializeComponent();
        }

        private void backChair_Click(object sender, EventArgs e)
        {
            reserve res = new reserve();
            res.Show();
            Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
