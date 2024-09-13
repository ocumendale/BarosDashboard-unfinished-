namespace BarosDashboard
{
    partial class FormClear
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
            backCLear = new Button();
            SuspendLayout();
            // 
            // backCLear
            // 
            backCLear.BackColor = Color.Goldenrod;
            backCLear.Location = new Point(12, 12);
            backCLear.Name = "backCLear";
            backCLear.Size = new Size(75, 42);
            backCLear.TabIndex = 0;
            backCLear.Text = "Back";
            backCLear.UseVisualStyleBackColor = false;
            backCLear.Click += button1_Click;
            // 
            // FormClear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(800, 450);
            Controls.Add(backCLear);
            Name = "FormClear";
            Text = "BARANGAY CLEARANCE";
            ResumeLayout(false);
        }

        #endregion

        private Button backCLear;
    }
}