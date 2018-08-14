namespace Student_Attendance_System_Using_Barcode
{
    partial class Admin_Panel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Panel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentInfoButton = new System.Windows.Forms.Button();
            this.addTeacherInfoButton = new System.Windows.Forms.Button();
            this.addRoutineInfoButton = new System.Windows.Forms.Button();
            this.addDeptInfoButton = new System.Windows.Forms.Button();
            this.addCourseInfoButton = new System.Windows.Forms.Button();
            this.adminGroupBox = new System.Windows.Forms.GroupBox();
            this.adminDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.adminGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.adminProfileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // adminProfileToolStripMenuItem
            // 
            this.adminProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem});
            this.adminProfileToolStripMenuItem.Name = "adminProfileToolStripMenuItem";
            this.adminProfileToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.adminProfileToolStripMenuItem.Text = "Admin Profile";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // addStudentInfoButton
            // 
            this.addStudentInfoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addStudentInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addStudentInfoButton.BackgroundImage")));
            this.addStudentInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addStudentInfoButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentInfoButton.Location = new System.Drawing.Point(29, 30);
            this.addStudentInfoButton.Name = "addStudentInfoButton";
            this.addStudentInfoButton.Size = new System.Drawing.Size(172, 63);
            this.addStudentInfoButton.TabIndex = 6;
            this.addStudentInfoButton.Text = "Add Student Info";
            this.addStudentInfoButton.UseVisualStyleBackColor = false;
            this.addStudentInfoButton.Click += new System.EventHandler(this.addStudentInfoButton_Click);
            // 
            // addTeacherInfoButton
            // 
            this.addTeacherInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addTeacherInfoButton.BackgroundImage")));
            this.addTeacherInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTeacherInfoButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeacherInfoButton.Location = new System.Drawing.Point(29, 205);
            this.addTeacherInfoButton.Name = "addTeacherInfoButton";
            this.addTeacherInfoButton.Size = new System.Drawing.Size(172, 63);
            this.addTeacherInfoButton.TabIndex = 7;
            this.addTeacherInfoButton.Text = "Add Teacher Info";
            this.addTeacherInfoButton.UseVisualStyleBackColor = true;
            this.addTeacherInfoButton.Click += new System.EventHandler(this.addTeacherInfoButton_Click);
            // 
            // addRoutineInfoButton
            // 
            this.addRoutineInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addRoutineInfoButton.BackgroundImage")));
            this.addRoutineInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addRoutineInfoButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoutineInfoButton.Location = new System.Drawing.Point(234, 205);
            this.addRoutineInfoButton.Name = "addRoutineInfoButton";
            this.addRoutineInfoButton.Size = new System.Drawing.Size(172, 63);
            this.addRoutineInfoButton.TabIndex = 9;
            this.addRoutineInfoButton.Text = "Add Routine Info";
            this.addRoutineInfoButton.UseVisualStyleBackColor = true;
            this.addRoutineInfoButton.Click += new System.EventHandler(this.addRoutineInfoButton_Click);
            // 
            // addDeptInfoButton
            // 
            this.addDeptInfoButton.AutoSize = true;
            this.addDeptInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addDeptInfoButton.BackgroundImage")));
            this.addDeptInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addDeptInfoButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDeptInfoButton.Location = new System.Drawing.Point(234, 31);
            this.addDeptInfoButton.Name = "addDeptInfoButton";
            this.addDeptInfoButton.Size = new System.Drawing.Size(172, 63);
            this.addDeptInfoButton.TabIndex = 8;
            this.addDeptInfoButton.Text = "Add Dept Info";
            this.addDeptInfoButton.UseVisualStyleBackColor = true;
            this.addDeptInfoButton.Click += new System.EventHandler(this.addDeptInfoButton_Click);
            // 
            // addCourseInfoButton
            // 
            this.addCourseInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCourseInfoButton.BackgroundImage")));
            this.addCourseInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCourseInfoButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseInfoButton.Location = new System.Drawing.Point(131, 119);
            this.addCourseInfoButton.Name = "addCourseInfoButton";
            this.addCourseInfoButton.Size = new System.Drawing.Size(172, 63);
            this.addCourseInfoButton.TabIndex = 10;
            this.addCourseInfoButton.Text = "Add Course Info";
            this.addCourseInfoButton.UseVisualStyleBackColor = true;
            this.addCourseInfoButton.Click += new System.EventHandler(this.addCourseInfoButton_Click);
            // 
            // adminGroupBox
            // 
            this.adminGroupBox.Controls.Add(this.addCourseInfoButton);
            this.adminGroupBox.Controls.Add(this.addRoutineInfoButton);
            this.adminGroupBox.Controls.Add(this.addDeptInfoButton);
            this.adminGroupBox.Controls.Add(this.addTeacherInfoButton);
            this.adminGroupBox.Controls.Add(this.addStudentInfoButton);
            this.adminGroupBox.Location = new System.Drawing.Point(26, 40);
            this.adminGroupBox.Name = "adminGroupBox";
            this.adminGroupBox.Size = new System.Drawing.Size(435, 300);
            this.adminGroupBox.TabIndex = 12;
            this.adminGroupBox.TabStop = false;
            this.adminGroupBox.Text = "Add Information";
            this.adminGroupBox.MouseCaptureChanged += new System.EventHandler(this.adminGroupBox_MouseCaptureChanged);
            // 
            // adminDataGridView
            // 
            this.adminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGridView.Location = new System.Drawing.Point(484, 46);
            this.adminDataGridView.Name = "adminDataGridView";
            this.adminDataGridView.Size = new System.Drawing.Size(317, 294);
            this.adminDataGridView.TabIndex = 13;
            this.adminDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.adminDataGridView_CellMouseUp);
            this.adminDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminDataGridView_CellValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRecordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 26);
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.deleteRecordToolStripMenuItem.Text = "Delete_Record";
            this.deleteRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteRecordToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(834, 386);
            this.Controls.Add(this.adminDataGridView);
            this.Controls.Add(this.adminGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin_Panel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.adminGroupBox.ResumeLayout(false);
            this.adminGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button addStudentInfoButton;
        private System.Windows.Forms.Button addTeacherInfoButton;
        private System.Windows.Forms.Button addRoutineInfoButton;
        private System.Windows.Forms.Button addDeptInfoButton;
        private System.Windows.Forms.Button addCourseInfoButton;
        private System.Windows.Forms.GroupBox adminGroupBox;
        private System.Windows.Forms.ToolStripMenuItem adminProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.DataGridView adminDataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    }
}