namespace BarosDashboard
{
    partial class AboutUsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUsForm));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            AboutUs = new Label();
            panel3 = new Panel();
            label1 = new Label();
            signUpLogo = new PictureBox();
            panel2 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(246, 180, 71);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(32, 248);
            button1.Name = "button1";
            button1.Size = new Size(395, 97);
            button1.TabIndex = 0;
            button1.Text = "HOME";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            button2.ForeColor = Color.MidnightBlue;
            button2.Location = new Point(32, 351);
            button2.Name = "button2";
            button2.Size = new Size(395, 97);
            button2.TabIndex = 1;
            button2.Text = "ABOUT US";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            button3.Location = new Point(33, 454);
            button3.Name = "button3";
            button3.Size = new Size(395, 97);
            button3.TabIndex = 2;
            button3.Text = "CONTACT";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            button4.Location = new Point(32, 557);
            button4.Name = "button4";
            button4.Size = new Size(395, 97);
            button4.TabIndex = 3;
            button4.Text = "HOW IT WORKS?";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            button5.Location = new Point(32, 660);
            button5.Name = "button5";
            button5.Size = new Size(395, 97);
            button5.TabIndex = 4;
            button5.Text = "SERVICES";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 1115);
            panel1.TabIndex = 3;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Left;
            button7.BackColor = Color.FromArgb(246, 180, 71);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            button7.Location = new Point(32, 763);
            button7.Name = "button7";
            button7.Size = new Size(395, 97);
            button7.TabIndex = 9;
            button7.Text = "MANAGE TRANSACTION";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(246, 180, 71);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            button6.Location = new Point(32, 866);
            button6.Name = "button6";
            button6.Size = new Size(395, 97);
            button6.TabIndex = 8;
            button6.Text = "LOGOUT";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // AboutUs
            // 
            AboutUs.AutoSize = true;
            AboutUs.Font = new Font("Lucida Fax", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AboutUs.ForeColor = Color.MidnightBlue;
            AboutUs.Location = new Point(66, 54);
            AboutUs.Name = "AboutUs";
            AboutUs.Size = new Size(218, 43);
            AboutUs.TabIndex = 2;
            AboutUs.Text = "ABOUT US";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(AboutUs);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(442, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1479, 102);
            panel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Fax", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(710, 228);
            label1.Name = "label1";
            label1.Size = new Size(932, 405);
            label1.TabIndex = 6;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // signUpLogo
            // 
            signUpLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(934, 663);
            signUpLogo.Margin = new Padding(0);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(475, 400);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 132;
            signUpLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(866, 639);
            panel2.Name = "panel2";
            panel2.Size = new Size(597, 10);
            panel2.TabIndex = 133;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MidnightBlue;
            panel5.Location = new Point(435, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(13, 1198);
            panel5.TabIndex = 136;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MidnightBlue;
            panel4.Location = new Point(441, 96);
            panel4.Name = "panel4";
            panel4.Size = new Size(1519, 13);
            panel4.TabIndex = 135;
            // 
            // AboutUsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(signUpLogo);
            Controls.Add(panel4);
            Name = "AboutUsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About Us";
            Load += AboutUsForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel1;
        private Label AboutUs;
        private Panel panel3;
        private Label label1;
        private PictureBox signUpLogo;
        private Button button6;
        private Button button7;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
    }
}