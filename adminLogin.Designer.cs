namespace BarosDashboard
{
    partial class adminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminLogin));
            checkBox1 = new CheckBox();
            signUpLogo = new PictureBox();
            clear_btn = new Button();
            signBtn = new Button();
            txt_Username = new TextBox();
            contactNum = new Label();
            txt_Pass = new TextBox();
            passWord = new Label();
            loginlbl = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(717, 595);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(184, 29);
            checkBox1.TabIndex = 141;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // signUpLogo
            // 
            signUpLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(952, 267);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(845, 641);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 139;
            signUpLogo.TabStop = false;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.MidnightBlue;
            clear_btn.FlatStyle = FlatStyle.Flat;
            clear_btn.Font = new Font("Microsoft Sans Serif", 20.25F);
            clear_btn.ForeColor = Color.FromArgb(246, 180, 71);
            clear_btn.Location = new Point(445, 643);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(188, 69);
            clear_btn.TabIndex = 138;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // signBtn
            // 
            signBtn.BackColor = Color.MidnightBlue;
            signBtn.FlatAppearance.BorderSize = 0;
            signBtn.FlatStyle = FlatStyle.Flat;
            signBtn.Font = new Font("Microsoft Sans Serif", 20.25F);
            signBtn.ForeColor = Color.FromArgb(246, 180, 71);
            signBtn.Location = new Point(713, 643);
            signBtn.Name = "signBtn";
            signBtn.Size = new Size(188, 69);
            signBtn.TabIndex = 137;
            signBtn.Text = "Sign In";
            signBtn.UseVisualStyleBackColor = false;
            signBtn.Click += signBtn_Click;
            // 
            // txt_Username
            // 
            txt_Username.BackColor = Color.FromArgb(246, 180, 71);
            txt_Username.BorderStyle = BorderStyle.FixedSingle;
            txt_Username.Cursor = Cursors.IBeam;
            txt_Username.Font = new Font("Segoe UI", 20.25F);
            txt_Username.ForeColor = Color.FromArgb(24, 25, 56);
            txt_Username.Location = new Point(445, 353);
            txt_Username.Multiline = true;
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(456, 61);
            txt_Username.TabIndex = 136;
            txt_Username.TextAlign = HorizontalAlignment.Center;
            txt_Username.TextChanged += txt_Contact_TextChanged;
            // 
            // contactNum
            // 
            contactNum.AutoSize = true;
            contactNum.Font = new Font("Lucida Fax", 24F);
            contactNum.Location = new Point(585, 303);
            contactNum.Name = "contactNum";
            contactNum.Size = new Size(191, 37);
            contactNum.TabIndex = 135;
            contactNum.Text = "USERNAME";
            // 
            // txt_Pass
            // 
            txt_Pass.BackColor = Color.FromArgb(246, 180, 71);
            txt_Pass.BorderStyle = BorderStyle.FixedSingle;
            txt_Pass.Cursor = Cursors.IBeam;
            txt_Pass.Font = new Font("Segoe UI", 20.25F);
            txt_Pass.ForeColor = Color.FromArgb(24, 25, 56);
            txt_Pass.Location = new Point(445, 504);
            txt_Pass.Multiline = true;
            txt_Pass.Name = "txt_Pass";
            txt_Pass.PasswordChar = '*';
            txt_Pass.Size = new Size(456, 61);
            txt_Pass.TabIndex = 134;
            txt_Pass.TextAlign = HorizontalAlignment.Center;
            // 
            // passWord
            // 
            passWord.AutoSize = true;
            passWord.Font = new Font("Lucida Fax", 24F);
            passWord.Location = new Point(585, 456);
            passWord.Name = "passWord";
            passWord.Size = new Size(197, 37);
            passWord.TabIndex = 133;
            passWord.Text = "PASSWORD";
            // 
            // loginlbl
            // 
            loginlbl.Anchor = AnchorStyles.Top;
            loginlbl.AutoSize = true;
            loginlbl.Font = new Font("Lucida Fax", 72F, FontStyle.Bold);
            loginlbl.Location = new Point(742, 94);
            loginlbl.Name = "loginlbl";
            loginlbl.Size = new Size(397, 109);
            loginlbl.TabIndex = 132;
            loginlbl.Text = "ADMIN";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Location = new Point(453, 360);
            panel3.Name = "panel3";
            panel3.Size = new Size(456, 61);
            panel3.TabIndex = 142;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Location = new Point(454, 512);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 61);
            panel1.TabIndex = 143;
            // 
            // adminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(checkBox1);
            Controls.Add(signUpLogo);
            Controls.Add(clear_btn);
            Controls.Add(signBtn);
            Controls.Add(txt_Username);
            Controls.Add(contactNum);
            Controls.Add(txt_Pass);
            Controls.Add(passWord);
            Controls.Add(loginlbl);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "adminLogin";
            Text = "adminLogin";
            Load += adminLogin_Load;
            ((System.ComponentModel.ISupportInitialize)signUpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Button signUp_btn;
        private PictureBox signUpLogo;
        private Button clear_btn;
        private Button signBtn;
        private TextBox txt_Username;
        private Label contactNum;
        private TextBox txt_Pass;
        private Label passWord;
        private Label loginlbl;
        private Panel panel3;
        private Panel panel1;
    }
}