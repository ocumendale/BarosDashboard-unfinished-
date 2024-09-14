namespace BarosDashboard
{
    partial class FormId
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
            backId = new Button();
            SuspendLayout();
            // 
            // backId
            // 
            backId.BackColor = Color.Goldenrod;
            backId.Location = new Point(12, 12);
            backId.Name = "backId";
            backId.Size = new Size(71, 47);
            backId.TabIndex = 0;
            backId.Text = "Back";
            backId.UseVisualStyleBackColor = false;
            backId.Click += backId_Click;
            // 
            // FormId
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(800, 450);
            Controls.Add(backId);
            Name = "FormId";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BARANGAY ID";
            Load += Form15_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button backId;
    }
}