﻿namespace BarosDashboard
{
    partial class ResidentsAssistance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentsAssistance));
            panel1 = new Panel();
            reg_btn = new Button();
            Events = new Button();
            ResAssist = new Button();
            DocuReq = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            baros = new Label();
            panel4 = new Panel();
            GeneratePDF = new Button();
            rejectbtn = new Button();
            acceptbtn = new Button();
            dataGridView2 = new DataGridView();
            Basketball = new Button();
            Tent = new Button();
            Table = new Button();
            Chair = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 180, 71);
            panel1.Controls.Add(reg_btn);
            panel1.Controls.Add(Events);
            panel1.Controls.Add(ResAssist);
            panel1.Controls.Add(DocuReq);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 1199);
            panel1.TabIndex = 3;
            // 
            // reg_btn
            // 
            reg_btn.FlatAppearance.BorderSize = 0;
            reg_btn.FlatStyle = FlatStyle.Flat;
            reg_btn.Font = new Font("Yu Gothic UI", 20.25F);
            reg_btn.Location = new Point(59, 753);
            reg_btn.Name = "reg_btn";
            reg_btn.Size = new Size(342, 100);
            reg_btn.TabIndex = 8;
            reg_btn.Text = "REGISTRATION";
            reg_btn.TextAlign = ContentAlignment.MiddleLeft;
            reg_btn.UseVisualStyleBackColor = true;
            reg_btn.Click += reg_btn_Click;
            // 
            // Events
            // 
            Events.FlatAppearance.BorderSize = 0;
            Events.FlatStyle = FlatStyle.Flat;
            Events.Font = new Font("Yu Gothic UI", 20.25F);
            Events.Location = new Point(59, 859);
            Events.Name = "Events";
            Events.Size = new Size(342, 100);
            Events.TabIndex = 7;
            Events.Text = "SIGN OUT";
            Events.TextAlign = ContentAlignment.MiddleLeft;
            Events.UseVisualStyleBackColor = true;
            Events.Click += Events_Click;
            // 
            // ResAssist
            // 
            ResAssist.FlatAppearance.BorderSize = 0;
            ResAssist.FlatStyle = FlatStyle.Flat;
            ResAssist.Font = new Font("Yu Gothic UI", 20.25F);
            ResAssist.ForeColor = Color.MidnightBlue;
            ResAssist.Location = new Point(59, 647);
            ResAssist.Name = "ResAssist";
            ResAssist.Size = new Size(342, 100);
            ResAssist.TabIndex = 3;
            ResAssist.Text = "RESERVATION";
            ResAssist.TextAlign = ContentAlignment.MiddleLeft;
            ResAssist.UseVisualStyleBackColor = true;
            // 
            // DocuReq
            // 
            DocuReq.FlatAppearance.BorderSize = 0;
            DocuReq.FlatStyle = FlatStyle.Flat;
            DocuReq.Font = new Font("Yu Gothic UI", 20.25F);
            DocuReq.Location = new Point(59, 541);
            DocuReq.Name = "DocuReq";
            DocuReq.Size = new Size(342, 100);
            DocuReq.TabIndex = 2;
            DocuReq.Text = "DOCUMENT REQUEST";
            DocuReq.TextAlign = ContentAlignment.MiddleLeft;
            DocuReq.UseVisualStyleBackColor = true;
            DocuReq.Click += DocuReq_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 387);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(142, 331);
            label1.Name = "label1";
            label1.Size = new Size(210, 37);
            label1.TabIndex = 1;
            label1.Text = "HELLO, ADMIN!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(133, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 202);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveBorder;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(609, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(1239, 75);
            panel3.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(75, 24);
            label2.Name = "label2";
            label2.Size = new Size(464, 43);
            label2.TabIndex = 0;
            label2.Text = "RESIDENT ASSISTANCE";
            // 
            // baros
            // 
            baros.AutoSize = true;
            baros.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            baros.Location = new Point(609, 25);
            baros.Name = "baros";
            baros.Size = new Size(827, 37);
            baros.TabIndex = 15;
            baros.Text = "BARANGAY ASSISTANCE AND REQUEST OF DOCUMENTS SYSTEM";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.InactiveBorder;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(GeneratePDF);
            panel4.Controls.Add(rejectbtn);
            panel4.Controls.Add(acceptbtn);
            panel4.Controls.Add(dataGridView2);
            panel4.Controls.Add(Basketball);
            panel4.Controls.Add(Tent);
            panel4.Controls.Add(Table);
            panel4.Controls.Add(Chair);
            panel4.Location = new Point(609, 215);
            panel4.Name = "panel4";
            panel4.Size = new Size(1236, 927);
            panel4.TabIndex = 14;
            panel4.Paint += panel4_Paint;
            // 
            // GeneratePDF
            // 
            GeneratePDF.BackColor = Color.MidnightBlue;
            GeneratePDF.FlatAppearance.BorderSize = 0;
            GeneratePDF.FlatStyle = FlatStyle.Flat;
            GeneratePDF.Font = new Font("Lucida Fax", 15.75F, FontStyle.Bold);
            GeneratePDF.ForeColor = Color.FromArgb(246, 180, 71);
            GeneratePDF.Location = new Point(517, 735);
            GeneratePDF.Name = "GeneratePDF";
            GeneratePDF.Size = new Size(208, 77);
            GeneratePDF.TabIndex = 11;
            GeneratePDF.Text = "GENERATE FILE PDF";
            GeneratePDF.UseVisualStyleBackColor = false;
            GeneratePDF.Click += GeneratePDF_Click;
            // 
            // rejectbtn
            // 
            rejectbtn.BackColor = Color.MidnightBlue;
            rejectbtn.FlatAppearance.BorderSize = 0;
            rejectbtn.FlatStyle = FlatStyle.Flat;
            rejectbtn.Font = new Font("Lucida Fax", 15.75F, FontStyle.Bold);
            rejectbtn.ForeColor = Color.FromArgb(246, 180, 71);
            rejectbtn.Location = new Point(839, 735);
            rejectbtn.Name = "rejectbtn";
            rejectbtn.Size = new Size(208, 77);
            rejectbtn.TabIndex = 10;
            rejectbtn.Text = "REJECT";
            rejectbtn.UseVisualStyleBackColor = false;
            rejectbtn.Click += rejectbtn_Click_1;
            // 
            // acceptbtn
            // 
            acceptbtn.BackColor = Color.MidnightBlue;
            acceptbtn.FlatAppearance.BorderSize = 0;
            acceptbtn.FlatStyle = FlatStyle.Flat;
            acceptbtn.Font = new Font("Lucida Fax", 15.75F, FontStyle.Bold);
            acceptbtn.ForeColor = Color.FromArgb(246, 180, 71);
            acceptbtn.Location = new Point(186, 732);
            acceptbtn.Name = "acceptbtn";
            acceptbtn.Size = new Size(208, 77);
            acceptbtn.TabIndex = 9;
            acceptbtn.Text = "ACCEPT";
            acceptbtn.UseVisualStyleBackColor = false;
            acceptbtn.Click += acceptbtn_Click_1;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.MidnightBlue;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.FromArgb(246, 180, 71);
            dataGridView2.Location = new Point(40, 142);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1143, 535);
            dataGridView2.TabIndex = 4;
            // 
            // Basketball
            // 
            Basketball.BackColor = Color.MidnightBlue;
            Basketball.FlatAppearance.BorderSize = 0;
            Basketball.FlatStyle = FlatStyle.Flat;
            Basketball.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Basketball.ForeColor = Color.FromArgb(246, 180, 71);
            Basketball.Location = new Point(40, 29);
            Basketball.Name = "Basketball";
            Basketball.Size = new Size(241, 85);
            Basketball.TabIndex = 3;
            Basketball.Text = "BASKETBALL COURT";
            Basketball.UseVisualStyleBackColor = false;
            Basketball.Click += Basketball_Click;
            // 
            // Tent
            // 
            Tent.BackColor = Color.MidnightBlue;
            Tent.FlatAppearance.BorderSize = 0;
            Tent.FlatStyle = FlatStyle.Flat;
            Tent.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            Tent.ForeColor = Color.FromArgb(246, 180, 71);
            Tent.Location = new Point(348, 29);
            Tent.Name = "Tent";
            Tent.Size = new Size(241, 85);
            Tent.TabIndex = 2;
            Tent.Tag = "";
            Tent.Text = "TENT";
            Tent.UseVisualStyleBackColor = false;
            Tent.Click += Tent_Click;
            // 
            // Table
            // 
            Table.BackColor = Color.MidnightBlue;
            Table.FlatAppearance.BorderSize = 0;
            Table.FlatStyle = FlatStyle.Flat;
            Table.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            Table.ForeColor = Color.FromArgb(246, 180, 71);
            Table.Location = new Point(650, 29);
            Table.Name = "Table";
            Table.Size = new Size(241, 85);
            Table.TabIndex = 1;
            Table.Text = "TABLE";
            Table.UseVisualStyleBackColor = false;
            Table.Click += Table_Click;
            // 
            // Chair
            // 
            Chair.BackColor = Color.MidnightBlue;
            Chair.FlatAppearance.BorderSize = 0;
            Chair.FlatStyle = FlatStyle.Flat;
            Chair.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            Chair.ForeColor = Color.FromArgb(246, 180, 71);
            Chair.Location = new Point(942, 29);
            Chair.Name = "Chair";
            Chair.Size = new Size(241, 85);
            Chair.TabIndex = 0;
            Chair.Text = "CHAIR";
            Chair.UseVisualStyleBackColor = false;
            Chair.Click += Chair_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MidnightBlue;
            panel5.Location = new Point(610, 114);
            panel5.Name = "panel5";
            panel5.Size = new Size(1236, 33);
            panel5.TabIndex = 16;
            // 
            // panel6
            // 
            panel6.BackColor = Color.MidnightBlue;
            panel6.Location = new Point(609, 210);
            panel6.Name = "panel6";
            panel6.Size = new Size(1236, 100);
            panel6.TabIndex = 17;
            // 
            // panel7
            // 
            panel7.BackColor = Color.MidnightBlue;
            panel7.Location = new Point(496, 408);
            panel7.Name = "panel7";
            panel7.Size = new Size(1422, 160);
            panel7.TabIndex = 18;
            // 
            // ResidentsAssistance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1911, 1118);
            Controls.Add(panel3);
            Controls.Add(baros);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Name = "ResidentsAssistance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResidentsAssistance";
            Load += ResidentsAssistance_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button Events;
        private Button ResAssist;
        private Button DocuReq;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label2;
        private Label baros;
        private Panel panel4;
        private DataGridView dataGridView2;
        private Button Basketball;
        private Button Tent;
        private Button Table;
        private Button Chair;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Button reg_btn;
        private Button rejectbtn;
        private Button acceptbtn;
        private Button GeneratePDF;
    }
}