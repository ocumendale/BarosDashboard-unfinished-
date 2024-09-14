namespace BarosDashboard
{
    partial class FormChair
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
            backChair = new Button();
            SuspendLayout();
            // 
            // backChair
            // 
            backChair.BackColor = Color.Goldenrod;
            backChair.Location = new Point(12, 12);
            backChair.Name = "backChair";
            backChair.Size = new Size(77, 48);
            backChair.TabIndex = 0;
            backChair.Text = "Back";
            backChair.UseVisualStyleBackColor = false;
            backChair.Click += backChair_Click;
            // 
            // FormChair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(800, 450);
            Controls.Add(backChair);
            Name = "FormChair";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHAIR";
            ResumeLayout(false);
        }

        #endregion

        private Button backChair;
    }
}