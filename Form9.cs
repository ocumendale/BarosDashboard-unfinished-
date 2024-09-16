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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageTransaction manage = new ManageTransaction();
            manage.ShowDialog();
        }

        private void Reservation_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
