namespace BarosDashboard
{
    partial class ManageTransaction
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
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            home = new Button();
            panel3 = new Panel();
            label1 = new Label();
            table = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(478, 110);
            button1.Name = "button1";
            button1.Size = new Size(117, 52);
            button1.TabIndex = 0;
            button1.Text = "Basketball Court";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(461, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1427, 616);
            dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(home);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 1115);
            panel1.TabIndex = 2;
            // 
            // button8
            // 
            button8.Location = new Point(99, 969);
            button8.Name = "button8";
            button8.Size = new Size(181, 71);
            button8.TabIndex = 6;
            button8.Text = "Manage Transaction";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(99, 797);
            button7.Name = "button7";
            button7.Size = new Size(181, 71);
            button7.TabIndex = 5;
            button7.Text = "logout";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(99, 639);
            button6.Name = "button6";
            button6.Size = new Size(181, 71);
            button6.TabIndex = 4;
            button6.Text = "Services";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(99, 478);
            button5.Name = "button5";
            button5.Size = new Size(181, 71);
            button5.TabIndex = 3;
            button5.Text = "How it Works";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(99, 329);
            button4.Name = "button4";
            button4.Size = new Size(181, 71);
            button4.TabIndex = 2;
            button4.Text = "Contact";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(99, 179);
            button3.Name = "button3";
            button3.Size = new Size(181, 71);
            button3.TabIndex = 1;
            button3.Text = "AboutUs";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // home
            // 
            home.Location = new Point(99, 48);
            home.Name = "home";
            home.Size = new Size(181, 71);
            home.TabIndex = 0;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            home.Click += home_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(label1);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(448, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1440, 84);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Size = new Size(324, 33);
            label1.TabIndex = 2;
            label1.Text = "Manage Transaction";
            // 
            // table
            // 
            table.Location = new Point(658, 110);
            table.Name = "table";
            table.Size = new Size(117, 52);
            table.TabIndex = 4;
            table.Text = "Table";
            table.UseVisualStyleBackColor = true;
            table.Click += table_Click;
            // 
            // ManageTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(table);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "ManageTransaction";
            Text = "ManageTransaction";
            Load += ManageTransaction_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button home;
        private Button button8;
        private Button button7;
        private Button button6;
        private Panel panel3;
        private Label label1;
        private Button table;
    }
}