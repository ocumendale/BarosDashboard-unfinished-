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
    public partial class FormIn : Form
    {
        public FormIn()
        {
            InitializeComponent();
        }

        private void backIn_Click(object sender, EventArgs e)
        {
            DocuReq docureq = new DocuReq();
            docureq.Show();
            Visible = false;
        }
    }
}
