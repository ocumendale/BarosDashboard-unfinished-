namespace BarosDashboard
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel1 = new Panel();
            EmergencyRes = new Button();
            ResComplaints = new Button();
            ResAssist = new Button();
            DocuReq = new Button();
            MyProfile = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 180, 71);
            panel1.Controls.Add(EmergencyRes);
            panel1.Controls.Add(ResComplaints);
            panel1.Controls.Add(ResAssist);
            panel1.Controls.Add(DocuReq);
            panel1.Controls.Add(MyProfile);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 788);
            panel1.TabIndex = 0;
            // 
            // EmergencyRes
            // 
            EmergencyRes.FlatAppearance.BorderSize = 0;
            EmergencyRes.FlatStyle = FlatStyle.Flat;
            EmergencyRes.Font = new Font("Century", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmergencyRes.Location = new Point(0, 632);
            EmergencyRes.Margin = new Padding(3, 4, 3, 4);
            EmergencyRes.Name = "EmergencyRes";
            EmergencyRes.Size = new Size(272, 36);
            EmergencyRes.TabIndex = 5;
            EmergencyRes.Text = "EMERGENCY RESPONSES";
            EmergencyRes.TextAlign = ContentAlignment.MiddleLeft;
            EmergencyRes.UseVisualStyleBackColor = true;
            EmergencyRes.Click += EmergencyRes_Click;
            // 
            // ResComplaints
            // 
            ResComplaints.FlatAppearance.BorderSize = 0;
            ResComplaints.FlatStyle = FlatStyle.Flat;
            ResComplaints.Font = new Font("Century", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResComplaints.Location = new Point(2, 552);
            ResComplaints.Margin = new Padding(3, 4, 3, 4);
            ResComplaints.Name = "ResComplaints";
            ResComplaints.Size = new Size(274, 32);
            ResComplaints.TabIndex = 4;
            ResComplaints.Text = "RESIDENTS' COMPLAINTS";
            ResComplaints.TextAlign = ContentAlignment.MiddleLeft;
            ResComplaints.UseVisualStyleBackColor = true;
            ResComplaints.Click += ResComplaints_Click;
            // 
            // ResAssist
            // 
            ResAssist.FlatAppearance.BorderSize = 0;
            ResAssist.FlatStyle = FlatStyle.Flat;
            ResAssist.Font = new Font("Century", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResAssist.Location = new Point(-2, 469);
            ResAssist.Margin = new Padding(3, 4, 3, 4);
            ResAssist.Name = "ResAssist";
            ResAssist.Size = new Size(294, 33);
            ResAssist.TabIndex = 3;
            ResAssist.Text = "RESIDENTS' ASSISTANCE";
            ResAssist.TextAlign = ContentAlignment.MiddleLeft;
            ResAssist.UseVisualStyleBackColor = true;
            ResAssist.Click += ResAssist_Click;
            // 
            // DocuReq
            // 
            DocuReq.FlatAppearance.BorderSize = 0;
            DocuReq.FlatStyle = FlatStyle.Flat;
            DocuReq.Font = new Font("Century", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DocuReq.Location = new Point(3, 374);
            DocuReq.Margin = new Padding(3, 4, 3, 4);
            DocuReq.Name = "DocuReq";
            DocuReq.Size = new Size(145, 37);
            DocuReq.TabIndex = 2;
            DocuReq.Text = "DOCUMENT REQUEST";
            DocuReq.UseVisualStyleBackColor = true;
            DocuReq.Click += DocuReq_Click;
            // 
            // MyProfile
            // 
            MyProfile.FlatAppearance.BorderSize = 0;
            MyProfile.FlatStyle = FlatStyle.Flat;
            MyProfile.Font = new Font("Century", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MyProfile.Location = new Point(3, 316);
            MyProfile.Margin = new Padding(3, 4, 3, 4);
            MyProfile.Name = "MyProfile";
            MyProfile.Size = new Size(159, 37);
            MyProfile.TabIndex = 1;
            MyProfile.Text = "MY PROFILE";
            MyProfile.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 268);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(-2, 235);
            label1.Name = "label1";
            label1.Size = new Size(294, 21);
            label1.TabIndex = 1;
            label1.Text = "HELLO! SANTOS, NATHANIEL";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(58, 37);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 163);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(280, 84);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(705, 70);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(67, 23);
            label2.Name = "label2";
            label2.Size = new Size(152, 24);
            label2.TabIndex = 0;
            label2.Text = "MY PROFILE";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(299, 200);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(672, 589);
            panel4.TabIndex = 2;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 788);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Button EmergencyRes;
        private Button ResComplaints;
        private Button ResAssist;
        private Button DocuReq;
        private Button MyProfile;
    }
}