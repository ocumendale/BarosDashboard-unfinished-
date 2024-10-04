namespace BarosDashboard
{
    partial class reserve
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            FormBas = new Button();
            Request = new Label();
            backReq = new Button();
            label2 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(246, 180, 71);
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(1031, 667);
            button3.Name = "button3";
            button3.Size = new Size(505, 284);
            button3.TabIndex = 3;
            button3.Text = "TENT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(246, 180, 71);
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(399, 667);
            button2.Name = "button2";
            button2.Size = new Size(505, 284);
            button2.TabIndex = 2;
            button2.Text = "CHAIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(246, 180, 71);
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1031, 309);
            button1.Name = "button1";
            button1.Size = new Size(505, 284);
            button1.TabIndex = 1;
            button1.Text = "TABLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormBas
            // 
            FormBas.BackColor = Color.FromArgb(246, 180, 71);
            FormBas.FlatAppearance.BorderSize = 0;
            FormBas.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            FormBas.ForeColor = Color.Black;
            FormBas.Location = new Point(399, 309);
            FormBas.Name = "FormBas";
            FormBas.Size = new Size(505, 284);
            FormBas.TabIndex = 0;
            FormBas.Text = "BASKETBALL COURT";
            FormBas.UseVisualStyleBackColor = false;
            FormBas.Click += reserveCourt_Click;
            // 
            // Request
            // 
            Request.AutoSize = true;
            Request.Font = new Font("Lucida Fax", 72F, FontStyle.Bold);
            Request.Location = new Point(581, 81);
            Request.Name = "Request";
            Request.Size = new Size(762, 109);
            Request.TabIndex = 0;
            Request.Text = "RESERVATION";
            Request.Click += Request_Click;
            // 
            // backReq
            // 
            backReq.BackColor = Color.Goldenrod;
            backReq.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            backReq.Location = new Point(12, 12);
            backReq.Name = "backReq";
            backReq.Size = new Size(97, 53);
            backReq.TabIndex = 4;
            backReq.Text = "Back";
            backReq.UseVisualStyleBackColor = false;
            backReq.Click += backReq_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 27.75F, FontStyle.Bold);
            label2.Location = new Point(875, 213);
            label2.Name = "label2";
            label2.Size = new Size(202, 43);
            label2.TabIndex = 8;
            label2.Text = "SERVICES";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(431, 337);
            panel2.Name = "panel2";
            panel2.Size = new Size(494, 281);
            panel2.TabIndex = 109;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Location = new Point(1061, 336);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 281);
            panel1.TabIndex = 110;
            // 
            // reserve
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(Request);
            Controls.Add(button2);
            Controls.Add(backReq);
            Controls.Add(button1);
            Controls.Add(FormBas);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "reserve";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation";
            Load += reserve_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button FormBas;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label Request;
        private Button backReq;
        private Label label2;
        private Panel panel2;
        private Panel panel1;
    }
}