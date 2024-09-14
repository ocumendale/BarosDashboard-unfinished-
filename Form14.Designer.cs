namespace BarosDashboard
{
    partial class FormCertif
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
            backCer = new Button();
            SuspendLayout();
            // 
            // backCer
            // 
            backCer.BackColor = Color.Goldenrod;
            backCer.Location = new Point(12, 12);
            backCer.Name = "backCer";
            backCer.Size = new Size(71, 47);
            backCer.TabIndex = 0;
            backCer.Text = "Back";
            backCer.UseVisualStyleBackColor = false;
            backCer.Click += backCer_Click;
            // 
            // FormCertif
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(800, 450);
            Controls.Add(backCer);
            Name = "FormCertif";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BARANGAY CERTIFICATE";
            ResumeLayout(false);
        }

        #endregion

        private Button backCer;
    }
}