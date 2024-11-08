﻿namespace BarosDashboard
{
    partial class userRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userRegistration));
            alreadytxt = new Label();
            clear_btn = new Button();
            signup_Btn = new Button();
            checkbxShowPass = new CheckBox();
            password_txtb = new TextBox();
            password_lbl = new Label();
            fullname_txtb = new TextBox();
            fullnamelbl = new Label();
            contact_txtb = new TextBox();
            contact_lbl = new Label();
            email_txtb = new TextBox();
            email_lbl = new Label();
            label1 = new Label();
            button1 = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            address_txb = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            signUpLogo = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // alreadytxt
            // 
            alreadytxt.AutoSize = true;
            alreadytxt.Font = new Font("Lucida Fax", 24F);
            alreadytxt.Location = new Point(405, 898);
            alreadytxt.Name = "alreadytxt";
            alreadytxt.Size = new Size(429, 37);
            alreadytxt.TabIndex = 47;
            alreadytxt.Text = "Already have an account?";
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.MidnightBlue;
            clear_btn.FlatStyle = FlatStyle.Flat;
            clear_btn.Font = new Font("Lucida Fax", 20.25F);
            clear_btn.ForeColor = Color.FromArgb(246, 180, 71);
            clear_btn.Location = new Point(381, 791);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(188, 69);
            clear_btn.TabIndex = 46;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // signup_Btn
            // 
            signup_Btn.BackColor = Color.MidnightBlue;
            signup_Btn.FlatAppearance.BorderSize = 0;
            signup_Btn.FlatStyle = FlatStyle.Flat;
            signup_Btn.Font = new Font("Lucida Fax", 20.25F);
            signup_Btn.ForeColor = Color.FromArgb(246, 180, 71);
            signup_Btn.Location = new Point(651, 791);
            signup_Btn.Name = "signup_Btn";
            signup_Btn.Size = new Size(188, 69);
            signup_Btn.TabIndex = 45;
            signup_Btn.Text = "Sign Up";
            signup_Btn.UseVisualStyleBackColor = false;
            signup_Btn.Click += signup_Btn_Click;
            // 
            // checkbxShowPass
            // 
            checkbxShowPass.AutoSize = true;
            checkbxShowPass.Cursor = Cursors.Hand;
            checkbxShowPass.FlatStyle = FlatStyle.Flat;
            checkbxShowPass.Font = new Font("Lucida Fax", 24F);
            checkbxShowPass.Location = new Point(563, 717);
            checkbxShowPass.Name = "checkbxShowPass";
            checkbxShowPass.Size = new Size(282, 41);
            checkbxShowPass.TabIndex = 44;
            checkbxShowPass.Text = "Show Password";
            checkbxShowPass.UseVisualStyleBackColor = true;
            checkbxShowPass.CheckedChanged += checkbxShowPass_CheckedChanged;
            // 
            // password_txtb
            // 
            password_txtb.BackColor = Color.FromArgb(246, 180, 71);
            password_txtb.BorderStyle = BorderStyle.FixedSingle;
            password_txtb.Cursor = Cursors.IBeam;
            password_txtb.Font = new Font("Segoe UI", 20.25F);
            password_txtb.ForeColor = Color.FromArgb(24, 25, 56);
            password_txtb.Location = new Point(392, 645);
            password_txtb.Multiline = true;
            password_txtb.Name = "password_txtb";
            password_txtb.PasswordChar = '*';
            password_txtb.Size = new Size(458, 61);
            password_txtb.TabIndex = 42;
            password_txtb.TextAlign = HorizontalAlignment.Center;
            password_txtb.TextChanged += password_txtb_TextChanged;
            // 
            // password_lbl
            // 
            password_lbl.AutoSize = true;
            password_lbl.Font = new Font("Lucida Fax", 24F);
            password_lbl.Location = new Point(540, 597);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(170, 37);
            password_lbl.TabIndex = 41;
            password_lbl.Text = "Password";
            // 
            // fullname_txtb
            // 
            fullname_txtb.BackColor = Color.FromArgb(246, 180, 71);
            fullname_txtb.BorderStyle = BorderStyle.FixedSingle;
            fullname_txtb.Cursor = Cursors.IBeam;
            fullname_txtb.Font = new Font("Segoe UI", 20.25F);
            fullname_txtb.ForeColor = Color.FromArgb(24, 25, 56);
            fullname_txtb.Location = new Point(139, 326);
            fullname_txtb.Multiline = true;
            fullname_txtb.Name = "fullname_txtb";
            fullname_txtb.Size = new Size(456, 61);
            fullname_txtb.TabIndex = 40;
            fullname_txtb.TextAlign = HorizontalAlignment.Center;
            fullname_txtb.TextChanged += fullname_txtb_TextChanged;
            // 
            // fullnamelbl
            // 
            fullnamelbl.AutoSize = true;
            fullnamelbl.Font = new Font("Lucida Fax", 24F);
            fullnamelbl.Location = new Point(281, 279);
            fullnamelbl.Name = "fullnamelbl";
            fullnamelbl.Size = new Size(179, 37);
            fullnamelbl.TabIndex = 39;
            fullnamelbl.Text = "Full Name";
            // 
            // contact_txtb
            // 
            contact_txtb.BackColor = Color.FromArgb(246, 180, 71);
            contact_txtb.BorderStyle = BorderStyle.FixedSingle;
            contact_txtb.Cursor = Cursors.IBeam;
            contact_txtb.Font = new Font("Segoe UI", 20.25F);
            contact_txtb.ForeColor = Color.FromArgb(24, 25, 56);
            contact_txtb.Location = new Point(626, 326);
            contact_txtb.Multiline = true;
            contact_txtb.Name = "contact_txtb";
            contact_txtb.Size = new Size(456, 61);
            contact_txtb.TabIndex = 38;
            contact_txtb.TextAlign = HorizontalAlignment.Center;
            // 
            // contact_lbl
            // 
            contact_lbl.AutoSize = true;
            contact_lbl.Font = new Font("Lucida Fax", 24F);
            contact_lbl.Location = new Point(716, 279);
            contact_lbl.Name = "contact_lbl";
            contact_lbl.Size = new Size(281, 37);
            contact_lbl.TabIndex = 37;
            contact_lbl.Text = "Contact Number";
            contact_lbl.Click += contact_lbl_Click;
            // 
            // email_txtb
            // 
            email_txtb.BackColor = Color.FromArgb(246, 180, 71);
            email_txtb.BorderStyle = BorderStyle.FixedSingle;
            email_txtb.Cursor = Cursors.IBeam;
            email_txtb.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email_txtb.ForeColor = Color.FromArgb(24, 25, 56);
            email_txtb.Location = new Point(143, 510);
            email_txtb.Multiline = true;
            email_txtb.Name = "email_txtb";
            email_txtb.Size = new Size(456, 61);
            email_txtb.TabIndex = 36;
            email_txtb.TextAlign = HorizontalAlignment.Center;
            email_txtb.TextChanged += email_txtb_TextChanged;
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.BackColor = Color.Transparent;
            email_lbl.Font = new Font("Lucida Fax", 24F);
            email_lbl.Location = new Point(315, 464);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(106, 37);
            email_lbl.TabIndex = 35;
            email_lbl.Text = "Email";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 72F, FontStyle.Bold);
            label1.Location = new Point(696, 99);
            label1.Name = "label1";
            label1.Size = new Size(538, 109);
            label1.TabIndex = 34;
            label1.Text = "REGISTER";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Fax", 20.25F);
            button1.ForeColor = Color.FromArgb(246, 180, 71);
            button1.Location = new Point(521, 946);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(188, 69);
            button1.TabIndex = 50;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Location = new Point(147, 333);
            panel3.Name = "panel3";
            panel3.Size = new Size(456, 61);
            panel3.TabIndex = 129;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Location = new Point(150, 516);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 61);
            panel1.TabIndex = 130;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(634, 332);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 61);
            panel2.TabIndex = 131;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MidnightBlue;
            panel4.Location = new Point(403, 651);
            panel4.Name = "panel4";
            panel4.Size = new Size(456, 61);
            panel4.TabIndex = 132;
            // 
            // address_txb
            // 
            address_txb.BackColor = Color.FromArgb(246, 180, 71);
            address_txb.BorderStyle = BorderStyle.FixedSingle;
            address_txb.Cursor = Cursors.IBeam;
            address_txb.Font = new Font("Segoe UI", 20.25F);
            address_txb.ForeColor = Color.FromArgb(24, 25, 56);
            address_txb.Location = new Point(626, 510);
            address_txb.Multiline = true;
            address_txb.Name = "address_txb";
            address_txb.Size = new Size(456, 61);
            address_txb.TabIndex = 134;
            address_txb.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 24F);
            label3.Location = new Point(784, 464);
            label3.Name = "label3";
            label3.Size = new Size(148, 37);
            label3.TabIndex = 133;
            label3.Text = "Address";
            // 
            // panel5
            // 
            panel5.BackColor = Color.MidnightBlue;
            panel5.Location = new Point(634, 516);
            panel5.Name = "panel5";
            panel5.Size = new Size(456, 61);
            panel5.TabIndex = 137;
            // 
            // signUpLogo
            // 
            signUpLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(1068, 240);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(845, 641);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 49;
            signUpLogo.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Fax", 12F);
            label6.Location = new Point(466, 406);
            label6.Name = "label6";
            label6.Size = new Size(116, 18);
            label6.TabIndex = 140;
            label6.Text = "MIDDLENAME";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 12F);
            label5.Location = new Point(159, 406);
            label5.Name = "label5";
            label5.Size = new Size(94, 18);
            label5.TabIndex = 139;
            label5.Text = "LASTNAME";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 12F);
            label4.Location = new Point(312, 406);
            label4.Name = "label4";
            label4.Size = new Size(100, 18);
            label4.TabIndex = 138;
            label4.Text = "FIRSTNAME";
            // 
            // userRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(label1);
            Controls.Add(contact_txtb);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(address_txb);
            Controls.Add(label3);
            Controls.Add(panel5);
            Controls.Add(button1);
            Controls.Add(signUpLogo);
            Controls.Add(alreadytxt);
            Controls.Add(clear_btn);
            Controls.Add(signup_Btn);
            Controls.Add(checkbxShowPass);
            Controls.Add(password_txtb);
            Controls.Add(password_lbl);
            Controls.Add(fullname_txtb);
            Controls.Add(fullnamelbl);
            Controls.Add(contact_lbl);
            Controls.Add(email_txtb);
            Controls.Add(email_lbl);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "userRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "userRegistration";
            Load += userRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)signUpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label alreadytxt;
        private Button clear_btn;
        private Button signup_Btn;
        private CheckBox checkbxShowPass;
        private TextBox password_txtb;
        private Label password_lbl;
        private TextBox fullname_txtb;
        private Label fullnamelbl;
        private TextBox contact_txtb;
        private Label contact_lbl;
        private TextBox email_txtb;
        private Label email_lbl;
        private Label label1;
        private Button button1;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private TextBox address_txb;
        private Label label3;
        private Panel panel5;
        private PictureBox signUpLogo;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}