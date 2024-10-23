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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pending));
            label1 = new Label();
            back2Login = new Button();
            label2 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            signUpLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(571, 130);
            label1.Name = "label1";
            label1.Size = new Size(765, 43);
            label1.TabIndex = 0;
            label1.Text = "PLEASE WAIT FOR 1-2 BUSINESS DAYS.";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // back2Login
            // 
            back2Login.BackColor = Color.MidnightBlue;
            back2Login.FlatAppearance.BorderSize = 0;
            back2Login.FlatStyle = FlatStyle.Flat;
            back2Login.Font = new Font("Lucida Fax", 20.25F);
            back2Login.ForeColor = Color.FromArgb(246, 180, 71);
            back2Login.Location = new Point(869, 365);
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
            label2.Font = new Font("Lucida Fax", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(245, 481);
            label2.Name = "label2";
            label2.Size = new Size(1410, 40);
            label2.TabIndex = 47;
            label2.Text = "IF YOUR ACCOUNT IS APPROVED YOU CAN PRESS THE BUTTON TO SIGN IN.";
            // 
            // panel4
            // 
            panel4.BackColor = Color.MidnightBlue;
            panel4.Location = new Point(470, 278);
            panel4.Name = "panel4";
            panel4.Size = new Size(1031, 10);
            panel4.TabIndex = 135;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(377, 205);
            label4.Name = "label4";
            label4.Size = new Size(1165, 43);
            label4.TabIndex = 137;
            label4.Text = "BARANGAY STAFF WILL APPROVE YOUR SIGN UP REQUEST.";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // signUpLogo
            // 
            signUpLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(658, 543);
            signUpLogo.Margin = new Padding(0);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(630, 488);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 138;
            signUpLogo.TabStop = false;
            // 
            // Pending
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(signUpLogo);
            Controls.Add(label4);
            Controls.Add(panel4);
            Controls.Add(label2);
            Controls.Add(back2Login);
            Controls.Add(label1);
            Name = "Pending";
            Text = "Pending";
            Load += Pending_Load;
            ((System.ComponentModel.ISupportInitialize)signUpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button back2Login;
        private Label label2;
        private Panel panel4;
        private Label label4;
        private PictureBox signUpLogo;
    }
}