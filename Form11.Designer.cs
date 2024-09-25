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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocuReq));
            label1 = new Label();
            label2 = new Label();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            signUpLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            label1.Location = new Point(469, 75);
            label1.Name = "label1";
            label1.Size = new Size(1067, 86);
            label1.TabIndex = 0;
            label1.Text = "BARANGAY DOCUMENT REQUEST";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            label2.Location = new Point(883, 179);
            label2.Name = "label2";
            label2.Size = new Size(188, 50);
            label2.TabIndex = 1;
            label2.Text = "SERVICES";
            // 
            // button5
            // 
            button5.BackColor = Color.Goldenrod;
            button5.BackgroundImage = Properties.Resources.backbbtn;
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button5.Location = new Point(12, 12);
            button5.Name = "button5";
            button5.Size = new Size(97, 53);
            button5.TabIndex = 2;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            button1.Location = new Point(399, 667);
            button1.Name = "button1";
            button1.Size = new Size(505, 284);
            button1.TabIndex = 3;
            button1.Text = "BARANGAY INDIGENCY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            button2.Location = new Point(1031, 309);
            button2.Name = "button2";
            button2.Size = new Size(505, 284);
            button2.TabIndex = 4;
            button2.Text = "BARANGAY CLEARANCE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(399, 309);
            button3.Name = "button3";
            button3.Size = new Size(505, 284);
            button3.TabIndex = 5;
            button3.Text = "BARANGAY CERTIFICATE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Goldenrod;
            button4.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            button4.Location = new Point(1031, 667);
            button4.Name = "button4";
            button4.Size = new Size(505, 284);
            button4.TabIndex = 6;
            button4.Text = "BARANGAY ID";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // signUpLogo
            // 
            signUpLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(444, 229);
            signUpLogo.Margin = new Padding(0);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(1060, 821);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 144;
            signUpLogo.TabStop = false;
            // 
            // DocuReq
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(signUpLogo);
            Name = "DocuReq";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BARANGAY DOCUMENT REQUEST";
            Load += DocuReq_Load;
            ((System.ComponentModel.ISupportInitialize)signUpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private PictureBox signUpLogo;
    }
}