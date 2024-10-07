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
            signout = new Button();
            ResAssist = new Button();
            DocuReq = new Button();
            MyProfile = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            baros = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            reg_btn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 180, 71);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(reg_btn);
            panel1.Controls.Add(signout);
            panel1.Controls.Add(ResAssist);
            panel1.Controls.Add(DocuReq);
            panel1.Controls.Add(MyProfile);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 1199);
            panel1.TabIndex = 0;
            // 
            // signout
            // 
            signout.FlatAppearance.BorderSize = 0;
            signout.FlatStyle = FlatStyle.Flat;
            signout.Font = new Font("Yu Gothic UI", 20.25F);
            signout.Location = new Point(44, 895);
            signout.Name = "signout";
            signout.RightToLeft = RightToLeft.Yes;
            signout.Size = new Size(152, 51);
            signout.TabIndex = 6;
            signout.Text = "SIGN OUT";
            signout.TextAlign = ContentAlignment.MiddleLeft;
            signout.UseVisualStyleBackColor = true;
            signout.Click += signout_Click;
            // 
            // ResAssist
            // 
            ResAssist.FlatAppearance.BorderSize = 0;
            ResAssist.FlatStyle = FlatStyle.Flat;
            ResAssist.Font = new Font("Yu Gothic UI", 20.25F);
            ResAssist.Location = new Point(49, 733);
            ResAssist.Name = "ResAssist";
            ResAssist.Size = new Size(359, 56);
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
            DocuReq.Location = new Point(49, 651);
            DocuReq.Name = "DocuReq";
            DocuReq.Size = new Size(296, 50);
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
            MyProfile.ForeColor = Color.MidnightBlue;
            MyProfile.Location = new Point(44, 568);
            MyProfile.Name = "MyProfile";
            MyProfile.Size = new Size(186, 56);
            MyProfile.TabIndex = 1;
            MyProfile.Text = "MY PROFILE";
            MyProfile.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
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
            panel3.Location = new Point(611, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(1236, 75);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(51, 17);
            label2.Name = "label2";
            label2.Size = new Size(254, 43);
            label2.TabIndex = 0;
            label2.Text = "MY PROFILE";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.InactiveBorder;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Location = new Point(611, 263);
            panel4.Name = "panel4";
            panel4.Size = new Size(1236, 852);
            panel4.TabIndex = 2;
            // 
            // baros
            // 
            baros.AutoSize = true;
            baros.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            baros.Location = new Point(611, 75);
            baros.Name = "baros";
            baros.Size = new Size(827, 37);
            baros.TabIndex = 3;
            baros.Text = "BARANGAY ASSISTANCE AND REQUEST OF DOCUMENTS SYSTEM";
            // 
            // panel5
            // 
            panel5.BackColor = Color.MidnightBlue;
            panel5.Location = new Point(611, 164);
            panel5.Name = "panel5";
            panel5.Size = new Size(1236, 33);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.MidnightBlue;
            panel6.Location = new Point(611, 257);
            panel6.Name = "panel6";
            panel6.Size = new Size(1236, 33);
            panel6.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.BackColor = Color.MidnightBlue;
            panel7.Location = new Point(495, 458);
            panel7.Name = "panel7";
            panel7.Size = new Size(1422, 93);
            panel7.TabIndex = 6;
            // 
            // reg_btn
            // 
            reg_btn.FlatAppearance.BorderSize = 0;
            reg_btn.FlatStyle = FlatStyle.Flat;
            reg_btn.Font = new Font("Yu Gothic UI", 20.25F);
            reg_btn.Location = new Point(50, 809);
            reg_btn.Name = "reg_btn";
            reg_btn.Size = new Size(359, 56);
            reg_btn.TabIndex = 7;
            reg_btn.Text = "REGISTRATION";
            reg_btn.TextAlign = ContentAlignment.MiddleLeft;
            reg_btn.UseVisualStyleBackColor = true;
            reg_btn.Click += reg_btn_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1911, 1118);
            Controls.Add(panel3);
            Controls.Add(baros);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel7);
            ForeColor = SystemColors.ControlText;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Button ResAssist;
        private Button DocuReq;
        private Button MyProfile;
        private Button signout;
        private Label baros;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Button reg_btn;
    }
}