namespace BarosDashboard
{
    partial class FormTent
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
            backTent = new Button();
            SuspendLayout();
            // 
            // backTent
            // 
            backTent.BackColor = Color.Goldenrod;
            backTent.Location = new Point(12, 12);
            backTent.Name = "backTent";
            backTent.Size = new Size(81, 44);
            backTent.TabIndex = 0;
            backTent.Text = "Back";
            backTent.UseVisualStyleBackColor = false;
            backTent.Click += backTent_Click;
            // 
            // FormTent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(800, 450);
            Controls.Add(backTent);
            Name = "FormTent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTent";
            ResumeLayout(false);
        }

        #endregion

        private Button backTent;
    }
}