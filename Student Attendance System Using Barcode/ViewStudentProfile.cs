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
    public partial class ViewStudentProfile : Form
    {
        private Gateway ob = null;
        private AddStudentClass addStudentObj = null;
        private DBConnector connector = null;
        private SqlConnection connection = null;


        int i;
        string studentID;
        string stName;

        public ViewStudentProfile()
        {
            InitializeComponent();
            connector = new DBConnector();
            connection = connector.Connection;
        }
        private void ViewStudentProfile_Load(object sender, EventArgs e)
        {
            this.Text = "Welcome " + stName;

            ob = new Gateway();
            ob.FillDeptComboBox();
            for (i = 0; i < ob.countDeptRow; i++)
                stDeptComboBox.Items.Add(ob.deptName[i]);


            connection.Open();
            string queryString = "SELECT Student_ID,St_Name,(SELECT Dept_Name FROM Dept_Info_Table WHERE Dept_ID=Student_Info_Table.Dept_ID)as Dept,Year,Semester,Mobile,Email,Password FROM Student_Info_Table WHERE Student_ID='" + studentID + "'";
            SqlCommand command = new SqlCommand(queryString,connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                stIdTextBox.Text=reader["Student_ID"].ToString();
                stNameTextBox.Text = reader["St_Name"].ToString();
                stDeptComboBox.Text = reader["Dept"].ToString();
                stYearComboBox.Text = reader["Year"].ToString();
                stSemesterComboBox.Text = reader["Semester"].ToString();
                stMobileTextBox.Text = reader["Mobile"].ToString();
                stEmailTextBox.Text = reader["Email"].ToString();
                stPassTextBox.Text = reader["Password"].ToString(); 
            }
            connection.Close();


        }
        private void stUpdateButton_Click(object sender, EventArgs e)
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
                ViewStudentProfile_Reset();
            }
            else
            {
                MessageBox.Show("Could not Update !");
            }
        }
        void ViewStudentProfile_Reset()
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
           
        }
        public void GetStudentIDFromStudentProfile(string stID,string name)
        {
            studentID = stID;
            stName = name;

        }

       
    }
}
