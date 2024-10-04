namespace BarosDashboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            HBF1 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Greet = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            signUpLogo = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HBF1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(246, 180, 71);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(HBF1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 1115);
            panel1.TabIndex = 0;
            // 
            // HBF1
            // 
            HBF1.BackColor = Color.Transparent;
            HBF1.Image = (Image)resources.GetObject("HBF1.Image");
            HBF1.Location = new Point(11, 10);
            HBF1.Name = "HBF1";
            HBF1.Size = new Size(46, 25);
            HBF1.SizeMode = PictureBoxSizeMode.Zoom;
            HBF1.TabIndex = 6;
            HBF1.TabStop = false;
            HBF1.Click += pictureBox1_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left;
            button5.BackColor = Color.FromArgb(246, 180, 71);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Lucida Fax", 36F, FontStyle.Bold);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(3, 906);
            button5.Name = "button5";
            button5.Size = new Size(438, 97);
            button5.TabIndex = 4;
            button5.Text = "Services";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.BackColor = Color.FromArgb(246, 180, 71);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Lucida Fax", 36F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(3, 702);
            button4.Name = "button4";
            button4.Size = new Size(438, 97);
            button4.TabIndex = 3;
            button4.Text = "How it works?";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.BackColor = Color.FromArgb(246, 180, 71);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Lucida Fax", 36F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(3, 497);
            button3.Name = "button3";
            button3.Size = new Size(438, 97);
            button3.TabIndex = 2;
            button3.Text = "Contact";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.BackColor = Color.FromArgb(246, 180, 71);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Lucida Fax", 36F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(6, 291);
            button2.Name = "button2";
            button2.Size = new Size(435, 97);
            button2.TabIndex = 1;
            button2.Text = "About Us";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(246, 180, 71);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Fax", 36F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(3, 90);
            button1.Name = "button1";
            button1.Size = new Size(438, 97);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Greet
            // 
            Greet.Anchor = AnchorStyles.Top;
            Greet.AutoSize = true;
            Greet.BackColor = Color.MidnightBlue;
            Greet.Font = new Font("Lucida Fax", 36F, FontStyle.Bold);
            Greet.ForeColor = Color.FromArgb(246, 180, 71);
            Greet.Location = new Point(649, 536);
            Greet.Name = "Greet";
            Greet.Size = new Size(1074, 165);
            Greet.TabIndex = 4;
            Greet.Text = "Please let us know how we can help you. \r\nBecause here, A helping hand is always \r\nwithin reach.";
            Greet.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.MidnightBlue;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Lucida Fax", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(246, 180, 71);
            label2.Location = new Point(832, 442);
            label2.Name = "label2";
            label2.Size = new Size(697, 74);
            label2.TabIndex = 3;
            label2.Text = "WELCOME KABARO!";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Size = new Size(108, 33);
            label1.TabIndex = 2;
            label1.Text = "HOME";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(label1);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(442, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1440, 84);
            panel3.TabIndex = 2;
            // 
            // signUpLogo
            // 
            signUpLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(780, 218);
            signUpLogo.Margin = new Padding(0);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(799, 660);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 131;
            signUpLogo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1911, 1118);
            Controls.Add(Greet);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(signUpLogo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BAROS Dashboard";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HBF1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Label Greet;
        private PictureBox HBF1;
        private PictureBox signUpLogo;
    }
}
