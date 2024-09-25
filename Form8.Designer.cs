namespace BarosDashboard
{
    partial class manageReq
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
            backReq = new Button();
            SuspendLayout();
            // 
            // backReq
            // 
            backReq.BackColor = Color.Goldenrod;
            backReq.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backReq.Location = new Point(12, 12);
            backReq.Name = "backReq";
            backReq.Size = new Size(80, 42);
            backReq.TabIndex = 0;
            backReq.Text = "Back";
            backReq.UseVisualStyleBackColor = false;
            backReq.Click += backReq_Click;
            // 
            // manageReq
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1370, 749);
            Controls.Add(backReq);
            Name = "manageReq";
            Text = "ManageReq";
            Load += manageReq_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button backReq;
    }
}