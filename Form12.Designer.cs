namespace BarosDashboard
{
    partial class FormIn
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
            backIn = new Button();
            SuspendLayout();
            // 
            // backIn
            // 
            backIn.BackColor = Color.Goldenrod;
            backIn.Location = new Point(12, 12);
            backIn.Name = "backIn";
            backIn.Size = new Size(79, 44);
            backIn.TabIndex = 0;
            backIn.Text = "Back";
            backIn.UseVisualStyleBackColor = false;
            backIn.Click += backIn_Click;
            // 
            // FormIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(800, 450);
            Controls.Add(backIn);
            Name = "FormIn";
            Text = "BARANGAY INDIGENCY";
            ResumeLayout(false);
        }

        #endregion

        private Button backIn;
    }
}