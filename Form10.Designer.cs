namespace BarosDashboard
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            pictureBox = new PictureBox();
            panel2 = new Panel();
            Request = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.BackgroundImage = (Image)resources.GetObject("pictureBox.BackgroundImage");
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.ErrorImage = (Image)resources.GetObject("pictureBox.ErrorImage");
            pictureBox.Location = new Point(12, 8);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(49, 26);
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(Request);
            panel2.Location = new Point(12, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 74);
            panel2.TabIndex = 3;
            // 
            // Request
            // 
            Request.AutoSize = true;
            Request.Font = new Font("MS UI Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Request.Location = new Point(298, 37);
            Request.Name = "Request";
            Request.Size = new Size(132, 33);
            Request.TabIndex = 0;
            Request.Text = "Request";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(12, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 323);
            panel1.TabIndex = 2;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form10";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Request";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Panel panel2;
        private Label Request;
        private Panel panel1;
    }
}