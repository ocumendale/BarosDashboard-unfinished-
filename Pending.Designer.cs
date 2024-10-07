namespace BarosDashboard
{
    partial class Pending
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
            label1 = new Label();
            back2Login = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 40F, FontStyle.Bold);
            label1.Location = new Point(227, 266);
            label1.Name = "label1";
            label1.Size = new Size(1469, 122);
            label1.TabIndex = 0;
            label1.Text = "Please  wait for 1-2 business days,\r\nBarangay Staff will Approve your Sign up Request.";
            // 
            // back2Login
            // 
            back2Login.BackColor = Color.MidnightBlue;
            back2Login.FlatAppearance.BorderSize = 0;
            back2Login.FlatStyle = FlatStyle.Flat;
            back2Login.Font = new Font("Lucida Fax", 20.25F);
            back2Login.ForeColor = Color.FromArgb(246, 180, 71);
            back2Login.Location = new Point(872, 706);
            back2Login.Name = "back2Login";
            back2Login.Size = new Size(188, 69);
            back2Login.TabIndex = 46;
            back2Login.Text = "Sign In";
            back2Login.UseVisualStyleBackColor = false;
            back2Login.Click += back2Login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 30F, FontStyle.Bold);
            label2.Location = new Point(294, 793);
            label2.Name = "label2";
            label2.Size = new Size(1360, 46);
            label2.TabIndex = 47;
            label2.Text = "If your account is approved you can press the button to Sign In";
            // 
            // Pending
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(label2);
            Controls.Add(back2Login);
            Controls.Add(label1);
            Name = "Pending";
            Text = "Pending";
            Load += Pending_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button back2Login;
        private Label label2;
    }
}