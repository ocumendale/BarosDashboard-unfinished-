namespace BarosDashboard
{
    partial class cam
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
            components = new System.ComponentModel.Container();
            camlabel = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // camlabel
            // 
            camlabel.AutoSize = true;
            camlabel.Location = new Point(96, 26);
            camlabel.Name = "camlabel";
            camlabel.Size = new Size(48, 15);
            camlabel.TabIndex = 0;
            camlabel.Text = "Camera";
            camlabel.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(177, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 23);
            comboBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(54, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(595, 393);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(707, 52);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(834, 52);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Read";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(666, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 23);
            textBox1.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // cam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 467);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(camlabel);
            Name = "cam";
            Text = "cam";
            FormClosing += cam_FormClosing;
            Load += cam_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label camlabel;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}