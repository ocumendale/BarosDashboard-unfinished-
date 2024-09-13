namespace BarosDashboard
{
    partial class FormTable
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
            backTable = new Button();
            SuspendLayout();
            // 
            // backTable
            // 
            backTable.BackColor = Color.Goldenrod;
            backTable.Location = new Point(12, 12);
            backTable.Name = "backTable";
            backTable.Size = new Size(73, 45);
            backTable.TabIndex = 0;
            backTable.Text = "Back";
            backTable.UseVisualStyleBackColor = false;
            backTable.Click += backTable_Click;
            // 
            // FormTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(800, 450);
            Controls.Add(backTable);
            Name = "FormTable";
            Text = "TABLE";
            ResumeLayout(false);
        }

        #endregion

        private Button backTable;
    }
}