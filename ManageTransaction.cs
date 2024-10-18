using MySql.Data.MySqlClient;
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
    public partial class ManageTransaction : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=Daiki002039!;database=baros;SslMode=None;";
        int userId = LoggedInUser.UserId;
        string Chair_ = reserve.chair_;
        

        public ManageTransaction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlDataAdapter da = new MySqlDataAdapter($"SELECT * FROM basketball_court WHERE user_id = {userId} AND reservation_type = 'BASKETBALL COURT';", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ManageTransaction_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUsForm aboutUsForm = new AboutUsForm();
            aboutUsForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact contact = new Contact();
            contact.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HowItWorks hitw = new HowItWorks();
            hitw.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services services = new Services();
            services.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                LoggedInUser.UserId = 0;
                LoggedInUser.Uname = string.Empty;


                login loginForm = new login();
                loginForm.Show();


                this.Close();
            }
        }

        private void table_Click(object sender, EventArgs e)
        {


            MySqlDataAdapter da = new MySqlDataAdapter($"SELECT * FROM basketball_court WHERE user_id = {userId} AND reservation_type = 'TABLE';", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Chair_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter($"SELECT * FROM basketball_court WHERE user_id = {userId} AND reservation_type = 'CHAIR';", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void tent_Click(object sender, EventArgs e)
        {


            MySqlDataAdapter da = new MySqlDataAdapter($"SELECT * FROM basketball_court WHERE user_id = {userId} AND reservation_type = 'TENT';", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {


            MySqlDataAdapter da = new MySqlDataAdapter($"SELECT * FROM brgy_cert WHERE user_id = {userId} ", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void indigency_Click(object sender, EventArgs e)
        {


            MySqlDataAdapter da = new MySqlDataAdapter($"SELECT * FROM brgy_in WHERE user_id =  {userId}", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void clearance_Click(object sender, EventArgs e)
        {


            MySqlDataAdapter da = new MySqlDataAdapter($"SELECT * FROM brgy_clear WHERE user_id = {userId}", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ID_Click(object sender, EventArgs e)
        {


            MySqlDataAdapter da = new MySqlDataAdapter($"SELECT * FROM brgy_id WHERE user_id = {userId}", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
