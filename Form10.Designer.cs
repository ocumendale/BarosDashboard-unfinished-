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
            panel2 = new Panel();
            Request = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            FormBas = new Button();
            backReq = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(backReq);
            panel2.Controls.Add(Request);
            panel2.Location = new Point(12, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 74);
            panel2.TabIndex = 3;
            // 
            // Request
            // 
            Request.AutoSize = true;
            Request.Font = new Font("MS UI Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Request.Location = new Point(266, 37);
            Request.Name = "Request";
            Request.Size = new Size(232, 33);
            Request.TabIndex = 0;
            Request.Text = "RESERVATION";
            Request.Click += Request_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(FormBas);
            panel1.Location = new Point(12, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 323);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.Location = new Point(424, 169);
            button3.Name = "button3";
            button3.Size = new Size(136, 69);
            button3.TabIndex = 3;
            button3.Text = "TENT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.Location = new Point(220, 169);
            button2.Name = "button2";
            button2.Size = new Size(136, 69);
            button2.TabIndex = 2;
            button2.Text = "CHAIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.Location = new Point(424, 61);
            button1.Name = "button1";
            button1.Size = new Size(136, 69);
            button1.TabIndex = 1;
            button1.Text = "TABLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormBas
            // 
            FormBas.BackColor = Color.Goldenrod;
            FormBas.Location = new Point(220, 61);
            FormBas.Name = "FormBas";
            FormBas.Size = new Size(136, 69);
            FormBas.TabIndex = 0;
            FormBas.Text = "BASKETBALL COURT";
            FormBas.UseVisualStyleBackColor = false;
            FormBas.Click += reserveCourt_Click;
            // 
            // backReq
            // 
            backReq.BackColor = Color.Goldenrod;
            backReq.Location = new Point(3, 3);
            backReq.Name = "backReq";
            backReq.Size = new Size(85, 42);
            backReq.TabIndex = 4;
            backReq.Text = "Back";
            backReq.UseVisualStyleBackColor = false;
            backReq.Click += backReq_Click;
            // 
            // reserve
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "reserve";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Request";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label Request;
        private Panel panel1;
        private Button FormBas;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button backReq;
    }
}