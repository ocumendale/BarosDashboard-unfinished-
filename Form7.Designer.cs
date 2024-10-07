
namespace BarosDashboard
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            signUpLogo = new PictureBox();
            exit = new Label();
            clear2_btn = new Button();
            signin_Btn = new Button();
            txt_ContactNum = new TextBox();
            contactNum = new Label();
            txt_password = new TextBox();
            passWord = new Label();
            loginlbl = new Label();
            signUp_btn = new Button();
            checkBox1 = new CheckBox();
            panel3 = new Panel();
            panel1 = new Panel();
            btnToScan = new Button();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // signUpLogo
            // 
            signUpLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(952, 267);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(845, 641);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 26;
            signUpLogo.TabStop = false;
            signUpLogo.Click += signUpLogo_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Font = new Font("Segoe UI", 24F);
            exit.Location = new Point(83, 1006);
            exit.Name = "exit";
            exit.Size = new Size(70, 45);
            exit.TabIndex = 25;
            exit.Text = "Exit";
            exit.Click += exit_Click;
            // 
            // clear2_btn
            // 
            clear2_btn.BackColor = Color.MidnightBlue;
            clear2_btn.FlatStyle = FlatStyle.Flat;
            clear2_btn.Font = new Font("Microsoft Sans Serif", 20.25F);
            clear2_btn.ForeColor = Color.FromArgb(246, 180, 71);
            clear2_btn.Location = new Point(384, 692);
            clear2_btn.Name = "clear2_btn";
            clear2_btn.Size = new Size(188, 69);
            clear2_btn.TabIndex = 24;
            clear2_btn.Text = "Clear";
            clear2_btn.UseVisualStyleBackColor = false;
            clear2_btn.Click += clear2_btn_Click;
            // 
            // signin_Btn
            // 
            signin_Btn.BackColor = Color.MidnightBlue;
            signin_Btn.FlatAppearance.BorderSize = 0;
            signin_Btn.FlatStyle = FlatStyle.Flat;
            signin_Btn.Font = new Font("Microsoft Sans Serif", 20.25F);
            signin_Btn.ForeColor = Color.FromArgb(246, 180, 71);
            signin_Btn.Location = new Point(652, 692);
            signin_Btn.Name = "signin_Btn";
            signin_Btn.Size = new Size(188, 69);
            signin_Btn.TabIndex = 23;
            signin_Btn.Text = "Sign In";
            signin_Btn.UseVisualStyleBackColor = false;
            signin_Btn.Click += signin_Btn_Click;
            // 
            // txt_ContactNum
            // 
            txt_ContactNum.BackColor = Color.FromArgb(246, 180, 71);
            txt_ContactNum.BorderStyle = BorderStyle.FixedSingle;
            txt_ContactNum.Cursor = Cursors.IBeam;
            txt_ContactNum.Font = new Font("Segoe UI", 20.25F);
            txt_ContactNum.ForeColor = Color.FromArgb(24, 25, 56);
            txt_ContactNum.Location = new Point(384, 402);
            txt_ContactNum.Multiline = true;
            txt_ContactNum.Name = "txt_ContactNum";
            txt_ContactNum.Size = new Size(456, 61);
            txt_ContactNum.TabIndex = 22;
            txt_ContactNum.TextChanged += cNum_tb_TextChanged;
            // 
            // contactNum
            // 
            contactNum.AutoSize = true;
            contactNum.Font = new Font("Microsoft Sans Serif", 24F);
            contactNum.Location = new Point(479, 354);
            contactNum.Name = "contactNum";
            contactNum.Size = new Size(252, 37);
            contactNum.TabIndex = 21;
            contactNum.Text = "Contact Number";
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.FromArgb(246, 180, 71);
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Cursor = Cursors.IBeam;
            txt_password.Font = new Font("Segoe UI", 20.25F);
            txt_password.ForeColor = Color.FromArgb(24, 25, 56);
            txt_password.Location = new Point(384, 553);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(456, 61);
            txt_password.TabIndex = 20;
            // 
            // passWord
            // 
            passWord.AutoSize = true;
            passWord.Font = new Font("Microsoft Sans Serif", 24F);
            passWord.Location = new Point(532, 505);
            passWord.Name = "passWord";
            passWord.Size = new Size(167, 37);
            passWord.TabIndex = 19;
            passWord.Text = "Password ";
            // 
            // loginlbl
            // 
            loginlbl.Anchor = AnchorStyles.Top;
            loginlbl.AutoSize = true;
            loginlbl.Font = new Font("MS UI Gothic", 72F, FontStyle.Bold);
            loginlbl.Location = new Point(742, 94);
            loginlbl.Name = "loginlbl";
            loginlbl.Size = new Size(373, 97);
            loginlbl.TabIndex = 18;
            loginlbl.Text = "SIGN IN";
            // 
            // signUp_btn
            // 
            signUp_btn.BackColor = Color.MidnightBlue;
            signUp_btn.FlatAppearance.BorderSize = 0;
            signUp_btn.FlatStyle = FlatStyle.Flat;
            signUp_btn.Font = new Font("Microsoft Sans Serif", 20.25F);
            signUp_btn.ForeColor = Color.FromArgb(246, 180, 71);
            signUp_btn.Location = new Point(515, 794);
            signUp_btn.Name = "signUp_btn";
            signUp_btn.Size = new Size(188, 69);
            signUp_btn.TabIndex = 27;
            signUp_btn.Text = "Sign Up";
            signUp_btn.UseVisualStyleBackColor = false;
            signUp_btn.Click += signUp_btn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(656, 644);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(184, 29);
            checkBox1.TabIndex = 28;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Location = new Point(392, 409);
            panel3.Name = "panel3";
            panel3.Size = new Size(456, 61);
            panel3.TabIndex = 130;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Location = new Point(393, 561);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 61);
            panel1.TabIndex = 131;
            // 
            // btnToScan
            // 
            btnToScan.BackColor = Color.MidnightBlue;
            btnToScan.FlatAppearance.BorderSize = 0;
            btnToScan.FlatStyle = FlatStyle.Flat;
            btnToScan.Font = new Font("Microsoft Sans Serif", 20.25F);
            btnToScan.ForeColor = Color.FromArgb(246, 180, 71);
            btnToScan.Location = new Point(1179, 965);
            btnToScan.Name = "btnToScan";
            btnToScan.Size = new Size(419, 69);
            btnToScan.TabIndex = 132;
            btnToScan.Text = "Sign In via QR Code";
            btnToScan.UseVisualStyleBackColor = false;
            btnToScan.Click += btnToScan_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(btnToScan);
            Controls.Add(checkBox1);
            Controls.Add(signUp_btn);
            Controls.Add(signUpLogo);
            Controls.Add(exit);
            Controls.Add(clear2_btn);
            Controls.Add(signin_Btn);
            Controls.Add(txt_ContactNum);
            Controls.Add(contactNum);
            Controls.Add(txt_password);
            Controls.Add(passWord);
            Controls.Add(loginlbl);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)signUpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cNum_tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private PictureBox signUpLogo;
        private Label exit;
        private Button clear2_btn;
        private Button signin_Btn;
        private TextBox txt_ContactNum;
        private Label contactNum;
        private TextBox txt_password;
        private Label passWord;
        private Label loginlbl;
        private Button signUp_btn;
        private CheckBox checkBox1;
        private Panel panel3;
        private Panel panel1;
        private Button btnToScan;
    }
}