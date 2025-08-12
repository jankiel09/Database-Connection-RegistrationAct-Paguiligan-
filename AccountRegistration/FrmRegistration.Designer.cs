namespace AccountRegistration
{
    partial class FrmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistration));
            txtboxStudno = new TextBox();
            txtboxLname = new TextBox();
            txtboxFname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtboxMname = new TextBox();
            txtboxAge = new TextBox();
            txtboxContNo = new TextBox();
            txtboxAddr = new TextBox();
            nextBtn = new Button();
            SuspendLayout();
            // 
            // txtboxStudno
            // 
            txtboxStudno.Location = new Point(12, 27);
            txtboxStudno.Name = "txtboxStudno";
            txtboxStudno.Size = new Size(162, 23);
            txtboxStudno.TabIndex = 0;
            // 
            // txtboxLname
            // 
            txtboxLname.Location = new Point(12, 80);
            txtboxLname.Name = "txtboxLname";
            txtboxLname.Size = new Size(162, 23);
            txtboxLname.TabIndex = 2;
            // 
            // txtboxFname
            // 
            txtboxFname.Location = new Point(188, 80);
            txtboxFname.Name = "txtboxFname";
            txtboxFname.Size = new Size(162, 23);
            txtboxFname.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 8;
            label1.Text = "Student No.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(188, 9);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 10;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.White;
            label4.Location = new Point(188, 62);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 11;
            label4.Text = "First Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 115);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 12;
            label5.Text = "Age:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.White;
            label6.Location = new Point(188, 115);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 13;
            label6.Text = "Contact No.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 170);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 14;
            label7.Text = "Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.White;
            label8.Location = new Point(364, 62);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 15;
            label8.Text = "Middle Name";
            // 
            // txtboxMname
            // 
            txtboxMname.Location = new Point(364, 80);
            txtboxMname.Name = "txtboxMname";
            txtboxMname.Size = new Size(162, 23);
            txtboxMname.TabIndex = 16;
            // 
            // txtboxAge
            // 
            txtboxAge.Location = new Point(12, 133);
            txtboxAge.Name = "txtboxAge";
            txtboxAge.Size = new Size(162, 23);
            txtboxAge.TabIndex = 17;
            txtboxAge.TextChanged += textBox10_TextChanged;
            // 
            // txtboxContNo
            // 
            txtboxContNo.Location = new Point(188, 133);
            txtboxContNo.Name = "txtboxContNo";
            txtboxContNo.Size = new Size(162, 23);
            txtboxContNo.TabIndex = 18;
            // 
            // txtboxAddr
            // 
            txtboxAddr.Location = new Point(14, 190);
            txtboxAddr.MaximumSize = new Size(1000, 1000);
            txtboxAddr.Multiline = true;
            txtboxAddr.Name = "txtboxAddr";
            txtboxAddr.Size = new Size(513, 212);
            txtboxAddr.TabIndex = 19;
            // 
            // nextBtn
            // 
            nextBtn.BackColor = Color.White;
            nextBtn.FlatAppearance.BorderColor = Color.LightYellow;
            nextBtn.FlatAppearance.BorderSize = 2;
            nextBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextBtn.ForeColor = Color.Black;
            nextBtn.Location = new Point(226, 412);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(81, 26);
            nextBtn.TabIndex = 22;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(541, 450);
            Controls.Add(nextBtn);
            Controls.Add(txtboxAddr);
            Controls.Add(txtboxContNo);
            Controls.Add(txtboxAge);
            Controls.Add(txtboxMname);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtboxFname);
            Controls.Add(txtboxLname);
            Controls.Add(txtboxStudno);
            Name = "FrmRegistration";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxStudno;
        private TextBox txtboxLname;
        private TextBox txtboxFname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtboxMname;
        private TextBox txtboxAge;
        private TextBox txtboxContNo;
        private TextBox txtboxAddr;
        private Button nextBtn;
    }
}
