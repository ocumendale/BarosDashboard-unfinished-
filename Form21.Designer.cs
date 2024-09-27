namespace BarosDashboard
{
    partial class submitId
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(97, 53);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(576, 90);
            label1.Name = "label1";
            label1.Size = new Size(705, 128);
            label1.TabIndex = 149;
            label1.Text = "BARANGAY ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(673, 218);
            label2.Name = "label2";
            label2.Size = new Size(516, 30);
            label2.TabIndex = 148;
            label2.Text = "FILL OUT THIS FORM FOR RESERVATION OF FORM";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(556, 332);
            label3.Name = "label3";
            label3.Size = new Size(752, 47);
            label3.TabIndex = 150;
            label3.Text = "CONTACT PERSON IN CASE OF EMERGENCY";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkGoldenrod;
            textBox1.Font = new Font("Segoe UI", 26.25F);
            textBox1.Location = new Point(627, 468);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(592, 54);
            textBox1.TabIndex = 151;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label4.Location = new Point(621, 425);
            label4.Name = "label4";
            label4.Size = new Size(177, 40);
            label4.TabIndex = 152;
            label4.Text = "FULL NAME";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label5.Location = new Point(627, 625);
            label5.Name = "label5";
            label5.Size = new Size(150, 40);
            label5.TabIndex = 153;
            label5.Text = "CONTACT";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkGoldenrod;
            textBox2.Font = new Font("Segoe UI", 26.25F);
            textBox2.Location = new Point(627, 668);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(592, 54);
            textBox2.TabIndex = 154;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 25, 56);
            button2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(246, 180, 71);
            button2.Location = new Point(812, 814);
            button2.Name = "button2";
            button2.Size = new Size(239, 74);
            button2.TabIndex = 155;
            button2.Text = "SUBMIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // submitId
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "submitId";
            Text = "Form21";
            Load += submitId_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Button button2;
    }
}