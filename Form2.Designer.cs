﻿namespace BarosDashboard
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
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            HBF2 = new PictureBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HBF2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(AboutUs);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(210, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(590, 69);
            panel3.TabIndex = 5;
            // 
            // AboutUs
            // 
            AboutUs.Anchor = AnchorStyles.Top;
            AboutUs.AutoSize = true;
            AboutUs.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold);
            AboutUs.Location = new Point(3, 37);
            AboutUs.Name = "AboutUs";
            AboutUs.Size = new Size(110, 24);
            AboutUs.TabIndex = 2;
            AboutUs.Text = "About Us";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(210, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 312);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 1);
            label1.Name = "label1";
            label1.Size = new Size(584, 240);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click_1;
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
            panel1.Size = new Size(204, 449);
            panel1.TabIndex = 3;
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
            // button6
            // 
            button6.Anchor = AnchorStyles.Left;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold);
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
            button5.Anchor = AnchorStyles.Left;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold);
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
            button4.Anchor = AnchorStyles.Left;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold);
            button4.Location = new Point(23, 256);
            button4.Name = "button4";
            button4.Size = new Size(165, 38);
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
            button3.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold);
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
            button2.Anchor = AnchorStyles.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold);
            button2.Location = new Point(23, 136);
            button2.Name = "button2";
            button2.Size = new Size(165, 38);
            button2.TabIndex = 1;
            button2.Text = "About Us";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(246, 180, 71);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MS UI Gothic", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(23, 77);
            button1.Name = "button1";
            button1.Size = new Size(165, 38);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AboutUsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(813, 452);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AboutUsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About Us";
            Load += AboutUsForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HBF2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label AboutUs;
        private Panel panel2;
        private Panel panel1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private PictureBox HBF2;
    }
}