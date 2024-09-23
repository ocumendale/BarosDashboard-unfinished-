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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reserve));
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            FormBas = new Button();
            Request = new Label();
            backReq = new Button();
            label2 = new Label();
            signUpLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.Font = new Font("Segoe UI", 26.25F);
            button3.Location = new Point(1148, 750);
            button3.Name = "button3";
            button3.Size = new Size(505, 284);
            button3.TabIndex = 3;
            button3.Text = "TENT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.Font = new Font("Segoe UI", 26.25F);
            button2.Location = new Point(258, 750);
            button2.Name = "button2";
            button2.Size = new Size(505, 284);
            button2.TabIndex = 2;
            button2.Text = "CHAIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.Font = new Font("Segoe UI", 26.25F);
            button1.Location = new Point(1148, 331);
            button1.Name = "button1";
            button1.Size = new Size(505, 284);
            button1.TabIndex = 1;
            button1.Text = "TABLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormBas
            // 
            FormBas.BackColor = Color.Goldenrod;
            FormBas.Font = new Font("Segoe UI", 26.25F);
            FormBas.Location = new Point(258, 331);
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
            Request.Font = new Font("MS UI Gothic", 48F, FontStyle.Bold);
            Request.Location = new Point(746, 85);
            Request.Name = "Request";
            Request.Size = new Size(451, 64);
            Request.TabIndex = 0;
            Request.Text = "RESERVATION";
            Request.Click += Request_Click;
            // 
            // backReq
            // 
            backReq.BackColor = Color.Goldenrod;
            backReq.Location = new Point(12, 12);
            backReq.Name = "backReq";
            backReq.Size = new Size(85, 42);
            backReq.TabIndex = 4;
            backReq.Text = "Back";
            backReq.UseVisualStyleBackColor = false;
            backReq.Click += backReq_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(864, 228);
            label2.Name = "label2";
            label2.Size = new Size(191, 37);
            label2.TabIndex = 8;
            label2.Text = "SERVICES";
            // 
            // signUpLogo
            // 
            signUpLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(375, 4);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(1161, 1110);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 86;
            signUpLogo.TabStop = false;
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
            Controls.Add(signUpLogo);
            Name = "reserve";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation";
            Load += reserve_Load;
            ((System.ComponentModel.ISupportInitialize)signUpLogo).EndInit();
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
        private PictureBox signUpLogo;
    }
}