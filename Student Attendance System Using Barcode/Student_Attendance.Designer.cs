namespace Student_Attendance_System_Using_Barcode
{
    partial class Student_AttendanceForm
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
            this.teacherLoginBtn = new System.Windows.Forms.Button();
            this.studentLoginBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stIDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacherLoginBtn
            // 
            this.teacherLoginBtn.Location = new System.Drawing.Point(29, 19);
            this.teacherLoginBtn.Name = "teacherLoginBtn";
            this.teacherLoginBtn.Size = new System.Drawing.Size(102, 46);
            this.teacherLoginBtn.TabIndex = 0;
            this.teacherLoginBtn.Text = "Teacher Login";
            this.teacherLoginBtn.UseVisualStyleBackColor = true;
            this.teacherLoginBtn.Click += new System.EventHandler(this.teacherLoginBtn_Click);
            // 
            // studentLoginBtn
            // 
            this.studentLoginBtn.Location = new System.Drawing.Point(29, 85);
            this.studentLoginBtn.Name = "studentLoginBtn";
            this.studentLoginBtn.Size = new System.Drawing.Size(102, 46);
            this.studentLoginBtn.TabIndex = 1;
            this.studentLoginBtn.Text = "Student Login";
            this.studentLoginBtn.UseVisualStyleBackColor = true;
            this.studentLoginBtn.Click += new System.EventHandler(this.studentLoginBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stIDTextBox);
            this.groupBox1.Location = new System.Drawing.Point(216, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 218);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Scan Your Card";
            // 
            // stIDTextBox
            // 
            this.stIDTextBox.Location = new System.Drawing.Point(86, 82);
            this.stIDTextBox.Name = "stIDTextBox";
            this.stIDTextBox.Size = new System.Drawing.Size(154, 20);
            this.stIDTextBox.TabIndex = 0;
            this.stIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stIDTextBox.TextChanged += new System.EventHandler(this.stIDTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.adminLoginButton);
            this.groupBox2.Controls.Add(this.studentLoginBtn);
            this.groupBox2.Controls.Add(this.teacherLoginBtn);
            this.groupBox2.Location = new System.Drawing.Point(27, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 218);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.Location = new System.Drawing.Point(29, 154);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(102, 46);
            this.adminLoginButton.TabIndex = 2;
            this.adminLoginButton.Text = "Admin Login";
            this.adminLoginButton.UseVisualStyleBackColor = true;
            this.adminLoginButton.Click += new System.EventHandler(this.adminLoginButton_Click);
            // 
            // Student_AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 302);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Student_AttendanceForm";
            this.Text = "Student Attendance System";
            this.Load += new System.EventHandler(this.Student_AttendanceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button teacherLoginBtn;
        private System.Windows.Forms.Button studentLoginBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button adminLoginButton;
        private System.Windows.Forms.TextBox stIDTextBox;
        private System.Windows.Forms.Label label1;
    }
}

