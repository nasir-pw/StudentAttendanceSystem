using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Attendance_System_Using_Barcode
{
    public partial class Add_Course_Info : Form
    {
        public Gateway ob;
        private AddCourseClass addCourseObj;
        private int i;

        public Add_Course_Info()
        {
            InitializeComponent();
        }

        private void Add_Course_Info_Load(object sender, EventArgs e)
        {
            ob = new Gateway();
            ob.FillDeptComboBox();
            for (i = 0; i < ob.countDeptRow; i++)
            {
                dNameComboBox.Items.Add(ob.deptName[i]);
                searchDeptComboBox.Items.Add(ob.deptName[i]);
            }
        }

        private void courseAddButton_Click(object sender, EventArgs e)
        {
            addCourseObj = new AddCourseClass();

            addCourseObj.CourseNo = courseNoTextBox.Text;
            addCourseObj.CourseName = courseNameTextBox.Text;
            addCourseObj.DeptName = dNameComboBox.Text;
            addCourseObj.Year = yearComboBox.Text;
            addCourseObj.Semester = semesterComboBox.Text;

            if (courseNoTextBox.Text == "" || courseNameTextBox.Text == "" || dNameComboBox.Text == ""|| yearComboBox.Text=="" || semesterComboBox.Text=="")
            {
                MessageBox.Show("Please Fill-Up all field!!!");
                this.Update();

            }
            else
            {
                ob = new Gateway();
                if (ob.InserIntoCourseInfoTable(addCourseObj) == 1)
                {
                    MessageBox.Show("Information Added Successfully!!");
                    courseResetButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Already Added this course.");
                }
                
                
            }
        }

        private void courseResetButton_Click(object sender, EventArgs e)
        {
            courseNoTextBox.ResetText();
            courseNoTextBox.Focus();
            courseNameTextBox.ResetText();
            dNameComboBox.ResetText();
            yearComboBox.ResetText();
            semesterComboBox.ResetText();
            searchDeptComboBox.ResetText();
            SearchSemesterComboBox.ResetText();
            searchYearComboBox.ResetText();
        }

        private void courseViewBbutton_Click(object sender, EventArgs e)
        {
            ob = new Gateway();
            courseDataGridView.DataSource = ob.RetrieveAllInfoFromCourseTable();
        }

        private void courseDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            courseNoTextBox.Text = courseDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            courseNameTextBox.Text = courseDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            dNameComboBox.Text = courseDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            yearComboBox.Text = courseDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            semesterComboBox.Text = courseDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void courseUpdateButton_Click(object sender, EventArgs e)
        {
            addCourseObj = new AddCourseClass();

            addCourseObj.CourseNo = courseNoTextBox.Text;
            addCourseObj.CourseName = courseNameTextBox.Text;
            addCourseObj.DeptName = dNameComboBox.Text;
            addCourseObj.Year = yearComboBox.Text;
            addCourseObj.Semester = semesterComboBox.Text;

            if ( courseNoTextBox.Text!="" || courseNameTextBox.Text!="" || dNameComboBox.Text!=""|| yearComboBox.Text!="" || semesterComboBox.Text!="")
            {
                ob.UpdateCourseInfoTable(addCourseObj);
                MessageBox.Show("Information Updated Successfully!");
                courseResetButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Could not Update !");
            }
        }

        private void courseDeleteButton_Click(object sender, EventArgs e)
        {
            ob= new Gateway();
            if (ob.DeleteEntireRowOfCourseTable(courseNoTextBox.Text) == 1)
            {
                MessageBox.Show("Deleted Successfully!");
                courseResetButton_Click(sender, e);
            }
            else if (ob.DeleteEntireRowOfCourseTable(courseNoTextBox.Text) == 2)
            {
                MessageBox.Show("You will can not delete this foreign key item!");
            }
            else
            {
                MessageBox.Show("Could not delete!");
            }
        }

        private void courseSearchButton_Click(object sender, EventArgs e)
        {
            courseDataGridView.DataSource = ob.SearchFromCourseInfoTable(searchDeptComboBox.Text,searchYearComboBox.Text,SearchSemesterComboBox.Text);
            
        }

       
        

       

       
        
    }
}
