namespace BarosDashboard
{
    partial class ResidentsComplaints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentsComplaints));
            panel4 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            Events = new Button();
            Announcements = new Button();
            EmergencyRes = new Button();
            ResComplaints = new Button();
            ResAssist = new Button();
            DocuReq = new Button();
            MyProfile = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(262, 149);
            panel4.Name = "panel4";
            panel4.Size = new Size(588, 442);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(245, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(617, 53);
            panel3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(59, 17);
            label2.Name = "label2";
            label2.Size = new Size(249, 19);
            label2.TabIndex = 0;
            label2.Text = "RESIDENTS' COMPLAINTS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 180, 71);
            panel1.Controls.Add(Events);
            panel1.Controls.Add(Announcements);
            panel1.Controls.Add(EmergencyRes);
            panel1.Controls.Add(ResComplaints);
            panel1.Controls.Add(ResAssist);
            panel1.Controls.Add(DocuReq);
            panel1.Controls.Add(MyProfile);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 591);
            panel1.TabIndex = 3;
            // 
            // Events
            // 
            Events.FlatAppearance.BorderSize = 0;
            Events.FlatStyle = FlatStyle.Flat;
            Events.Font = new Font("Century", 11F, FontStyle.Bold);
            Events.Location = new Point(58, 499);
            Events.Name = "Events";
            Events.Size = new Size(114, 23);
            Events.TabIndex = 7;
            Events.Text = "EVENTS";
            Events.UseVisualStyleBackColor = true;
            Events.Click += Events_Click;
            // 
            // Announcements
            // 
            Announcements.FlatAppearance.BorderSize = 0;
            Announcements.FlatStyle = FlatStyle.Flat;
            Announcements.Font = new Font("Century", 11F, FontStyle.Bold);
            Announcements.Location = new Point(35, 452);
            Announcements.Name = "Announcements";
            Announcements.Size = new Size(170, 24);
            Announcements.TabIndex = 6;
            Announcements.Text = "ANNOUNCEMENTS";
            Announcements.UseVisualStyleBackColor = true;
            Announcements.Click += Announcements_Click;
            // 
            // EmergencyRes
            // 
            EmergencyRes.FlatAppearance.BorderSize = 0;
            EmergencyRes.FlatStyle = FlatStyle.Flat;
            EmergencyRes.Font = new Font("Century", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmergencyRes.Location = new Point(3, 404);
            EmergencyRes.Name = "EmergencyRes";
            EmergencyRes.Size = new Size(238, 27);
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
            ResComplaints.Location = new Point(1, 354);
            ResComplaints.Name = "ResComplaints";
            ResComplaints.Size = new Size(240, 24);
            ResComplaints.TabIndex = 4;
            ResComplaints.Text = "RESIDENTS' COMPLAINTS";
            ResComplaints.TextAlign = ContentAlignment.MiddleLeft;
            ResComplaints.UseVisualStyleBackColor = true;
            // 
            // ResAssist
            // 
            ResAssist.FlatAppearance.BorderSize = 0;
            ResAssist.FlatStyle = FlatStyle.Flat;
            ResAssist.Font = new Font("Century", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResAssist.Location = new Point(6, 304);
            ResAssist.Name = "ResAssist";
            ResAssist.Size = new Size(235, 25);
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
            DocuReq.Location = new Point(29, 252);
            DocuReq.Name = "DocuReq";
            DocuReq.Size = new Size(207, 28);
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
            MyProfile.Location = new Point(58, 207);
            MyProfile.Name = "MyProfile";
            MyProfile.Size = new Size(147, 28);
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
            panel2.Size = new Size(244, 201);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(3, 176);
            label1.Name = "label1";
            label1.Size = new Size(233, 16);
            label1.TabIndex = 1;
            label1.Text = "HELLO! SANTOS, NATHANIEL";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(51, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 122);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ResidentsComplaints
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 591);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "ResidentsComplaints";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResidentsComplaints";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel3;
        private Label label2;
        private Panel panel1;
        private Button Events;
        private Button Announcements;
        private Button EmergencyRes;
        private Button ResComplaints;
        private Button ResAssist;
        private Button DocuReq;
        private Button MyProfile;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}