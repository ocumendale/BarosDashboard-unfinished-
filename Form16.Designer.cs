namespace BarosDashboard
{
    partial class FormBas
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
            backCourt = new Button();
            SuspendLayout();
            // 
            // backCourt
            // 
            backCourt.BackColor = Color.Goldenrod;
            backCourt.Location = new Point(12, 12);
            backCourt.Name = "backCourt";
            backCourt.Size = new Size(74, 48);
            backCourt.TabIndex = 0;
            backCourt.Text = "Back";
            backCourt.UseVisualStyleBackColor = false;
            backCourt.Click += backCourt_Click;
            // 
            // FormBas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(800, 450);
            Controls.Add(backCourt);
            Name = "FormBas";
            Text = "BASKETBALL COURT";
            Load += Form16_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button backCourt;
    }
}