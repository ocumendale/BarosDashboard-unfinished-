namespace BarosDashboard
{
    partial class indigencyGridview
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
            backbtn = new Button();
            SuspendLayout();
            // 
            // backbtn
            // 
            backbtn.Location = new Point(43, 31);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(147, 63);
            backbtn.TabIndex = 1;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // indigencyGridview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1911, 1118);
            Controls.Add(backbtn);
            Name = "indigencyGridview";
            Text = "indigencyGridview";
            Load += indigencyGridview_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button backbtn;
    }
}