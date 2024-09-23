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
            panel3 = new Panel();
            AboutUs = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            HBF2 = new PictureBox();
            panel1 = new Panel();
            signUpLogo = new PictureBox();
            label1 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HBF2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(AboutUs);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(-96, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1453, 69);
            panel3.TabIndex = 5;
            // 
            // AboutUs
            // 
            AboutUs.Anchor = AnchorStyles.Top;
            AboutUs.AutoSize = true;
            AboutUs.Font = new Font("MS UI Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AboutUs.Location = new Point(658, 20);
            AboutUs.Name = "AboutUs";
            AboutUs.Size = new Size(169, 37);
            AboutUs.TabIndex = 2;
            AboutUs.Text = "About Us";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(246, 180, 71);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MS UI Gothic", 36F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(3, -94);
            button1.Name = "button1";
            button1.Size = new Size(431, 97);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("MS UI Gothic", 36F, FontStyle.Bold);
            button2.Location = new Point(7, 42);
            button2.Name = "button2";
            button2.Size = new Size(431, 97);
            button2.TabIndex = 1;
            button2.Text = "About Us";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("MS UI Gothic", 36F, FontStyle.Bold);
            button3.Location = new Point(3, 195);
            button3.Name = "button3";
            button3.Size = new Size(431, 97);
            button3.TabIndex = 2;
            button3.Text = "Contact";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("MS UI Gothic", 36F, FontStyle.Bold);
            button4.Location = new Point(3, 343);
            button4.Name = "button4";
            button4.Size = new Size(431, 97);
            button4.TabIndex = 3;
            button4.Text = "How it works?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("MS UI Gothic", 36F, FontStyle.Bold);
            button5.Location = new Point(7, 515);
            button5.Name = "button5";
            button5.Size = new Size(431, 97);
            button5.TabIndex = 4;
            button5.Text = "Services";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Left;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("MS UI Gothic", 36F, FontStyle.Bold);
            button6.Location = new Point(3, 688);
            button6.Name = "button6";
            button6.Size = new Size(435, 155);
            button6.TabIndex = 5;
            button6.Text = "Manage\r\nTransaction";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // HBF2
            // 
            HBF2.BackColor = Color.Transparent;
            HBF2.Image = (Image)resources.GetObject("HBF2.Image");
            HBF2.Location = new Point(11, 10);
            HBF2.Name = "HBF2";
            HBF2.Size = new Size(46, 25);
            HBF2.SizeMode = PictureBoxSizeMode.Zoom;
            HBF2.TabIndex = 7;
            HBF2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(HBF2);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 746);
            panel1.TabIndex = 3;
            // 
            // signUpLogo
            // 
            signUpLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(441, 76);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(916, 671);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 87;
            signUpLogo.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS UI Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 243);
            label1.Name = "label1";
            label1.Size = new Size(1251, 555);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click_1;
            // 
            // AboutUsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1370, 749);
            Controls.Add(label1);
            Controls.Add(signUpLogo);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "AboutUsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About Us";
            Load += AboutUsForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HBF2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)signUpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Label AboutUs;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox HBF2;
        private Panel panel1;
        private PictureBox signUpLogo;
        private Label label1;
    }
}