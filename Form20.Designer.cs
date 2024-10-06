namespace BarosDashboard
{
    partial class Form20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form20));
            label1 = new Label();
            signUpLogo = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Lucida Fax", 72F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(246, 180, 71);
            label1.Location = new Point(319, 202);
            label1.Name = "label1";
            label1.Size = new Size(1380, 109);
            label1.TabIndex = 0;
            label1.Text = "TRANSACTION SUCESSFUL";
            // 
            // signUpLogo
            // 
            signUpLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(574, 355);
            signUpLogo.Margin = new Padding(0);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(800, 592);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 106;
            signUpLogo.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Fax", 48F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(246, 180, 71);
            button1.Location = new Point(444, 522);
            button1.Name = "button1";
            button1.Size = new Size(451, 182);
            button1.TabIndex = 107;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Lucida Fax", 48F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(246, 180, 71);
            button2.Location = new Point(1026, 522);
            button2.Name = "button2";
            button2.Size = new Size(451, 182);
            button2.TabIndex = 108;
            button2.Text = "BACK TO MENU";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form20
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(signUpLogo);
            Name = "Form20";
            Text = "Form20";
            Load += Form20_Load;
            ((System.ComponentModel.ISupportInitialize)signUpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox signUpLogo;
        private Button button1;
        private Button button2;
    }
}