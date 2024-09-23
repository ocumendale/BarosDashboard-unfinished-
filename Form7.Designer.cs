
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
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // signUpLogo
            // 
            signUpLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(438, 128);
            signUpLogo.Margin = new Padding(3, 4, 3, 4);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(362, 400);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 26;
            signUpLogo.TabStop = false;
            signUpLogo.Click += signUpLogo_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.Location = new Point(206, 345);
            exit.Name = "exit";
            exit.Size = new Size(65, 30);
            exit.TabIndex = 25;
            exit.Text = "Exit";
            exit.Click += exit_Click;
            // 
            // clear2_btn
            // 
            clear2_btn.BackColor = Color.DarkGoldenrod;
            clear2_btn.FlatStyle = FlatStyle.Flat;
            clear2_btn.ForeColor = Color.FromArgb(24, 25, 56);
            clear2_btn.Location = new Point(114, 280);
            clear2_btn.Margin = new Padding(3, 4, 3, 4);
            clear2_btn.Name = "clear2_btn";
            clear2_btn.Size = new Size(114, 47);
            clear2_btn.TabIndex = 24;
            clear2_btn.Text = "Clear";
            clear2_btn.UseVisualStyleBackColor = false;
            clear2_btn.Click += clear2_btn_Click;
            // 
            // signin_Btn
            // 
            signin_Btn.BackColor = Color.FromArgb(24, 25, 56);
            signin_Btn.FlatAppearance.BorderSize = 0;
            signin_Btn.FlatStyle = FlatStyle.Flat;
            signin_Btn.ForeColor = Color.FromArgb(246, 180, 71);
            signin_Btn.Location = new Point(247, 280);
            signin_Btn.Margin = new Padding(3, 4, 3, 4);
            signin_Btn.Name = "signin_Btn";
            signin_Btn.Size = new Size(114, 47);
            signin_Btn.TabIndex = 23;
            signin_Btn.Text = "Sign In";
            signin_Btn.UseVisualStyleBackColor = false;
            signin_Btn.Click += signin_Btn_Click;
            // 
            // txt_ContactNum
            // 
            txt_ContactNum.BackColor = Color.DarkGoldenrod;
            txt_ContactNum.BorderStyle = BorderStyle.FixedSingle;
            txt_ContactNum.Cursor = Cursors.IBeam;
            txt_ContactNum.ForeColor = Color.FromArgb(24, 25, 56);
            txt_ContactNum.Location = new Point(114, 155);
            txt_ContactNum.Margin = new Padding(3, 4, 3, 4);
            txt_ContactNum.Multiline = true;
            txt_ContactNum.Name = "txt_ContactNum";
            txt_ContactNum.Size = new Size(247, 37);
            txt_ContactNum.TabIndex = 22;
            txt_ContactNum.TextChanged += cNum_tb_TextChanged;
            // 
            // contactNum
            // 
            contactNum.AutoSize = true;
            contactNum.Location = new Point(114, 128);
            contactNum.Name = "contactNum";
            contactNum.Size = new Size(118, 20);
            contactNum.TabIndex = 21;
            contactNum.Text = "Contact Number";
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.DarkGoldenrod;
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Cursor = Cursors.IBeam;
            txt_password.ForeColor = Color.FromArgb(24, 25, 56);
            txt_password.Location = new Point(114, 223);
            txt_password.Margin = new Padding(3, 4, 3, 4);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(247, 37);
            txt_password.TabIndex = 20;
            // 
            // passWord
            // 
            passWord.AutoSize = true;
            passWord.Location = new Point(114, 196);
            passWord.Name = "passWord";
            passWord.Size = new Size(74, 20);
            passWord.TabIndex = 19;
            passWord.Text = "Password ";
            // 
            // loginlbl
            // 
            loginlbl.Anchor = AnchorStyles.Top;
            loginlbl.AutoSize = true;
            loginlbl.Font = new Font("MS UI Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginlbl.Location = new Point(344, 72);
            loginlbl.Name = "loginlbl";
            loginlbl.Size = new Size(129, 37);
            loginlbl.TabIndex = 18;
            loginlbl.Text = "Sign In";
            // 
            // signUp_btn
            // 
            signUp_btn.BackColor = Color.FromArgb(24, 25, 56);
            signUp_btn.FlatAppearance.BorderSize = 0;
            signUp_btn.FlatStyle = FlatStyle.Flat;
            signUp_btn.ForeColor = Color.FromArgb(246, 180, 71);
            signUp_btn.Location = new Point(40, 481);
            signUp_btn.Margin = new Padding(3, 4, 3, 4);
            signUp_btn.Name = "signUp_btn";
            signUp_btn.Size = new Size(114, 47);
            signUp_btn.TabIndex = 27;
            signUp_btn.Text = "Sign Up";
            signUp_btn.UseVisualStyleBackColor = false;
            signUp_btn.Click += signUp_btn_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "login";
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
    }
}