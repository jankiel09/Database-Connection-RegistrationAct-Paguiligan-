namespace AccountRegistration
{
    partial class OrganizationProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizationProfile));
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            txtStudentNo = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbPrograms = new ComboBox();
            label6 = new Label();
            txtMiddleInitial = new TextBox();
            label7 = new Label();
            txtAge = new TextBox();
            cbGender = new ComboBox();
            label8 = new Label();
            txtContactNo = new TextBox();
            label9 = new Label();
            label10 = new Label();
            datePickerBirthday = new DateTimePicker();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Azure;
            btnRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(295, 265);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 34);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(222, 9);
            label1.Name = "label1";
            label1.Size = new Size(248, 53);
            label1.TabIndex = 1;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 82);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Text = "Student No.";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(131, 82);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(158, 23);
            txtStudentNo.TabIndex = 6;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 124);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 7;
            label3.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(131, 124);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(158, 23);
            txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(394, 124);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(158, 23);
            txtFirstName.TabIndex = 12;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(307, 124);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 11;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(320, 82);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 9;
            label5.Text = "Program";
            // 
            // cbPrograms
            // 
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(394, 82);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(261, 23);
            cbPrograms.TabIndex = 13;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(568, 124);
            label6.Name = "label6";
            label6.Size = new Size(36, 23);
            label6.TabIndex = 14;
            label6.Text = "M.I.";
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(610, 124);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(45, 23);
            txtMiddleInitial.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(66, 167);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 16;
            label7.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(131, 166);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(92, 23);
            txtAge.TabIndex = 17;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(394, 168);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(128, 23);
            cbGender.TabIndex = 19;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(320, 168);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 18;
            label8.Text = "Gender";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(446, 222);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(158, 23);
            txtContactNo.TabIndex = 21;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(349, 221);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 20;
            label9.Text = "Contact No.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(35, 221);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 22;
            label10.Text = "Birthday";
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(131, 222);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(200, 23);
            datePickerBirthday.TabIndex = 23;
            // 
            // OrganizationProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(680, 320);
            Controls.Add(datePickerBirthday);
            Controls.Add(label10);
            Controls.Add(txtContactNo);
            Controls.Add(label9);
            Controls.Add(cbGender);
            Controls.Add(label8);
            Controls.Add(txtAge);
            Controls.Add(label7);
            Controls.Add(txtMiddleInitial);
            Controls.Add(label6);
            Controls.Add(cbPrograms);
            Controls.Add(txtFirstName);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtStudentNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Name = "OrganizationProfile";
            Text = "OrganizationProfile";
            Load += OrganizationProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label label1;
        private Label label2;
        private TextBox txtStudentNo;
        private Label label3;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label4;
        private Label label5;
        private ComboBox cbPrograms;
        private Label label6;
        private TextBox txtMiddleInitial;
        private Label label7;
        private TextBox txtAge;
        private ComboBox cbGender;
        private Label label8;
        private TextBox txtContactNo;
        private Label label9;
        private Label label10;
        private DateTimePicker datePickerBirthday;
    }
}