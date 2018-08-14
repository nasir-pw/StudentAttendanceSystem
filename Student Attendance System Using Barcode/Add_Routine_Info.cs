using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Attendance_System_Using_Barcode
{
    public partial class Add_Routine_Info : Form
    {
        DBConnector connector = null;
        SqlConnection connection = null;
        private Gateway gateways = null;
        private AddRoutineClass routineOb = null;

        private int i;
        
        private string year=null;
        private string semester=null;
        private string dept=null;
        private string courseName = null;
        private string deptForTeacher = null;
     

        public Add_Routine_Info()
        {
            InitializeComponent();
            connector = new DBConnector();
            connection = connector.Connection;
        }
        private void Add_Routine_Info_Load(object sender, EventArgs e)
        {
            //For Course ComboBox Tooltip------------------------------

            courseComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            courseComboBox.DrawItem += courseComboBox_DrawItem;
            courseComboBox.DropDownClosed += courseComboBox_DropDownClosed;

            //Fill Dept Name ComboBox ----------------------------------
            gateways = new Gateway();
            gateways.FillDeptComboBox();
            for (i = 0; i < gateways.countDeptRow; i++)
            {
                deptNameComboBox.Items.Add(gateways.deptName[i]);
                searchDeptComboBox.Items.Add(gateways.deptName[i]);
                deptForTeachercomboBox.Items.Add(gateways.deptName[i]);
            }
        }
        private void deptNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dept = deptNameComboBox.Text;
            courseComboBox.Items.Clear();
            //teacherOneComboBox.Items.Clear();
            //teacherTwoComboBox.Items.Clear();
            FillCourseComboBox();
            
           // routineResetButton_Click(sender, e);
        }
        private void deptForTeachercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deptForTeacher = deptForTeachercomboBox.Text;
            teacherOneComboBox.Items.Clear();
            teacherTwoComboBox.Items.Clear();
            FillTeacherComboBox();
        }
        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseComboBox.Items.Clear();
            year = yearComboBox.Text;
            FillCourseComboBox();
        }
        private void semesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseComboBox.Items.Clear();
            semester = semesterComboBox.Text;
            FillCourseComboBox();   
   
        }
        
        private void FillCourseComboBox()
        {
            connection.Open();
            string queryString = "SELECT * FROM Course_Info_Table WHERE Dept_ID='" + gateways.Call_DeptID(dept) + "' AND Year='" + year + "' AND Semester='" + semester + "'";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                courseName = reader["Course_Name"].ToString();// +" - ( " + reader["Course_No"].ToString() + " ) ";
                courseComboBox.Items.Add(courseName);

            }

            connection.Close();
        }
        
        private void FillTeacherComboBox()
        {
            connection.Open();
            string queryString = "SELECT * FROM Teacher_Info_Table WHERE Dept_ID='" + gateways.Call_DeptID(deptForTeacher) + "'";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                teacherOneComboBox.Items.Add(reader["Teacher_Name"].ToString());
                teacherTwoComboBox.Items.Add(reader["Teacher_Name"].ToString());

            }

            connection.Close();
        }
        private void routineAddButton_Click(object sender, EventArgs e)
        {
            routineOb = new AddRoutineClass();

            routineOb.DeptName = deptNameComboBox.Text;
            routineOb.TeacherOneName = teacherOneComboBox.Text;
            routineOb.TeacherTwoName = teacherTwoComboBox.Text;
            routineOb.Year = yearComboBox.Text;
            routineOb.Semester = semesterComboBox.Text;
            routineOb.CourseName = courseComboBox.Text;
            routineOb.Day = dayComboBox.Text;
            routineOb.StartTime = startTimePicker.Text;
            routineOb.EndTime = endTimePicker.Text;

            if ((deptNameComboBox.Text == "") || (teacherOneComboBox.Text == "") || (yearComboBox.Text == "") || (semesterComboBox.Text == "") || (courseComboBox.Text == " ")||(dayComboBox.Text==""))
            {
                MessageBox.Show("Please fill-up all field");
                this.Update();
            }
            else
            {
                if (gateways.InserIntoRoutineInfoTable(routineOb) == 1)
                {
                    MessageBox.Show("Information Added Successfully!!!");
                    routineResetButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("This time slot is already booked!");
                }
                
                
                


            }


        }

        private void routineResetButton_Click(object sender, EventArgs e)
        {
            deptNameComboBox.ResetText();
            deptNameComboBox.Focus();
            teacherOneComboBox.ResetText();
            teacherTwoComboBox.ResetText();
            yearComboBox.ResetText();
            semesterComboBox.ResetText();
            courseComboBox.ResetText();
            dayComboBox.ResetText();
            startTimePicker.ResetText();
            endTimePicker.ResetText();
            searchDeptComboBox.ResetText();
            SearchSemesterComboBox.ResetText();
            searchYearComboBox.ResetText();
            deptForTeachercomboBox.ResetText();

        }

        // Course Combobox toolTop..................
        ToolTip toolTip1 = new ToolTip();
        private void courseComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) { return; } // added this line thanks to Andrew's comment
            string text = courseComboBox.GetItemText(courseComboBox.Items[e.Index]);
            e.DrawBackground();
            using (SolidBrush br = new SolidBrush(e.ForeColor))
            { e.Graphics.DrawString(text, e.Font, br, e.Bounds); }
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            { toolTip1.Show(text, courseComboBox, e.Bounds.Right, e.Bounds.Bottom); }
            e.DrawFocusRectangle();
        }

        private void courseComboBox_DropDownClosed(object sender, EventArgs e)
        {
            toolTip1.Hide(courseComboBox);
        }

        private void routineViewButton_Click(object sender, EventArgs e)
        {
            routineDataGridView.DataSource = gateways.RetrieveAllInfoFromRoutineTable();
        }

        private void routineDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            deptNameComboBox.Text = routineDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            teacherOneComboBox.Text = routineDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            teacherTwoComboBox.Text = routineDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            yearComboBox.Text = routineDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            semesterComboBox.Text = routineDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            courseComboBox.Text = routineDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            dayComboBox.Text = routineDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            startTimePicker.Text = routineDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            endTimePicker.Text= routineDataGridView.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void routineDeleteButton_Click(object sender, EventArgs e)
        {
            if (gateways.DeleteEntireRowOfRoutineTable(deptNameComboBox.Text,yearComboBox.Text,semesterComboBox.Text,courseComboBox.Text,dayComboBox.Text,startTimePicker.Text,endTimePicker.Text) == 1)
            {
                MessageBox.Show("Deleted Successfully!");
                routineResetButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Could not delete!");
            }
        }

        private void routineUpdateButton_Click(object sender, EventArgs e)
        {
            routineOb = new AddRoutineClass();

            routineOb.DeptName = deptNameComboBox.Text;
            routineOb.TeacherOneName = teacherOneComboBox.Text;
            routineOb.TeacherTwoName = teacherTwoComboBox.Text;
            routineOb.Year = yearComboBox.Text;
            routineOb.Semester = semesterComboBox.Text;
            routineOb.CourseName = courseComboBox.Text;
            routineOb.Day = dayComboBox.Text;
            routineOb.StartTime = startTimePicker.Text;
            routineOb.EndTime = endTimePicker.Text;
            
            if (deptNameComboBox.Text=="" || teacherOneComboBox.Text=="" || teacherTwoComboBox.Text=="" ||yearComboBox.Text==""||semesterComboBox.Text==""||courseComboBox.Text==""||dayComboBox.Text=="")
            {
                MessageBox.Show("Could not Update !");
            }
            else
            {
                if (gateways.UpdateRoutineInfoTable(routineOb) == 1)
                {
                    MessageBox.Show("Information Updated Successfully!");
                    routineResetButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("This time slot is already booked!");
                }
                
                
               
               
            }
        }

        private void routineSearchButton_Click(object sender, EventArgs e)
        {
            routineDataGridView.DataSource = gateways.SearchFromRoutineInfoTable(searchDeptComboBox.Text, searchYearComboBox.Text, SearchSemesterComboBox.Text);
            
        }

        

        

        

        //.................................................

        

        

        

       

       

       
        

       
        
        
    }
}
