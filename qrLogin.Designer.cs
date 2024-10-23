namespace BarosDashboard
{
    partial class qrLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qrLogin));
            label1 = new Label();
            panel4 = new Panel();
            signUpLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 27.75F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(445, 303);
            label1.Name = "label1";
            label1.Size = new Size(1035, 43);
            label1.TabIndex = 1;
            label1.Text = "SCAN THE QR CODE USING THE SCANNER TO LOGIN\r\n";
            // 
            // panel4
            // 
            panel4.BackColor = Color.MidnightBlue;
            panel4.Location = new Point(517, 376);
            panel4.Name = "panel4";
            panel4.Size = new Size(882, 10);
            panel4.TabIndex = 136;
            // 
            // signUpLogo
            // 
            signUpLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(660, 435);
            signUpLogo.Margin = new Padding(0);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(630, 488);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 139;
            signUpLogo.TabStop = false;
            // 
            // qrLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(signUpLogo);
            Controls.Add(panel4);
            Controls.Add(label1);
            Name = "qrLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "qrLogin";
            Load += qrLogin_Load;
            KeyPress += qrLogin_KeyPress;
            ((System.ComponentModel.ISupportInitialize)signUpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel4;
        private PictureBox signUpLogo;
    }
}