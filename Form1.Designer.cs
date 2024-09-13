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
            pictureBox1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 180, 71);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 449);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("MS UI Gothic", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(23, 375);
            button6.Name = "button6";
            button6.Size = new Size(165, 62);
            button6.TabIndex = 5;
            button6.Text = "Manage\r\nTransaction";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(23, 317);
            button5.Name = "button5";
            button5.Size = new Size(165, 38);
            button5.TabIndex = 4;
            button5.Text = "Services";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(23, 255);
            button4.Name = "button4";
            button4.Size = new Size(180, 45);
            button4.TabIndex = 3;
            button4.Text = "How it works?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(23, 198);
            button3.Name = "button3";
            button3.Size = new Size(165, 38);
            button3.TabIndex = 2;
            button3.Text = "Contact";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(23, 136);
            button2.Name = "button2";
            button2.Size = new Size(165, 38);
            button2.TabIndex = 1;
            button2.Text = "About Us";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(246, 180, 71);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(23, 77);
            button1.Name = "button1";
            button1.Size = new Size(165, 38);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(Greet);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(210, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 312);
            panel2.TabIndex = 1;
            // 
            // Greet
            // 
            Greet.AutoSize = true;
            Greet.BackColor = Color.Transparent;
            Greet.Font = new Font("MS UI Gothic", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Greet.Location = new Point(50, 243);
            Greet.Name = "Greet";
            Greet.Size = new Size(457, 69);
            Greet.TabIndex = 4;
            Greet.Text = "Please let us know how we can help you. \r\nBecause here, A helping hand is always \r\nwithin reach.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("MS UI Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(111, 14);
            label2.Name = "label2";
            label2.Size = new Size(314, 33);
            label2.TabIndex = 3;
            label2.Text = "WELCOME KABARO!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Size = new Size(78, 24);
            label1.TabIndex = 2;
            label1.Text = "HOME";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(210, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(590, 69);
            panel3.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(829, 491);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BAROS Dashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}
