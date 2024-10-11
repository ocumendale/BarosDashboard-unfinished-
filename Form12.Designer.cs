
namespace BarosDashboard
{
    partial class FormIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIn));
            backCourt = new Button();
            textBox4 = new TextBox();
            label9 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            signUpLogo = new PictureBox();
            label10 = new Label();
            textBox5 = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // backCourt
            // 
            backCourt.BackColor = Color.MidnightBlue;
            backCourt.FlatAppearance.BorderSize = 0;
            backCourt.FlatStyle = FlatStyle.Flat;
            backCourt.Font = new Font("Lucida Fax", 15.75F, FontStyle.Bold);
            backCourt.ForeColor = Color.FromArgb(246, 180, 71);
            backCourt.Location = new Point(12, 12);
            backCourt.Name = "backCourt";
            backCourt.Size = new Size(97, 53);
            backCourt.TabIndex = 191;
            backCourt.Text = "Back";
            backCourt.UseVisualStyleBackColor = false;
            backCourt.Click += backCourt_Click_1;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Right;
            textBox4.BackColor = Color.FromArgb(246, 180, 71);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 26.25F);
            textBox4.Location = new Point(260, 640);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(707, 54);
            textBox4.TabIndex = 190;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            label9.Location = new Point(487, 595);
            label9.Name = "label9";
            label9.Size = new Size(259, 33);
            label9.TabIndex = 189;
            label9.Text = "HOME ADDRESS";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.MidnightBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(246, 180, 71);
            button1.Location = new Point(526, 1004);
            button1.Name = "button1";
            button1.Size = new Size(186, 63);
            button1.TabIndex = 187;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Right;
            textBox3.BackColor = Color.FromArgb(246, 180, 71);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 26.25F);
            textBox3.Location = new Point(260, 785);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(707, 54);
            textBox3.TabIndex = 186;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            label8.Location = new Point(456, 743);
            label8.Name = "label8";
            label8.Size = new Size(342, 33);
            label8.TabIndex = 185;
            label8.Text = "REASON OF REQUEST";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.BackColor = Color.FromArgb(246, 180, 71);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 26.25F);
            textBox2.Location = new Point(266, 502);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(707, 54);
            textBox2.TabIndex = 184;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            label7.Location = new Point(468, 459);
            label7.Name = "label7";
            label7.Size = new Size(308, 33);
            label7.TabIndex = 183;
            label7.Text = "CONTACT NUMBER";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 18F);
            label6.Location = new Point(792, 403);
            label6.Name = "label6";
            label6.Size = new Size(166, 32);
            label6.TabIndex = 182;
            label6.Text = "MIDDLENAME";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 18F);
            label5.Location = new Point(285, 400);
            label5.Name = "label5";
            label5.Size = new Size(133, 32);
            label5.TabIndex = 181;
            label5.Text = "LASTNAME";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 18F);
            label4.Location = new Point(539, 403);
            label4.Name = "label4";
            label4.Size = new Size(139, 32);
            label4.TabIndex = 180;
            label4.Text = "FIRSTNAME";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            label3.Location = new Point(522, 293);
            label3.Name = "label3";
            label3.Size = new Size(190, 33);
            label3.TabIndex = 179;
            label3.Text = "FULL NAME";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = Color.FromArgb(246, 180, 71);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 26.25F);
            textBox1.Location = new Point(266, 334);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(707, 54);
            textBox1.TabIndex = 178;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 18F, FontStyle.Bold);
            label2.Location = new Point(848, 219);
            label2.Name = "label2";
            label2.Size = new Size(281, 27);
            label2.TabIndex = 177;
            label2.Text = "FILL OUT THIS FORM ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 72F, FontStyle.Bold);
            label1.Location = new Point(386, 90);
            label1.Name = "label1";
            label1.Size = new Size(1215, 109);
            label1.TabIndex = 176;
            label1.Text = "BARANGAY INDIGENCY";
            // 
            // signUpLogo
            // 
            signUpLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(1054, 366);
            signUpLogo.Margin = new Padding(0);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(630, 488);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 188;
            signUpLogo.TabStop = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            label10.Location = new Point(448, 878);
            label10.Name = "label10";
            label10.Size = new Size(350, 33);
            label10.TabIndex = 193;
            label10.Text = "YEARS OF RECIDENCY";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top;
            textBox5.BackColor = Color.FromArgb(246, 180, 71);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 26.25F);
            textBox5.Location = new Point(266, 918);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(707, 54);
            textBox5.TabIndex = 192;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(284, 337);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 55);
            panel2.TabIndex = 194;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Location = new Point(278, 511);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 55);
            panel1.TabIndex = 195;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Location = new Point(281, 649);
            panel3.Name = "panel3";
            panel3.Size = new Size(700, 55);
            panel3.TabIndex = 195;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MidnightBlue;
            panel4.Location = new Point(282, 794);
            panel4.Name = "panel4";
            panel4.Size = new Size(700, 55);
            panel4.TabIndex = 195;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MidnightBlue;
            panel5.Location = new Point(283, 923);
            panel5.Name = "panel5";
            panel5.Size = new Size(700, 55);
            panel5.TabIndex = 195;
            // 
            // FormIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(label10);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(signUpLogo);
            Controls.Add(backCourt);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Name = "FormIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BARANGAY INDIGENCY";
            Load += FormIn_Load;
            ((System.ComponentModel.ISupportInitialize)signUpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormIn_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Button backCourt;
        private TextBox textBox4;
        private Label label9;
        private Button button1;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private PictureBox signUpLogo;
        private Label label10;
        private TextBox textBox5;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}