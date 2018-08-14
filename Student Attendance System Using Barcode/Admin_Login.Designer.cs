namespace Student_Attendance_System_Using_Barcode
{
    partial class Admin_Login
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
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminPassTextBox = new System.Windows.Forms.TextBox();
            this.adminUserNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.Location = new System.Drawing.Point(111, 92);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(170, 36);
            this.adminLoginButton.TabIndex = 15;
            this.adminLoginButton.Text = "Login";
            this.adminLoginButton.UseVisualStyleBackColor = true;
            this.adminLoginButton.Click += new System.EventHandler(this.adminLoginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "User Name :";
            // 
            // adminPassTextBox
            // 
            this.adminPassTextBox.Location = new System.Drawing.Point(111, 57);
            this.adminPassTextBox.Name = "adminPassTextBox";
            this.adminPassTextBox.PasswordChar = '*';
            this.adminPassTextBox.Size = new System.Drawing.Size(170, 20);
            this.adminPassTextBox.TabIndex = 12;
            // 
            // adminUserNameTextBox
            // 
            this.adminUserNameTextBox.Location = new System.Drawing.Point(111, 28);
            this.adminUserNameTextBox.Name = "adminUserNameTextBox";
            this.adminUserNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.adminUserNameTextBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adminLoginButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.adminPassTextBox);
            this.groupBox1.Controls.Add(this.adminUserNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(119, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 157);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // Admin_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 302);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_Login";
            this.Text = "Admin_Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminLoginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminPassTextBox;
        private System.Windows.Forms.TextBox adminUserNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}