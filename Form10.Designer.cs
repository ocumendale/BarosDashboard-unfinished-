namespace BarosDashboard
{
    partial class reserve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reserve));
            Request = new Label();
            backReq = new Button();
            label2 = new Label();
            contact = new TextBox();
            panel1 = new Panel();
            label9 = new Label();
            button1 = new Button();
            label12 = new Label();
            label11 = new Label();
            quantity = new TextBox();
            label10 = new Label();
            reqbox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Fname = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            resType = new ComboBox();
            label1 = new Label();
            date1 = new DateTimePicker();
            time = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Request
            // 
            Request.AutoSize = true;
            Request.Font = new Font("Lucida Fax", 72F, FontStyle.Bold);
            Request.Location = new Point(571, 27);
            Request.Name = "Request";
            Request.Size = new Size(762, 109);
            Request.TabIndex = 0;
            Request.Text = "RESERVATION";
            Request.Click += Request_Click;
            // 
            // backReq
            // 
            backReq.BackColor = Color.MidnightBlue;
            backReq.FlatAppearance.BorderSize = 0;
            backReq.FlatStyle = FlatStyle.Flat;
            backReq.Font = new Font("Lucida Fax", 15.75F, FontStyle.Bold);
            backReq.ForeColor = Color.FromArgb(246, 180, 71);
            backReq.Location = new Point(12, 12);
            backReq.Name = "backReq";
            backReq.Size = new Size(97, 53);
            backReq.TabIndex = 4;
            backReq.Text = "Back";
            backReq.UseVisualStyleBackColor = false;
            backReq.Click += backReq_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 27.75F, FontStyle.Bold);
            label2.Location = new Point(865, 159);
            label2.Name = "label2";
            label2.Size = new Size(202, 43);
            label2.TabIndex = 8;
            label2.Text = "SERVICES";
            // 
            // contact
            // 
            contact.Anchor = AnchorStyles.Left;
            contact.BackColor = Color.FromArgb(246, 180, 71);
            contact.BorderStyle = BorderStyle.FixedSingle;
            contact.Font = new Font("Segoe UI", 26.25F);
            contact.Location = new Point(229, 438);
            contact.Name = "contact";
            contact.Size = new Size(707, 54);
            contact.TabIndex = 153;
            contact.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Location = new Point(243, 447);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 56);
            panel1.TabIndex = 165;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label9.Location = new Point(292, 848);
            label9.Name = "label9";
            label9.Size = new Size(65, 22);
            label9.TabIndex = 164;
            label9.Text = "DATE";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.MidnightBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(246, 180, 71);
            button1.Location = new Point(478, 996);
            button1.Name = "button1";
            button1.Size = new Size(186, 63);
            button1.TabIndex = 162;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom;
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label12.Location = new Point(853, 848);
            label12.Name = "label12";
            label12.Size = new Size(117, 22);
            label12.TabIndex = 160;
            label12.Text = "QUANTITY";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            label11.Location = new Point(384, 779);
            label11.Name = "label11";
            label11.Size = new Size(423, 33);
            label11.TabIndex = 159;
            label11.Text = "DETAILS OF RESERVATION";
            // 
            // quantity
            // 
            quantity.Anchor = AnchorStyles.Bottom;
            quantity.BackColor = Color.FromArgb(246, 180, 71);
            quantity.BorderStyle = BorderStyle.FixedSingle;
            quantity.Font = new Font("Segoe UI", 12F);
            quantity.Location = new Point(828, 879);
            quantity.Name = "quantity";
            quantity.Size = new Size(160, 29);
            quantity.TabIndex = 158;
            quantity.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            label10.Location = new Point(642, 851);
            label10.Name = "label10";
            label10.Size = new Size(60, 22);
            label10.TabIndex = 157;
            label10.Text = "TIME";
            // 
            // reqbox
            // 
            reqbox.Anchor = AnchorStyles.Right;
            reqbox.BackColor = Color.FromArgb(246, 180, 71);
            reqbox.BorderStyle = BorderStyle.FixedSingle;
            reqbox.Font = new Font("Segoe UI", 26.25F);
            reqbox.Location = new Point(229, 591);
            reqbox.Name = "reqbox";
            reqbox.Size = new Size(707, 54);
            reqbox.TabIndex = 155;
            reqbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            label8.Location = new Point(414, 551);
            label8.Name = "label8";
            label8.Size = new Size(342, 33);
            label8.TabIndex = 154;
            label8.Text = "REASON OF REQUEST";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            label7.Location = new Point(431, 395);
            label7.Name = "label7";
            label7.Size = new Size(308, 33);
            label7.TabIndex = 152;
            label7.Text = "CONTACT NUMBER";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Yu Gothic UI", 18F);
            label6.Location = new Point(755, 319);
            label6.Name = "label6";
            label6.Size = new Size(166, 32);
            label6.TabIndex = 151;
            label6.Text = "MIDDLENAME";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Yu Gothic UI", 18F);
            label5.Location = new Point(248, 316);
            label5.Name = "label5";
            label5.Size = new Size(133, 32);
            label5.TabIndex = 150;
            label5.Text = "LASTNAME";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Yu Gothic UI", 18F);
            label4.Location = new Point(502, 319);
            label4.Name = "label4";
            label4.Size = new Size(139, 32);
            label4.TabIndex = 149;
            label4.Text = "FIRSTNAME";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            label3.Location = new Point(485, 209);
            label3.Name = "label3";
            label3.Size = new Size(190, 33);
            label3.TabIndex = 148;
            label3.Text = "FULL NAME";
            // 
            // Fname
            // 
            Fname.Anchor = AnchorStyles.Top;
            Fname.BackColor = Color.FromArgb(246, 180, 71);
            Fname.BorderStyle = BorderStyle.FixedSingle;
            Fname.Font = new Font("Segoe UI", 26.25F);
            Fname.Location = new Point(229, 250);
            Fname.Name = "Fname";
            Fname.Size = new Size(707, 54);
            Fname.TabIndex = 147;
            Fname.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1039, 254);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 488);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 163;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(247, 254);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 55);
            panel2.TabIndex = 166;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Location = new Point(252, 600);
            panel3.Name = "panel3";
            panel3.Size = new Size(699, 56);
            panel3.TabIndex = 167;
            // 
            // panel6
            // 
            panel6.BackColor = Color.MidnightBlue;
            panel6.Location = new Point(839, 894);
            panel6.Name = "panel6";
            panel6.Size = new Size(159, 30);
            panel6.TabIndex = 170;
            // 
            // resType
            // 
            resType.BackColor = Color.FromArgb(246, 180, 71);
            resType.Font = new Font("Segoe UI", 18F);
            resType.FormattingEnabled = true;
            resType.Items.AddRange(new object[] { "BASKETBALL COURT", "TENT", "CHAIR", "TABLE" });
            resType.Location = new Point(447, 729);
            resType.Name = "resType";
            resType.Size = new Size(292, 40);
            resType.TabIndex = 203;
            resType.SelectedIndexChanged += resType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold);
            label1.Location = new Point(414, 680);
            label1.Name = "label1";
            label1.Size = new Size(370, 33);
            label1.TabIndex = 204;
            label1.Text = "TYPE OF RESERVATION";
            // 
            // date1
            // 
            date1.CalendarMonthBackground = Color.FromArgb(246, 180, 71);
            date1.CalendarTitleBackColor = Color.FromArgb(246, 180, 71);
            date1.CalendarTitleForeColor = Color.FromArgb(246, 180, 71);
            date1.CalendarTrailingForeColor = Color.FromArgb(246, 180, 71);
            date1.Cursor = Cursors.IBeam;
            date1.Font = new Font("Lucida Fax", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date1.Location = new Point(100, 878);
            date1.Name = "date1";
            date1.Size = new Size(435, 36);
            date1.TabIndex = 205;
            // 
            // time
            // 
            time.BackColor = Color.FromArgb(246, 180, 71);
            time.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            time.FormattingEnabled = true;
            time.Items.AddRange(new object[] { "09:00 AM - 11:00 AM", "11:00 AM - 01:00 PM", "01:00 PM - 03:00 PM", "03:00 PM - 05:00 PM", "05:00 PM - 07:00 PM", "07:00 PM - 09:00 PM", "09:00 PM - 11:00 PM" });
            time.Location = new Point(574, 881);
            time.Name = "time";
            time.Size = new Size(233, 30);
            time.TabIndex = 206;
            time.SelectedIndexChanged += time_SelectedIndexChanged;
            // 
            // reserve
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(time);
            Controls.Add(date1);
            Controls.Add(label1);
            Controls.Add(resType);
            Controls.Add(contact);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(quantity);
            Controls.Add(label10);
            Controls.Add(reqbox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Fname);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(label2);
            Controls.Add(Request);
            Controls.Add(backReq);
            Name = "reserve";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation";
            Load += reserve_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Request;
        private Button backReq;
        private Label label2;
        private TextBox contact;
        private Panel panel1;
        private Label label9;
        private Button button1;
        private Label label12;
        private Label label11;
        private TextBox quantity;
        private Label label10;
        private TextBox date;
        private TextBox reqbox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox Fname;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private ComboBox resType;
        private Label label1;
        private DateTimePicker date1;
        private ComboBox time;
    }
}