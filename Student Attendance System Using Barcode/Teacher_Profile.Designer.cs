namespace Student_Attendance_System_Using_Barcode
{
    partial class Teacher_Profile
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
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.teacherDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.showButton = new System.Windows.Forms.Button();
            this.searchStIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exportExcelButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.versityNameTextBox = new System.Windows.Forms.TextBox();
            this.ExportPdfButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.teacherProfileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th"});
            this.yearComboBox.Location = new System.Drawing.Point(78, 74);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(150, 21);
            this.yearComboBox.TabIndex = 1;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.yearComboBox_SelectedIndexChanged);
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Items.AddRange(new object[] {
            "1st",
            "2nd"});
            this.semesterComboBox.Location = new System.Drawing.Point(78, 118);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(150, 21);
            this.semesterComboBox.TabIndex = 2;
            this.semesterComboBox.SelectedIndexChanged += new System.EventHandler(this.semesterComboBox_SelectedIndexChanged);
            // 
            // teacherDataGridView
            // 
            this.teacherDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.teacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDataGridView.Location = new System.Drawing.Point(304, 162);
            this.teacherDataGridView.Name = "teacherDataGridView";
            this.teacherDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teacherDataGridView.Size = new System.Drawing.Size(443, 224);
            this.teacherDataGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Semester :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Course :";
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(78, 163);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(150, 21);
            this.courseComboBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.deptComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.endDateTimePicker);
            this.groupBox1.Controls.Add(this.startDateTimePicker);
            this.groupBox1.Controls.Add(this.showButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.courseComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.semesterComboBox);
            this.groupBox1.Controls.Add(this.yearComboBox);
            this.groupBox1.Location = new System.Drawing.Point(31, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 363);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show All Attendance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dept :";
            // 
            // deptComboBox
            // 
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Location = new System.Drawing.Point(78, 42);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(150, 21);
            this.deptComboBox.TabIndex = 14;
            this.deptComboBox.SelectedIndexChanged += new System.EventHandler(this.deptComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "To :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "From :";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(78, 238);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.endDateTimePicker.TabIndex = 11;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(78, 200);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.startDateTimePicker.TabIndex = 10;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(78, 286);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(150, 34);
            this.showButton.TabIndex = 9;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // searchStIdTextBox
            // 
            this.searchStIdTextBox.Location = new System.Drawing.Point(134, 38);
            this.searchStIdTextBox.Name = "searchStIdTextBox";
            this.searchStIdTextBox.Size = new System.Drawing.Size(134, 20);
            this.searchStIdTextBox.TabIndex = 10;
            this.searchStIdTextBox.TextChanged += new System.EventHandler(this.searchStIdTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "STUDENT ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.searchStIdTextBox);
            this.groupBox2.Location = new System.Drawing.Point(304, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 86);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Individual Attendance";
            // 
            // exportExcelButton
            // 
            this.exportExcelButton.Location = new System.Drawing.Point(392, 396);
            this.exportExcelButton.Name = "exportExcelButton";
            this.exportExcelButton.Size = new System.Drawing.Size(122, 25);
            this.exportExcelButton.TabIndex = 13;
            this.exportExcelButton.Text = "Export To Excel";
            this.exportExcelButton.UseVisualStyleBackColor = true;
            this.exportExcelButton.Click += new System.EventHandler(this.exportExcelButton_Click);
            // 
            // versityNameTextBox
            // 
            this.versityNameTextBox.Location = new System.Drawing.Point(314, 119);
            this.versityNameTextBox.Name = "versityNameTextBox";
            this.versityNameTextBox.Size = new System.Drawing.Size(432, 20);
            this.versityNameTextBox.TabIndex = 14;
            this.versityNameTextBox.Text = "Dhaka University of Engineering & Technology";
            // 
            // ExportPdfButton
            // 
            this.ExportPdfButton.Location = new System.Drawing.Point(537, 396);
            this.ExportPdfButton.Name = "ExportPdfButton";
            this.ExportPdfButton.Size = new System.Drawing.Size(122, 25);
            this.ExportPdfButton.TabIndex = 15;
            this.ExportPdfButton.Text = "Export To PDF";
            this.ExportPdfButton.UseVisualStyleBackColor = true;
            this.ExportPdfButton.Click += new System.EventHandler(this.ExportPdfButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.teacherProfileButton);
            this.groupBox3.Location = new System.Drawing.Point(619, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 86);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // teacherProfileButton
            // 
            this.teacherProfileButton.Location = new System.Drawing.Point(22, 17);
            this.teacherProfileButton.Name = "teacherProfileButton";
            this.teacherProfileButton.Size = new System.Drawing.Size(84, 53);
            this.teacherProfileButton.TabIndex = 0;
            this.teacherProfileButton.Text = "Profile";
            this.teacherProfileButton.UseVisualStyleBackColor = true;
            this.teacherProfileButton.Click += new System.EventHandler(this.teacherProfileButton_Click);
            // 
            // Teacher_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 429);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ExportPdfButton);
            this.Controls.Add(this.versityNameTextBox);
            this.Controls.Add(this.exportExcelButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.teacherDataGridView);
            this.Name = "Teacher_Profile";
            this.Text = "Teacher Form";
            this.Load += new System.EventHandler(this.Teacher_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.DataGridView teacherDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox searchStIdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Button exportExcelButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox versityNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.Button ExportPdfButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button teacherProfileButton;

    }
}