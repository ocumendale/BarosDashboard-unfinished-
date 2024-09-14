namespace BarosDashboard
{
    partial class DocuReq
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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 24F, FontStyle.Bold);
            label1.Location = new Point(153, 129);
            label1.Name = "label1";
            label1.Size = new Size(528, 33);
            label1.TabIndex = 0;
            label1.Text = "BARANGAY DOCUMENT REQUEST";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold);
            label2.Location = new Point(10, 74);
            label2.Name = "label2";
            label2.Size = new Size(126, 24);
            label2.TabIndex = 1;
            label2.Text = "SERVICES";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 100);
            panel1.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = Color.Goldenrod;
            button5.BackgroundImage = Properties.Resources.backbbtn;
            button5.Font = new Font("MS UI Gothic", 10F, FontStyle.Bold);
            button5.Location = new Point(3, 3);
            button5.Name = "button5";
            button5.Size = new Size(83, 46);
            button5.TabIndex = 2;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.Location = new Point(208, 228);
            button1.Name = "button1";
            button1.Size = new Size(137, 67);
            button1.TabIndex = 3;
            button1.Text = "BARANGAY INDIGENCY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.Location = new Point(460, 228);
            button2.Name = "button2";
            button2.Size = new Size(137, 67);
            button2.TabIndex = 4;
            button2.Text = "BARANGAY CLEARANCE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.Location = new Point(208, 319);
            button3.Name = "button3";
            button3.Size = new Size(137, 67);
            button3.TabIndex = 5;
            button3.Text = "BARANGAY CERTIFICATE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Goldenrod;
            button4.Location = new Point(460, 319);
            button4.Name = "button4";
            button4.Size = new Size(137, 67);
            button4.TabIndex = 6;
            button4.Text = "BARANGAY ID";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // DocuReq
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "DocuReq";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BARANGAY DOCUMENT REQUEST";
            Load += DocuReq_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}