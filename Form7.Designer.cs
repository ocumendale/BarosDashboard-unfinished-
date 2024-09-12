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
            cNum_tb = new TextBox();
            contactNum = new Label();
            pass_tb = new TextBox();
            passWord = new Label();
            loginlbl = new Label();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // signUpLogo
            // 
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(383, 96);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(317, 300);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 26;
            signUpLogo.TabStop = false;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.Location = new Point(180, 259);
            exit.Name = "exit";
            exit.Size = new Size(52, 24);
            exit.TabIndex = 25;
            exit.Text = "Exit";
            exit.Click += exit_Click;
            // 
            // clear2_btn
            // 
            clear2_btn.BackColor = Color.DarkGoldenrod;
            clear2_btn.FlatStyle = FlatStyle.Flat;
            clear2_btn.ForeColor = Color.FromArgb(24, 25, 56);
            clear2_btn.Location = new Point(100, 210);
            clear2_btn.Name = "clear2_btn";
            clear2_btn.Size = new Size(100, 35);
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
            signin_Btn.Location = new Point(216, 210);
            signin_Btn.Name = "signin_Btn";
            signin_Btn.Size = new Size(100, 35);
            signin_Btn.TabIndex = 23;
            signin_Btn.Text = "Sign In";
            signin_Btn.UseVisualStyleBackColor = false;
            signin_Btn.Click += signin_Btn_Click;
            // 
            // cNum_tb
            // 
            cNum_tb.BackColor = Color.DarkGoldenrod;
            cNum_tb.BorderStyle = BorderStyle.FixedSingle;
            cNum_tb.Cursor = Cursors.IBeam;
            cNum_tb.ForeColor = Color.FromArgb(24, 25, 56);
            cNum_tb.Location = new Point(100, 116);
            cNum_tb.Multiline = true;
            cNum_tb.Name = "cNum_tb";
            cNum_tb.Size = new Size(216, 28);
            cNum_tb.TabIndex = 22;
            // 
            // contactNum
            // 
            contactNum.AutoSize = true;
            contactNum.Location = new Point(100, 96);
            contactNum.Name = "contactNum";
            contactNum.Size = new Size(96, 15);
            contactNum.TabIndex = 21;
            contactNum.Text = "Contact Number";
            // 
            // pass_tb
            // 
            pass_tb.BackColor = Color.DarkGoldenrod;
            pass_tb.BorderStyle = BorderStyle.FixedSingle;
            pass_tb.Cursor = Cursors.IBeam;
            pass_tb.ForeColor = Color.FromArgb(24, 25, 56);
            pass_tb.Location = new Point(100, 167);
            pass_tb.Multiline = true;
            pass_tb.Name = "pass_tb";
            pass_tb.Size = new Size(216, 28);
            pass_tb.TabIndex = 20;
            // 
            // passWord
            // 
            passWord.AutoSize = true;
            passWord.Location = new Point(100, 147);
            passWord.Name = "passWord";
            passWord.Size = new Size(60, 15);
            passWord.TabIndex = 19;
            passWord.Text = "Password ";
            // 
            // loginlbl
            // 
            loginlbl.AutoSize = true;
            loginlbl.Font = new Font("MS UI Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginlbl.Location = new Point(301, 54);
            loginlbl.Name = "loginlbl";
            loginlbl.Size = new Size(102, 29);
            loginlbl.TabIndex = 18;
            loginlbl.Text = "Sign In";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(signUpLogo);
            Controls.Add(exit);
            Controls.Add(clear2_btn);
            Controls.Add(signin_Btn);
            Controls.Add(cNum_tb);
            Controls.Add(contactNum);
            Controls.Add(pass_tb);
            Controls.Add(passWord);
            Controls.Add(loginlbl);
            Name = "login";
            Text = "Login";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)signUpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox signUpLogo;
        private Label exit;
        private Button clear2_btn;
        private Button signin_Btn;
        private TextBox cNum_tb;
        private Label contactNum;
        private TextBox pass_tb;
        private Label passWord;
        private Label loginlbl;
    }
}