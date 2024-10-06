namespace BarosDashboard
{
    partial class DocumentRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentRequest));
            panel1 = new Panel();
            signout = new Button();
            ResAssist = new Button();
            DocuReq = new Button();
            MyProfile = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            baros = new Label();
            panel4 = new Panel();
            dataGridView2 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            brgy_id = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 180, 71);
            panel1.Controls.Add(signout);
            panel1.Controls.Add(ResAssist);
            panel1.Controls.Add(DocuReq);
            panel1.Controls.Add(MyProfile);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 1199);
            panel1.TabIndex = 3;
            // 
            // signout
            // 
            signout.FlatAppearance.BorderSize = 0;
            signout.FlatStyle = FlatStyle.Flat;
            signout.Font = new Font("Yu Gothic UI", 20.25F);
            signout.Location = new Point(47, 826);
            signout.Name = "signout";
            signout.Size = new Size(149, 41);
            signout.TabIndex = 7;
            signout.Text = "SIGN OUT";
            signout.UseVisualStyleBackColor = true;
            signout.Click += Events_Click;
            // 
            // ResAssist
            // 
            ResAssist.FlatAppearance.BorderSize = 0;
            ResAssist.FlatStyle = FlatStyle.Flat;
            ResAssist.Font = new Font("Yu Gothic UI", 20.25F);
            ResAssist.Location = new Point(49, 733);
            ResAssist.Name = "ResAssist";
            ResAssist.Size = new Size(342, 46);
            ResAssist.TabIndex = 3;
            ResAssist.Text = "RESERVATION";
            ResAssist.TextAlign = ContentAlignment.MiddleLeft;
            ResAssist.UseVisualStyleBackColor = true;
            ResAssist.Click += ResAssist_Click;
            // 
            // DocuReq
            // 
            DocuReq.FlatAppearance.BorderSize = 0;
            DocuReq.FlatStyle = FlatStyle.Flat;
            DocuReq.Font = new Font("Yu Gothic UI", 20.25F);
            DocuReq.ForeColor = Color.MidnightBlue;
            DocuReq.Location = new Point(36, 651);
            DocuReq.Name = "DocuReq";
            DocuReq.Size = new Size(316, 44);
            DocuReq.TabIndex = 2;
            DocuReq.Text = "DOCUMENT REQUEST";
            DocuReq.UseVisualStyleBackColor = true;
            DocuReq.Click += DocuReq_Click;
            // 
            // MyProfile
            // 
            MyProfile.FlatAppearance.BorderSize = 0;
            MyProfile.FlatStyle = FlatStyle.Flat;
            MyProfile.Font = new Font("Yu Gothic UI", 20.25F);
            MyProfile.Location = new Point(44, 568);
            MyProfile.Name = "MyProfile";
            MyProfile.Size = new Size(177, 42);
            MyProfile.TabIndex = 1;
            MyProfile.Text = "MY PROFILE";
            MyProfile.UseVisualStyleBackColor = true;
            MyProfile.Click += MyProfile_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 387);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(59, 332);
            label1.Name = "label1";
            label1.Size = new Size(377, 37);
            label1.TabIndex = 1;
            label1.Text = "HELLO! SANTOS, NATHANIEL";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(133, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 202);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveBorder;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(607, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(1236, 75);
            panel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(51, 17);
            label2.Name = "label2";
            label2.Size = new Size(439, 43);
            label2.TabIndex = 0;
            label2.Text = "DOCUMENT REQUEST";
            // 
            // baros
            // 
            baros.AutoSize = true;
            baros.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            baros.Location = new Point(607, 48);
            baros.Name = "baros";
            baros.Size = new Size(827, 37);
            baros.TabIndex = 9;
            baros.Text = "BARANGAY ASSISTANCE AND REQUEST OF DOCUMENTS SYSTEM";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.InactiveBorder;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(dataGridView2);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(brgy_id);
            panel4.Location = new Point(607, 236);
            panel4.Name = "panel4";
            panel4.Size = new Size(1236, 927);
            panel4.TabIndex = 8;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.MidnightBlue;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.FromArgb(246, 180, 71);
            dataGridView2.Location = new Point(47, 150);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1143, 770);
            dataGridView2.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.MidnightBlue;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(47, 63);
            button3.Name = "button3";
            button3.Size = new Size(236, 58);
            button3.TabIndex = 3;
            button3.Text = "BARANGAY CERTIFICATE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(354, 63);
            button2.Name = "button2";
            button2.Size = new Size(236, 58);
            button2.TabIndex = 2;
            button2.Text = "BARANGAY INDIGENCY";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(651, 63);
            button1.Name = "button1";
            button1.Size = new Size(236, 58);
            button1.TabIndex = 1;
            button1.Text = "BARANGAY CLEARANCE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // brgy_id
            // 
            brgy_id.BackColor = Color.MidnightBlue;
            brgy_id.ForeColor = SystemColors.ButtonFace;
            brgy_id.Location = new Point(954, 63);
            brgy_id.Name = "brgy_id";
            brgy_id.Size = new Size(236, 58);
            brgy_id.TabIndex = 0;
            brgy_id.Text = "BARANGAY ID";
            brgy_id.UseVisualStyleBackColor = false;
            brgy_id.Click += brgy_id_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MidnightBlue;
            panel5.Location = new Point(607, 137);
            panel5.Name = "panel5";
            panel5.Size = new Size(1236, 33);
            panel5.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackColor = Color.MidnightBlue;
            panel6.Location = new Point(607, 230);
            panel6.Name = "panel6";
            panel6.Size = new Size(1236, 100);
            panel6.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.BackColor = Color.MidnightBlue;
            panel7.Location = new Point(491, 431);
            panel7.Name = "panel7";
            panel7.Size = new Size(1422, 160);
            panel7.TabIndex = 12;
            // 
            // DocumentRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1911, 1118);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(baros);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Name = "DocumentRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DocumentRequest";
            Load += DocumentRequest_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button signout;
        private Button ResAssist;
        private Button DocuReq;
        private Button MyProfile;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label2;
        private Label baros;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private DataGridView dataGridView1;
        private Button brgy_id;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView2;
    }
}