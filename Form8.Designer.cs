namespace BarosDashboard
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            signUpLogo = new PictureBox();
            backtolog_lbl = new Label();
            alreadytxt = new Label();
            clear_btn = new Button();
            signup_Btn = new Button();
            checkbxShowPass = new CheckBox();
            conPass = new Label();
            password_txtb = new TextBox();
            password_lbl = new Label();
            fullname_txtb = new TextBox();
            fullnamelbl = new Label();
            contact_txtb = new TextBox();
            contact_lbl = new Label();
            email_txtb = new TextBox();
            email_lbl = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // signUpLogo
            // 
            signUpLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(394, 82);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(317, 300);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 33;
            signUpLogo.TabStop = false;
            // 
            // backtolog_lbl
            // 
            backtolog_lbl.AutoSize = true;
            backtolog_lbl.Location = new Point(217, 416);
            backtolog_lbl.Name = "backtolog_lbl";
            backtolog_lbl.Size = new Size(79, 15);
            backtolog_lbl.TabIndex = 32;
            backtolog_lbl.Text = "Back to Login";
            backtolog_lbl.Click += backtolog_lbl_Click;
            // 
            // alreadytxt
            // 
            alreadytxt.AutoSize = true;
            alreadytxt.Location = new Point(90, 399);
            alreadytxt.Name = "alreadytxt";
            alreadytxt.Size = new Size(142, 15);
            alreadytxt.TabIndex = 31;
            alreadytxt.Text = "Already have an account?";
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.DarkGoldenrod;
            clear_btn.FlatStyle = FlatStyle.Flat;
            clear_btn.ForeColor = Color.FromArgb(24, 25, 56);
            clear_btn.Location = new Point(93, 347);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(100, 35);
            clear_btn.TabIndex = 30;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = false;
            // 
            // signup_Btn
            // 
            signup_Btn.BackColor = Color.FromArgb(24, 25, 56);
            signup_Btn.FlatAppearance.BorderSize = 0;
            signup_Btn.FlatStyle = FlatStyle.Flat;
            signup_Btn.ForeColor = Color.FromArgb(246, 180, 71);
            signup_Btn.Location = new Point(209, 347);
            signup_Btn.Name = "signup_Btn";
            signup_Btn.Size = new Size(100, 35);
            signup_Btn.TabIndex = 29;
            signup_Btn.Text = "Sign Up";
            signup_Btn.UseVisualStyleBackColor = false;
            // 
            // checkbxShowPass
            // 
            checkbxShowPass.AutoSize = true;
            checkbxShowPass.Cursor = Cursors.Hand;
            checkbxShowPass.FlatStyle = FlatStyle.Flat;
            checkbxShowPass.Location = new Point(190, 320);
            checkbxShowPass.Name = "checkbxShowPass";
            checkbxShowPass.Size = new Size(105, 19);
            checkbxShowPass.TabIndex = 28;
            checkbxShowPass.Text = "Show Password";
            checkbxShowPass.UseVisualStyleBackColor = true;
            // 
            // conPass
            // 
            conPass.AutoSize = true;
            conPass.Location = new Point(93, 266);
            conPass.Name = "conPass";
            conPass.Size = new Size(104, 15);
            conPass.TabIndex = 26;
            conPass.Text = "Confirm Password";
            // 
            // password_txtb
            // 
            password_txtb.BackColor = Color.DarkGoldenrod;
            password_txtb.BorderStyle = BorderStyle.FixedSingle;
            password_txtb.Cursor = Cursors.IBeam;
            password_txtb.ForeColor = Color.FromArgb(24, 25, 56);
            password_txtb.Location = new Point(93, 235);
            password_txtb.Multiline = true;
            password_txtb.Name = "password_txtb";
            password_txtb.Size = new Size(216, 28);
            password_txtb.TabIndex = 25;
            // 
            // password_lbl
            // 
            password_lbl.AutoSize = true;
            password_lbl.Location = new Point(93, 215);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(57, 15);
            password_lbl.TabIndex = 24;
            password_lbl.Text = "Password";
            // 
            // fullname_txtb
            // 
            fullname_txtb.BackColor = Color.DarkGoldenrod;
            fullname_txtb.BorderStyle = BorderStyle.FixedSingle;
            fullname_txtb.Cursor = Cursors.IBeam;
            fullname_txtb.ForeColor = Color.FromArgb(24, 25, 56);
            fullname_txtb.Location = new Point(93, 82);
            fullname_txtb.Multiline = true;
            fullname_txtb.Name = "fullname_txtb";
            fullname_txtb.Size = new Size(216, 28);
            fullname_txtb.TabIndex = 23;
            // 
            // fullnamelbl
            // 
            fullnamelbl.AutoSize = true;
            fullnamelbl.Location = new Point(93, 62);
            fullnamelbl.Name = "fullnamelbl";
            fullnamelbl.Size = new Size(61, 15);
            fullnamelbl.TabIndex = 22;
            fullnamelbl.Text = "Full Name";
            // 
            // contact_txtb
            // 
            contact_txtb.BackColor = Color.DarkGoldenrod;
            contact_txtb.BorderStyle = BorderStyle.FixedSingle;
            contact_txtb.Cursor = Cursors.IBeam;
            contact_txtb.ForeColor = Color.FromArgb(24, 25, 56);
            contact_txtb.Location = new Point(93, 184);
            contact_txtb.Multiline = true;
            contact_txtb.Name = "contact_txtb";
            contact_txtb.Size = new Size(216, 28);
            contact_txtb.TabIndex = 21;
            // 
            // contact_lbl
            // 
            contact_lbl.AutoSize = true;
            contact_lbl.Location = new Point(93, 164);
            contact_lbl.Name = "contact_lbl";
            contact_lbl.Size = new Size(96, 15);
            contact_lbl.TabIndex = 20;
            contact_lbl.Text = "Contact Number";
            // 
            // email_txtb
            // 
            email_txtb.BackColor = Color.DarkGoldenrod;
            email_txtb.BorderStyle = BorderStyle.FixedSingle;
            email_txtb.Cursor = Cursors.IBeam;
            email_txtb.ForeColor = Color.FromArgb(24, 25, 56);
            email_txtb.Location = new Point(93, 133);
            email_txtb.Multiline = true;
            email_txtb.Name = "email_txtb";
            email_txtb.Size = new Size(216, 28);
            email_txtb.TabIndex = 19;
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.Location = new Point(93, 113);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(36, 15);
            email_lbl.TabIndex = 18;
            email_lbl.Text = "Email";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 20);
            label1.Name = "label1";
            label1.Size = new Size(113, 29);
            label1.TabIndex = 17;
            label1.Text = "Sign Up";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(800, 450);
            Controls.Add(signUpLogo);
            Controls.Add(backtolog_lbl);
            Controls.Add(alreadytxt);
            Controls.Add(clear_btn);
            Controls.Add(signup_Btn);
            Controls.Add(checkbxShowPass);
            Controls.Add(conPass);
            Controls.Add(password_txtb);
            Controls.Add(password_lbl);
            Controls.Add(fullname_txtb);
            Controls.Add(fullnamelbl);
            Controls.Add(contact_txtb);
            Controls.Add(contact_lbl);
            Controls.Add(email_txtb);
            Controls.Add(email_lbl);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)signUpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox signUpLogo;
        private Label backtolog_lbl;
        private Label alreadytxt;
        private Button clear_btn;
        private Button signup_Btn;
        private CheckBox checkbxShowPass;
        private Label conPass;
        private TextBox password_txtb;
        private Label password_lbl;
        private TextBox fullname_txtb;
        private Label fullnamelbl;
        private TextBox contact_txtb;
        private Label contact_lbl;
        private TextBox email_txtb;
        private Label email_lbl;
        private Label label1;
    }
}