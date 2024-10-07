namespace BarosDashboard
{
    partial class Scanner
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
            label2 = new Label();
            btnToMlogin = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 50F, FontStyle.Bold);
            label2.Location = new Point(296, 139);
            label2.Name = "label2";
            label2.Size = new Size(1360, 67);
            label2.TabIndex = 1;
            label2.Text = "Please Scan your QR Code using our Scanner";
            label2.Click += label2_Click;
            // 
            // btnToMlogin
            // 
            btnToMlogin.BackColor = Color.MidnightBlue;
            btnToMlogin.FlatAppearance.BorderSize = 0;
            btnToMlogin.FlatStyle = FlatStyle.Flat;
            btnToMlogin.Font = new Font("Microsoft Sans Serif", 20.25F);
            btnToMlogin.ForeColor = Color.FromArgb(246, 180, 71);
            btnToMlogin.Location = new Point(746, 893);
            btnToMlogin.Name = "btnToMlogin";
            btnToMlogin.Size = new Size(419, 69);
            btnToMlogin.TabIndex = 133;
            btnToMlogin.Text = "Back to Manual Login";
            btnToMlogin.UseVisualStyleBackColor = false;
            btnToMlogin.Click += btnToMlogin_Click;
            // 
            // Scanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(btnToMlogin);
            Controls.Add(label2);
            Name = "Scanner";
            Text = "Scanner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnToMlogin;
    }
}