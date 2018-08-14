namespace Student_Attendance_System_Using_Barcode
{
    partial class Student_Profile
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
            this.label4 = new System.Windows.Forms.Label();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.showAttendanceButton = new System.Windows.Forms.Button();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stProfileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "COURSE :";
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(94, 32);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(383, 21);
            this.courseComboBox.TabIndex = 7;
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Location = new System.Drawing.Point(80, 207);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.Size = new System.Drawing.Size(637, 196);
            this.studentDataGridView.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.endDateTimePicker);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.showAttendanceButton);
            this.groupBox4.Controls.Add(this.startDateTimePicker);
            this.groupBox4.Controls.Add(this.courseComboBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(80, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 156);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(330, 68);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(147, 20);
            this.endDateTimePicker.TabIndex = 9;
            // 
            // showAttendanceButton
            // 
            this.showAttendanceButton.Location = new System.Drawing.Point(94, 114);
            this.showAttendanceButton.Name = "showAttendanceButton";
            this.showAttendanceButton.Size = new System.Drawing.Size(383, 25);
            this.showAttendanceButton.TabIndex = 7;
            this.showAttendanceButton.Text = "Show Attendance";
            this.showAttendanceButton.UseVisualStyleBackColor = true;
            this.showAttendanceButton.Click += new System.EventHandler(this.showAttendanceButton_Click);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(94, 68);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(148, 20);
            this.startDateTimePicker.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "TO :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "FROM :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stProfileButton);
            this.groupBox1.Location = new System.Drawing.Point(612, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 155);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // stProfileButton
            // 
            this.stProfileButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stProfileButton.Location = new System.Drawing.Point(14, 34);
            this.stProfileButton.Name = "stProfileButton";
            this.stProfileButton.Size = new System.Drawing.Size(77, 87);
            this.stProfileButton.TabIndex = 0;
            this.stProfileButton.Text = "Profile";
            this.stProfileButton.UseVisualStyleBackColor = true;
            this.stProfileButton.Click += new System.EventHandler(this.stProfileButton_Click);
            // 
            // Student_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.studentDataGridView);
            this.Name = "Student_Profile";
            this.Text = "Student Profile";
            this.Load += new System.EventHandler(this.Student_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Button showAttendanceButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button stProfileButton;
    }
}