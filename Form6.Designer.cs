namespace BarosDashboard
{
    partial class ManageTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTransaction));
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button8 = new Button();
            button7 = new Button();
            request = new Label();
            reservation = new Label();
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
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            label1.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold);
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Size = new Size(284, 24);
            label1.TabIndex = 2;
            label1.Text = "MANAGE TRANSACTION";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(request);
            panel2.Controls.Add(reservation);
            panel2.Location = new Point(210, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 312);
            panel2.TabIndex = 4;
            // 
            // button8
            // 
            button8.BackColor = Color.Beige;
            button8.Location = new Point(382, 136);
            button8.Name = "button8";
            button8.Size = new Size(142, 35);
            button8.TabIndex = 3;
            button8.Text = "click to view!";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Beige;
            button7.Location = new Point(54, 136);
            button7.Name = "button7";
            button7.Size = new Size(142, 35);
            button7.TabIndex = 2;
            button7.Text = "click to view!";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // request
            // 
            request.AutoSize = true;
            request.BackColor = Color.Beige;
            request.Font = new Font("MS UI Gothic", 22F, FontStyle.Bold);
            request.Location = new Point(382, 73);
            request.Name = "request";
            request.Size = new Size(124, 30);
            request.TabIndex = 1;
            request.Text = "Request";
            // 
            // reservation
            // 
            reservation.AutoSize = true;
            reservation.BackColor = Color.Beige;
            reservation.Font = new Font("MS UI Gothic", 22F, FontStyle.Bold);
            reservation.Location = new Point(39, 73);
            reservation.Name = "reservation";
            reservation.Size = new Size(172, 30);
            reservation.TabIndex = 0;
            reservation.Text = "Reservation";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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
            button6.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold);
            button6.Location = new Point(23, 375);
            button6.Name = "button6";
            button6.Size = new Size(165, 62);
            button6.TabIndex = 5;
            button6.Text = "Manage\r\nTransaction";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
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
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold);
            button4.Location = new Point(23, 256);
            button4.Name = "button4";
            button4.Size = new Size(176, 40);
            button4.TabIndex = 3;
            button4.Text = "How it works?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
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
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold);
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
            button1.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(23, 77);
            button1.Name = "button1";
            button1.Size = new Size(165, 38);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ManageTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManageTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Transaction";
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
        private Label reservation;
        private Label request;
        private Button button8;
        private Button button7;
    }
}