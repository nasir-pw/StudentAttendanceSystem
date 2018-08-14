namespace Student_Attendance_System_Using_Barcode
{
    partial class Add_Dept_Info
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
            this.deptNameTextBox = new System.Windows.Forms.TextBox();
            this.deptIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deptResetButton = new System.Windows.Forms.Button();
            this.courseAddButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deptViewButton = new System.Windows.Forms.Button();
            this.deptDeleteButton = new System.Windows.Forms.Button();
            this.deptUpdateButton = new System.Windows.Forms.Button();
            this.deptDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.deptFullNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // deptNameTextBox
            // 
            this.deptNameTextBox.Location = new System.Drawing.Point(120, 75);
            this.deptNameTextBox.Name = "deptNameTextBox";
            this.deptNameTextBox.Size = new System.Drawing.Size(177, 20);
            this.deptNameTextBox.TabIndex = 13;
            // 
            // deptIdTextBox
            // 
            this.deptIdTextBox.Location = new System.Drawing.Point(120, 39);
            this.deptIdTextBox.Name = "deptIdTextBox";
            this.deptIdTextBox.Size = new System.Drawing.Size(177, 20);
            this.deptIdTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dept Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dept ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deptFullNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.deptNameTextBox);
            this.groupBox1.Controls.Add(this.deptIdTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 168);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // deptResetButton
            // 
            this.deptResetButton.Location = new System.Drawing.Point(44, 201);
            this.deptResetButton.Name = "deptResetButton";
            this.deptResetButton.Size = new System.Drawing.Size(113, 30);
            this.deptResetButton.TabIndex = 26;
            this.deptResetButton.Text = "RESET";
            this.deptResetButton.UseVisualStyleBackColor = true;
            this.deptResetButton.Click += new System.EventHandler(this.deptResetButton_Click);
            // 
            // courseAddButton
            // 
            this.courseAddButton.Location = new System.Drawing.Point(45, 41);
            this.courseAddButton.Name = "courseAddButton";
            this.courseAddButton.Size = new System.Drawing.Size(113, 30);
            this.courseAddButton.TabIndex = 25;
            this.courseAddButton.Text = "SAVE";
            this.courseAddButton.UseVisualStyleBackColor = true;
            this.courseAddButton.Click += new System.EventHandler(this.courseAddButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deptViewButton);
            this.groupBox2.Controls.Add(this.deptDeleteButton);
            this.groupBox2.Controls.Add(this.deptResetButton);
            this.groupBox2.Controls.Add(this.deptUpdateButton);
            this.groupBox2.Controls.Add(this.courseAddButton);
            this.groupBox2.Location = new System.Drawing.Point(379, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 273);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // deptViewButton
            // 
            this.deptViewButton.Location = new System.Drawing.Point(45, 161);
            this.deptViewButton.Name = "deptViewButton";
            this.deptViewButton.Size = new System.Drawing.Size(113, 30);
            this.deptViewButton.TabIndex = 32;
            this.deptViewButton.Text = "VIEW";
            this.deptViewButton.UseVisualStyleBackColor = true;
            this.deptViewButton.Click += new System.EventHandler(this.deptViewButton_Click);
            // 
            // deptDeleteButton
            // 
            this.deptDeleteButton.Location = new System.Drawing.Point(44, 121);
            this.deptDeleteButton.Name = "deptDeleteButton";
            this.deptDeleteButton.Size = new System.Drawing.Size(113, 30);
            this.deptDeleteButton.TabIndex = 23;
            this.deptDeleteButton.Text = "DELETE";
            this.deptDeleteButton.UseVisualStyleBackColor = true;
            this.deptDeleteButton.Click += new System.EventHandler(this.deptDeleteButton_Click);
            // 
            // deptUpdateButton
            // 
            this.deptUpdateButton.Location = new System.Drawing.Point(45, 81);
            this.deptUpdateButton.Name = "deptUpdateButton";
            this.deptUpdateButton.Size = new System.Drawing.Size(113, 30);
            this.deptUpdateButton.TabIndex = 22;
            this.deptUpdateButton.Text = "UPDATE";
            this.deptUpdateButton.UseVisualStyleBackColor = true;
            this.deptUpdateButton.Click += new System.EventHandler(this.deptUpdateButton_Click);
            // 
            // deptDataGridView
            // 
            this.deptDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.deptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deptDataGridView.Location = new System.Drawing.Point(21, 314);
            this.deptDataGridView.Name = "deptDataGridView";
            this.deptDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deptDataGridView.Size = new System.Drawing.Size(560, 187);
            this.deptDataGridView.TabIndex = 35;
            this.deptDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.deptDataGridView_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.searchComboBox);
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Location = new System.Drawing.Point(21, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 99);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(100, 29);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(131, 21);
            this.searchComboBox.TabIndex = 27;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(100, 59);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(131, 28);
            this.searchButton.TabIndex = 25;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deptFullNameTextBox
            // 
            this.deptFullNameTextBox.Location = new System.Drawing.Point(120, 109);
            this.deptFullNameTextBox.Name = "deptFullNameTextBox";
            this.deptFullNameTextBox.Size = new System.Drawing.Size(177, 20);
            this.deptFullNameTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dept Full Name :";
            // 
            // Add_Dept_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 522);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.deptDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_Dept_Info";
            this.Text = "Add_Dept_Info";
            this.Load += new System.EventHandler(this.Add_Dept_Info_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deptDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox deptNameTextBox;
        private System.Windows.Forms.TextBox deptIdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deptResetButton;
        private System.Windows.Forms.Button courseAddButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deptDeleteButton;
        private System.Windows.Forms.Button deptUpdateButton;
        private System.Windows.Forms.DataGridView deptDataGridView;
        private System.Windows.Forms.Button deptViewButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.TextBox deptFullNameTextBox;
        private System.Windows.Forms.Label label2;
    }
}