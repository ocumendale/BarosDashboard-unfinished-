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
    public partial class FormBas : Form
    {
        public FormBas()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void backCourt_Click(object sender, EventArgs e)
        {
            reserve res = new reserve();
            res.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
