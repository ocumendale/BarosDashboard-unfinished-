namespace BarosDashboard
{
    partial class HowItWorks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowItWorks));
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(210, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(590, 69);
            panel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 2;
            label1.Text = "HOW IT WORKS?";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(210, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 312);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 36);
            label2.Name = "label2";
            label2.Size = new Size(422, 240);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
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
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            button5.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            button4.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(23, 256);
            button4.Name = "button4";
            button4.Size = new Size(165, 38);
            button4.TabIndex = 3;
            button4.Text = "How it works?";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            button2.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            button1.BackColor = Color.DarkGoldenrod;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(23, 77);
            button1.Name = "button1";
            button1.Size = new Size(165, 38);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HowItWorks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HowItWorks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "How It Works";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
    }
}