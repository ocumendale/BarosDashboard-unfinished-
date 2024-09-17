using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarosDashboard
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void clear2_btn_Click(object sender, EventArgs e)
        {
            cNum_tb.Clear();
            pass_tb.Clear();
        }

        private void signin_Btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Visible = false;

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool IsValidUsername(string username)
        {

            return !string.IsNullOrEmpty(username);
        }

        


    }
}
