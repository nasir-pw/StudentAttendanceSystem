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
    public partial class Student_Login : Form
    {
        DBConnector connector = null;
        SqlConnection connection = null;
        
        private string studentId=null;
        private string password = null;
        private string year = null;
        private string semester = null;
        private string name = null;
        private string dept = null;

        public Student_Login()
        {
            InitializeComponent();

            connector = new DBConnector();
            connection = connector.Connection;
        }

        private void studentLoginButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string queryString = "SELECT St_Name,Student_ID,Year,Semester,Dept_ID,Password FROM Student_Info_Table WHERE Student_ID=('" + studentIdTextBox.Text + "') AND Password=('" + passwordTextBox.Text + "')";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                studentId = reader["Student_ID"].ToString();
                password=reader["Password"].ToString();
                year = reader["Year"].ToString();
                semester = reader["Semester"].ToString();
                name = reader["St_Name"].ToString();
                dept = reader["Dept_ID"].ToString();

            }

            connection.Close();

            if ((studentId == studentIdTextBox.Text)&&(password==passwordTextBox.Text))
            {
                Student_Profile ob = new Student_Profile();
                ob.PassInfoToStudentProfile(studentId, year, semester, name,dept);
                ob.Show();
                this.Close();
                
               
                
            }
            else
            {
                MessageBox.Show("Please check Student ID or Password!!!!");
            }
        }
    }
}
