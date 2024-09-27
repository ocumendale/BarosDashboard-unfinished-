namespace BarosDashboard
{
    partial class brgyIdNext
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(brgyIdNext));
            labelHeight = new Label();
            textBoxHeight = new TextBox();
            labelWeight = new Label();
            textBoxWeight = new TextBox();
            labelBloodType = new Label();
            bloodTypeBox = new ComboBox();
            labelBirthday = new Label();
            dateTimePickerBirthday = new DateTimePicker();
            labelSex = new Label();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            labelCivilStatus = new Label();
            radioButtonSingle = new RadioButton();
            Married = new RadioButton();
            radioButtonDivorced = new RadioButton();
            radioButtonWidowed = new RadioButton();
            labelPrecinctNumber = new Label();
            textBoxPrecinctNumber = new TextBox();
            buttonNext1 = new Button();
            label2 = new Label();
            label1 = new Label();
            signUpLogo = new PictureBox();
            backId = new Button();
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)signUpLogo).BeginInit();
            SuspendLayout();
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeight.Location = new Point(283, 348);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(150, 47);
            labelHeight.TabIndex = 2;
            labelHeight.Text = "HEIGHT";
            labelHeight.Click += label1_Click;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxHeight.Location = new Point(283, 398);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(284, 39);
            textBoxHeight.TabIndex = 3;
            textBoxHeight.TextChanged += textBoxHeight_TextChanged;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            labelWeight.Location = new Point(283, 463);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(158, 47);
            labelWeight.TabIndex = 4;
            labelWeight.Text = "WEIGHT";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Font = new Font("Segoe UI", 18F);
            textBoxWeight.Location = new Point(283, 513);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(284, 39);
            textBoxWeight.TabIndex = 5;
            // 
            // labelBloodType
            // 
            labelBloodType.AutoSize = true;
            labelBloodType.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            labelBloodType.Location = new Point(283, 591);
            labelBloodType.Name = "labelBloodType";
            labelBloodType.Size = new Size(233, 47);
            labelBloodType.TabIndex = 6;
            labelBloodType.Text = "BLOOD TYPE";
            // 
            // bloodTypeBox
            // 
            bloodTypeBox.Font = new Font("Segoe UI", 18F);
            bloodTypeBox.FormattingEnabled = true;
            bloodTypeBox.Items.AddRange(new object[] { "\"A+\", \"A-\", \"B+\", \"B-\", \"O+\", \"O-\", \"AB+\", \"AB-\"" });
            bloodTypeBox.Location = new Point(283, 639);
            bloodTypeBox.Name = "bloodTypeBox";
            bloodTypeBox.Size = new Size(121, 40);
            bloodTypeBox.TabIndex = 7;
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            labelBirthday.Location = new Point(283, 708);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(191, 47);
            labelBirthday.TabIndex = 8;
            labelBirthday.Text = "BIRTHDAY";
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Font = new Font("Segoe UI", 18F);
            dateTimePickerBirthday.Location = new Point(283, 778);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(394, 39);
            dateTimePickerBirthday.TabIndex = 9;
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            labelSex.Location = new Point(634, 351);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(78, 47);
            labelSex.TabIndex = 10;
            labelSex.Text = "Sex";
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Segoe UI", 18F);
            radioButtonMale.Location = new Point(634, 401);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(85, 36);
            radioButtonMale.TabIndex = 11;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            radioButtonMale.CheckedChanged += radioButtonMale_CheckedChanged;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Segoe UI", 18F);
            radioButtonFemale.Location = new Point(728, 401);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(109, 36);
            radioButtonFemale.TabIndex = 12;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // labelCivilStatus
            // 
            labelCivilStatus.AutoSize = true;
            labelCivilStatus.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            labelCivilStatus.Location = new Point(634, 466);
            labelCivilStatus.Name = "labelCivilStatus";
            labelCivilStatus.Size = new Size(203, 47);
            labelCivilStatus.TabIndex = 13;
            labelCivilStatus.Text = "Civil Status";
            // 
            // radioButtonSingle
            // 
            radioButtonSingle.AutoSize = true;
            radioButtonSingle.Font = new Font("Segoe UI", 18F);
            radioButtonSingle.Location = new Point(649, 519);
            radioButtonSingle.Name = "radioButtonSingle";
            radioButtonSingle.Size = new Size(98, 36);
            radioButtonSingle.TabIndex = 14;
            radioButtonSingle.TabStop = true;
            radioButtonSingle.Text = "Single";
            radioButtonSingle.UseVisualStyleBackColor = true;
            // 
            // Married
            // 
            Married.AutoSize = true;
            Married.Font = new Font("Segoe UI", 18F);
            Married.Location = new Point(799, 519);
            Married.Name = "Married";
            Married.Size = new Size(115, 36);
            Married.TabIndex = 15;
            Married.TabStop = true;
            Married.Text = "Married";
            Married.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivorced
            // 
            radioButtonDivorced.AutoSize = true;
            radioButtonDivorced.Font = new Font("Segoe UI", 18F);
            radioButtonDivorced.Location = new Point(649, 549);
            radioButtonDivorced.Name = "radioButtonDivorced";
            radioButtonDivorced.Size = new Size(127, 36);
            radioButtonDivorced.TabIndex = 16;
            radioButtonDivorced.TabStop = true;
            radioButtonDivorced.Text = "Divorced";
            radioButtonDivorced.UseVisualStyleBackColor = true;
            // 
            // radioButtonWidowed
            // 
            radioButtonWidowed.AutoSize = true;
            radioButtonWidowed.Font = new Font("Segoe UI", 18F);
            radioButtonWidowed.Location = new Point(799, 553);
            radioButtonWidowed.Name = "radioButtonWidowed";
            radioButtonWidowed.Size = new Size(132, 36);
            radioButtonWidowed.TabIndex = 17;
            radioButtonWidowed.TabStop = true;
            radioButtonWidowed.Text = "Widowed";
            radioButtonWidowed.UseVisualStyleBackColor = true;
            // 
            // labelPrecinctNumber
            // 
            labelPrecinctNumber.AutoSize = true;
            labelPrecinctNumber.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            labelPrecinctNumber.Location = new Point(649, 594);
            labelPrecinctNumber.Name = "labelPrecinctNumber";
            labelPrecinctNumber.Size = new Size(300, 47);
            labelPrecinctNumber.TabIndex = 18;
            labelPrecinctNumber.Text = "Precinct Number";
            labelPrecinctNumber.Click += labelPrecinctNumber_Click;
            // 
            // textBoxPrecinctNumber
            // 
            textBoxPrecinctNumber.Font = new Font("Segoe UI", 18F);
            textBoxPrecinctNumber.Location = new Point(649, 659);
            textBoxPrecinctNumber.Name = "textBoxPrecinctNumber";
            textBoxPrecinctNumber.Size = new Size(282, 39);
            textBoxPrecinctNumber.TabIndex = 19;
            // 
            // buttonNext1
            // 
            buttonNext1.BackColor = Color.FromArgb(24, 25, 56);
            buttonNext1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            buttonNext1.ForeColor = Color.FromArgb(246, 180, 71);
            buttonNext1.Location = new Point(508, 890);
            buttonNext1.Name = "buttonNext1";
            buttonNext1.Size = new Size(239, 74);
            buttonNext1.TabIndex = 20;
            buttonNext1.Text = "NEXT";
            buttonNext1.UseVisualStyleBackColor = false;
            buttonNext1.Click += buttonNext1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(669, 218);
            label2.Name = "label2";
            label2.Size = new Size(516, 30);
            label2.TabIndex = 130;
            label2.Text = "FILL OUT THIS FORM FOR RESERVATION OF FORM";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(576, 90);
            label1.Name = "label1";
            label1.Size = new Size(705, 128);
            label1.TabIndex = 147;
            label1.Text = "BARANGAY ID";
            // 
            // signUpLogo
            // 
            signUpLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUpLogo.Image = (Image)resources.GetObject("signUpLogo.Image");
            signUpLogo.Location = new Point(955, 328);
            signUpLogo.Margin = new Padding(0);
            signUpLogo.Name = "signUpLogo";
            signUpLogo.Size = new Size(800, 592);
            signUpLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpLogo.TabIndex = 159;
            signUpLogo.TabStop = false;
            // 
            // backId
            // 
            backId.BackColor = Color.Goldenrod;
            backId.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            backId.Location = new Point(12, 12);
            backId.Name = "backId";
            backId.Size = new Size(97, 53);
            backId.TabIndex = 160;
            backId.Text = "Back";
            backId.UseVisualStyleBackColor = false;
            backId.Click += backId_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 18F);
            radioButton1.Location = new Point(843, 401);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(103, 36);
            radioButton1.TabIndex = 161;
            radioButton1.TabStop = true;
            radioButton1.Text = "Others";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // brgyIdNext
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 180, 71);
            ClientSize = new Size(1911, 1118);
            Controls.Add(radioButton1);
            Controls.Add(backId);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(buttonNext1);
            Controls.Add(textBoxPrecinctNumber);
            Controls.Add(labelPrecinctNumber);
            Controls.Add(radioButtonWidowed);
            Controls.Add(radioButtonDivorced);
            Controls.Add(Married);
            Controls.Add(radioButtonSingle);
            Controls.Add(labelCivilStatus);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
            Controls.Add(labelSex);
            Controls.Add(dateTimePickerBirthday);
            Controls.Add(labelBirthday);
            Controls.Add(bloodTypeBox);
            Controls.Add(labelBloodType);
            Controls.Add(textBoxWeight);
            Controls.Add(labelWeight);
            Controls.Add(textBoxHeight);
            Controls.Add(labelHeight);
            Controls.Add(signUpLogo);
            Name = "brgyIdNext";
            Text = "Form20";
            Load += Form20_Load;
            ((System.ComponentModel.ISupportInitialize)signUpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelHeight;
        private TextBox textBoxHeight;
        private Label labelWeight;
        private TextBox textBoxWeight;
        private Label labelBloodType;
        private ComboBox bloodTypeBox;
        private Label labelBirthday;
        private DateTimePicker dateTimePickerBirthday;
        private Label labelSex;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private Label labelCivilStatus;
        private RadioButton radioButtonSingle;
        private RadioButton Married;
        private RadioButton radioButtonDivorced;
        private RadioButton radioButtonWidowed;
        private Label labelPrecinctNumber;
        private TextBox textBoxPrecinctNumber;
        private Button buttonNext1;
        private Label label2;
        private Label label1;
        private PictureBox signUpLogo;
        private Button backId;
        private RadioButton radioButton1;
    }
}