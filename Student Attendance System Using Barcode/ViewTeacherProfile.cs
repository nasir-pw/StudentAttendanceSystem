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
    public partial class ViewTeacherProfile : Form
    {
        private Gateway ob = null;
        private AddTeacherClass addTeacherObj = new AddTeacherClass();
        private DBConnector connector = null;
        private SqlConnection connection = null;

        string teacherName;
        string teacherID;
        int i;
        public ViewTeacherProfile()
        {
            InitializeComponent();
            connector = new DBConnector();
            connection = connector.Connection;
        }

        private void ViewTeacherProfile_Load(object sender, EventArgs e)
        {
            this.Text = "Welcome " + teacherName;

            ob = new Gateway();
            ob.FillDeptComboBox();
            for (i = 0; i < ob.countDeptRow; i++)
                dNameComboBox.Items.Add(ob.deptName[i]);


            connection.Open();
            string queryString = "SELECT Teacher_ID,Teacher_Name,Designation,(SELECT Dept_Name FROM Dept_Info_Table WHERE Dept_ID=Teacher_Info_Table.Dept_ID)as Dept,Password FROM Teacher_Info_Table WHERE Teacher_ID='" + teacherID + "'";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {


                teacherIdTextBox.Text = reader["Teacher_ID"].ToString();
                teacherNameTextBox.Text = reader["Teacher_Name"].ToString();
                designationTextBox.Text = reader["Designation"].ToString();
                dNameComboBox.Text = reader["Dept"].ToString();
                passwordTextBox.Text = reader["Password"].ToString();
            }
            connection.Close();
        }
        public void GetTeacherInfoFromTeacherProfile(string tId,string tName)
        {
            teacherID=tId;
            teacherName=tName;
        }

        private void teacherUpdateButton_Click(object sender, EventArgs e)
        {
            addTeacherObj = new AddTeacherClass();

            addTeacherObj.TeacherId = teacherIdTextBox.Text;
            addTeacherObj.TeacherName = teacherNameTextBox.Text;
            addTeacherObj.TeacherDesign = designationTextBox.Text;
            addTeacherObj.DeptName = dNameComboBox.Text;
            addTeacherObj.Password = passwordTextBox.Text;


            if (teacherIdTextBox.Text == "" || teacherNameTextBox.Text == "" || designationTextBox.Text == "")
            {
                MessageBox.Show("Could not Update!");
            }
            else
            {
                ob.UpdateTeacherInfoTable(addTeacherObj);
                MessageBox.Show("Information Updated Successfully!");
                teacherReset();
            }
        }
        private void teacherReset()
        {
            teacherIdTextBox.ResetText();
            teacherIdTextBox.Focus();

            teacherNameTextBox.ResetText();
            designationTextBox.ResetText();
            dNameComboBox.ResetText();
            passwordTextBox.ResetText();
            

        }
    }
}
