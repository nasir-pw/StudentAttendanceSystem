namespace Student_Attendance_System_Using_Barcode
{
    partial class Teacher_Login
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
            this.teacherLoginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.teacherIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacherLoginButton
            // 
            this.teacherLoginButton.Location = new System.Drawing.Point(119, 102);
            this.teacherLoginButton.Name = "teacherLoginButton";
            this.teacherLoginButton.Size = new System.Drawing.Size(170, 31);
            this.teacherLoginButton.TabIndex = 9;
            this.teacherLoginButton.Text = "LogIn";
            this.teacherLoginButton.UseVisualStyleBackColor = true;
            this.teacherLoginButton.Click += new System.EventHandler(this.teacherLoginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teacher ID :";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(119, 59);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(170, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // teacherIdTextBox
            // 
            this.teacherIdTextBox.Location = new System.Drawing.Point(119, 33);
            this.teacherIdTextBox.Name = "teacherIdTextBox";
            this.teacherIdTextBox.Size = new System.Drawing.Size(170, 20);
            this.teacherIdTextBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.groupBox1.Controls.Add(this.teacherLoginButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.teacherIdTextBox);
            this.groupBox1.Location = new System.Drawing.Point(119, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 157);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // Teacher_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 302);
            this.Controls.Add(this.groupBox1);
            this.Name = "Teacher_Login";
            this.Text = "Teacher_Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button teacherLoginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox teacherIdTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}