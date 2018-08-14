namespace Student_Attendance_System_Using_Barcode
{
    partial class ViewTeacherProfile
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dNameComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teacherNameTextBox = new System.Windows.Forms.TextBox();
            this.teacherIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teacherUpdateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.designationTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dNameComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.teacherNameTextBox);
            this.groupBox1.Controls.Add(this.teacherIdTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(62, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 224);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(152, 168);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(131, 20);
            this.passwordTextBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Password :";
            // 
            // designationTextBox
            // 
            this.designationTextBox.Location = new System.Drawing.Point(152, 104);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(131, 20);
            this.designationTextBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Designation:";
            // 
            // dNameComboBox
            // 
            this.dNameComboBox.FormattingEnabled = true;
            this.dNameComboBox.Location = new System.Drawing.Point(151, 137);
            this.dNameComboBox.Name = "dNameComboBox";
            this.dNameComboBox.Size = new System.Drawing.Size(131, 21);
            this.dNameComboBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Dept Name :";
            // 
            // teacherNameTextBox
            // 
            this.teacherNameTextBox.Location = new System.Drawing.Point(152, 71);
            this.teacherNameTextBox.Name = "teacherNameTextBox";
            this.teacherNameTextBox.Size = new System.Drawing.Size(131, 20);
            this.teacherNameTextBox.TabIndex = 13;
            // 
            // teacherIdTextBox
            // 
            this.teacherIdTextBox.Location = new System.Drawing.Point(151, 37);
            this.teacherIdTextBox.Name = "teacherIdTextBox";
            this.teacherIdTextBox.Size = new System.Drawing.Size(131, 20);
            this.teacherIdTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Teacher Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Teacher ID :";
            // 
            // teacherUpdateButton
            // 
            this.teacherUpdateButton.Location = new System.Drawing.Point(146, 337);
            this.teacherUpdateButton.Name = "teacherUpdateButton";
            this.teacherUpdateButton.Size = new System.Drawing.Size(164, 43);
            this.teacherUpdateButton.TabIndex = 29;
            this.teacherUpdateButton.Text = "Update";
            this.teacherUpdateButton.UseVisualStyleBackColor = true;
            this.teacherUpdateButton.Click += new System.EventHandler(this.teacherUpdateButton_Click);
            // 
            // ViewTeacherProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 477);
            this.Controls.Add(this.teacherUpdateButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewTeacherProfile";
            this.Text = "ViewTeacherProfile";
            this.Load += new System.EventHandler(this.ViewTeacherProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox designationTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dNameComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teacherNameTextBox;
        private System.Windows.Forms.TextBox teacherIdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button teacherUpdateButton;
    }
}