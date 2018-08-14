using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Student_Attendance_System_Using_Barcode
{
    public partial class AddStudent_Info : Form
    {
        private AddStudentClass addStudentObj = null;
        
        private Gateway ob;
        private int i;
        public AddStudent_Info()
        {
            InitializeComponent();
        }
        private void AddStudent_Info_Load(object sender, EventArgs e)
        {
            ob = new Gateway();
            ob.FillDeptComboBox();
            for (i = 0; i < ob.countDeptRow; i++)
                stDeptComboBox.Items.Add(ob.deptName[i]);

            
        }

        private void stAddButton_Click(object sender, EventArgs e)
        {
            addStudentObj = new AddStudentClass();

            addStudentObj.StudentId = stIdTextBox.Text;
            addStudentObj.StudentName = stNameTextBox.Text;
            addStudentObj.StudentDept = stDeptComboBox.Text;
            addStudentObj.StudentYear = stYearComboBox.Text;
            addStudentObj.StudentSemester = stSemesterComboBox.Text;
            addStudentObj.StudentMobile = stMobileTextBox.Text;
            addStudentObj.StudentEmail = stEmailTextBox.Text;
            addStudentObj.StudentPassword = stPassTextBox.Text;
            if ((stIdTextBox.Text == "") || (stNameTextBox.Text == "")||(stDeptComboBox.Text=="")||(stYearComboBox.Text=="")||(stSemesterComboBox.Text==" "))
            {
                MessageBox.Show("Please fill-up all field");
                this.Update();
            }
            else
            {
                ob = new Gateway();
                
                if (ob.InserIntoStudentInfoTable(addStudentObj)==1)
                {
                    MessageBox.Show("Information Added Successfully!!!");
                    stResetButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Already Added \"" + stNameTextBox.Text + "\"");
                }
                
               


            }

            
        }

        private void stResetButton_Click(object sender, EventArgs e)
        {
            stIdTextBox.ResetText();
            stIdTextBox.Focus();


            stNameTextBox.ResetText();
            stDeptComboBox.ResetText();
            stYearComboBox.ResetText();
            stSemesterComboBox.ResetText();
            stMobileTextBox.ResetText();
            stEmailTextBox.ResetText();
            stPassTextBox.ResetText();
            searchTextBox.ResetText();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            
            studentDataGridView.DataSource = ob.RetrieveAllInfoFromStudentTable();
        }

        private void studentDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            stIdTextBox.Text = studentDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            stNameTextBox.Text= studentDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            stDeptComboBox.Text = studentDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            stYearComboBox.Text= studentDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            stSemesterComboBox.Text= studentDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            stMobileTextBox.Text = studentDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            stEmailTextBox.Text= studentDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int outvalue;
            if (Int32.TryParse(searchTextBox.Text, out outvalue))
            {
                studentDataGridView.DataSource = ob.SearchFromStudentInfoTable(searchTextBox.Text);
                
            }
            else
            {
                MessageBox.Show("Only Student ID & Dept ID!!!");
                searchTextBox.ResetText();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            addStudentObj = new AddStudentClass();

            addStudentObj.StudentId = stIdTextBox.Text;
            addStudentObj.StudentName = stNameTextBox.Text;
            addStudentObj.StudentDept = stDeptComboBox.Text;
            addStudentObj.StudentYear = stYearComboBox.Text;
            addStudentObj.StudentSemester = stSemesterComboBox.Text;
            addStudentObj.StudentMobile = stMobileTextBox.Text;
            addStudentObj.StudentEmail = stEmailTextBox.Text;
            addStudentObj.StudentPassword = stPassTextBox.Text;

            if (ob.UpdateStudentInfoTable(addStudentObj) == stIdTextBox.Text)
            {
                MessageBox.Show("Information Updated Successfully!");
                stResetButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Could not Update !");
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            if (ob.DeleteEntireRowOfStudentTable(stIdTextBox.Text) == 1)
            {
                MessageBox.Show("Deleted Successfully!");
                stResetButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Could not delete!");
            }
            
        }

        

       
    }
}
