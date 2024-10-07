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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 40F, FontStyle.Bold);
            label1.Location = new Point(225, 208);
            label1.Name = "label1";
            label1.Size = new Size(1444, 61);
            label1.TabIndex = 1;
            label1.Text = "Scan the QR Code using our USB Scanner to Login\r\n";
            // 
            // qrLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(label1);
            Name = "qrLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "qrLogin";
            Load += qrLogin_Load;
            KeyPress += qrLogin_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}