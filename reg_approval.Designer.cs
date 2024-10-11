namespace BarosDashboard
{
    partial class reg_approval
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            pictureBoxQRCode = new PictureBox();
            btnSaveQR = new Button();
            acceptbtn = new Button();
            rejectbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Fax", 15.75F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(246, 180, 71);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(97, 53);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MidnightBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(886, 770);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.MouseCaptureChanged += MouseClickChanged_;
            // 
            // pictureBoxQRCode
            // 
            pictureBoxQRCode.Location = new Point(997, 81);
            pictureBoxQRCode.Name = "pictureBoxQRCode";
            pictureBoxQRCode.Size = new Size(856, 770);
            pictureBoxQRCode.TabIndex = 4;
            pictureBoxQRCode.TabStop = false;
            pictureBoxQRCode.Click += pictureBoxQRCode_Click;
            // 
            // btnSaveQR
            // 
            btnSaveQR.AccessibleDescription = "";
            btnSaveQR.BackColor = Color.MidnightBlue;
            btnSaveQR.FlatAppearance.BorderSize = 0;
            btnSaveQR.FlatStyle = FlatStyle.Flat;
            btnSaveQR.Font = new Font("Lucida Fax", 15.75F, FontStyle.Bold);
            btnSaveQR.ForeColor = Color.FromArgb(246, 180, 71);
            btnSaveQR.Location = new Point(1333, 901);
            btnSaveQR.Name = "btnSaveQR";
            btnSaveQR.Size = new Size(261, 53);
            btnSaveQR.TabIndex = 6;
            btnSaveQR.Text = "Save QR Code";
            btnSaveQR.UseVisualStyleBackColor = false;
            btnSaveQR.Click += btnSaveQR_Click;
            // 
            // acceptbtn
            // 
            acceptbtn.BackColor = Color.MidnightBlue;
            acceptbtn.FlatAppearance.BorderSize = 0;
            acceptbtn.FlatStyle = FlatStyle.Flat;
            acceptbtn.Font = new Font("Lucida Fax", 15.75F, FontStyle.Bold);
            acceptbtn.ForeColor = Color.FromArgb(246, 180, 71);
            acceptbtn.Location = new Point(173, 901);
            acceptbtn.Name = "acceptbtn";
            acceptbtn.Size = new Size(175, 53);
            acceptbtn.TabIndex = 7;
            acceptbtn.Text = "Accept";
            acceptbtn.UseVisualStyleBackColor = false;
            acceptbtn.Click += acceptbtn_Click;
            // 
            // rejectbtn
            // 
            rejectbtn.BackColor = Color.MidnightBlue;
            rejectbtn.FlatAppearance.BorderSize = 0;
            rejectbtn.FlatStyle = FlatStyle.Flat;
            rejectbtn.Font = new Font("Lucida Fax", 15.75F, FontStyle.Bold);
            rejectbtn.ForeColor = Color.FromArgb(246, 180, 71);
            rejectbtn.Location = new Point(543, 901);
            rejectbtn.Name = "rejectbtn";
            rejectbtn.Size = new Size(175, 53);
            rejectbtn.TabIndex = 8;
            rejectbtn.Text = "Reject";
            rejectbtn.UseVisualStyleBackColor = false;
            rejectbtn.Click += button2_Click;
            // 
            // reg_approval
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(rejectbtn);
            Controls.Add(acceptbtn);
            Controls.Add(btnSaveQR);
            Controls.Add(pictureBoxQRCode);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "reg_approval";
            Text = "reg_approval";
            Load += reg_approval_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private PictureBox pictureBoxQRCode;
        private Button btnSaveQR;
        private Button acceptbtn;
        private Button rejectbtn;
    }
}