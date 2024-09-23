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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            Greet = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HBF1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(246, 180, 71);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(HBF1);
            panel1.Controls.Add(button6);
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
            // button6
            // 
            button6.Anchor = AnchorStyles.Left;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("MS UI Gothic", 36F, FontStyle.Bold);
            button6.Location = new Point(3, 876);
            button6.Name = "button6";
            button6.Size = new Size(435, 155);
            button6.TabIndex = 5;
            button6.Text = "Manage\r\nTransaction";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("MS UI Gothic", 36F, FontStyle.Bold);
            button5.Location = new Point(6, 728);
            button5.Name = "button5";
            button5.Size = new Size(431, 97);
            button5.TabIndex = 4;
            button5.Text = "Services";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("MS UI Gothic", 36F, FontStyle.Bold);
            button4.Location = new Point(11, 562);
            button4.Name = "button4";
            button4.Size = new Size(431, 97);
            button4.TabIndex = 3;
            button4.Text = "How it works?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("MS UI Gothic", 36F, FontStyle.Bold);
            button3.Location = new Point(6, 394);
            button3.Name = "button3";
            button3.Size = new Size(431, 97);
            button3.TabIndex = 2;
            button3.Text = "Contact";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("MS UI Gothic", 36F, FontStyle.Bold);
            button2.Location = new Point(6, 238);
            button2.Name = "button2";
            button2.Size = new Size(431, 97);
            button2.TabIndex = 1;
            button2.Text = "About Us";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(246, 180, 71);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MS UI Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(3, 90);
            button1.Name = "button1";
            button1.Size = new Size(431, 97);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(Greet);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(441, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(1468, 1020);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // Greet
            // 
            Greet.Anchor = AnchorStyles.Top;
            Greet.AutoSize = true;
            Greet.BackColor = Color.Transparent;
            Greet.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Greet.Location = new Point(510, 166);
            Greet.Name = "Greet";
            Greet.Size = new Size(462, 72);
            Greet.TabIndex = 4;
            Greet.Text = "Please let us know how we can help you. \r\nBecause here, A helping hand is always \r\nwithin reach.";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("MS UI Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(550, 14);
            label2.Name = "label2";
            label2.Size = new Size(314, 33);
            label2.TabIndex = 3;
            label2.Text = "WELCOME KABARO!";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold);
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Size = new Size(78, 24);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1911, 1118);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BAROS Dashboard";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HBF1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button6;
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
    }
}
