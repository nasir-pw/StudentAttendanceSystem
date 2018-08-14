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
    public partial class Teacher_Login : Form
    {
        DBConnector connector = null;
        SqlConnection connection = null;
        


        private string teacherId = null;
        private string teacherName = null;
        private string teacherDept = null;
        private string password = null;

        public Teacher_Login()
        {
            InitializeComponent();

            connector = new DBConnector();
            connection = connector.Connection;
        }

        private void teacherLoginButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string queryString = "SELECT Teacher_ID,Teacher_Name,Password,Dept_ID FROM Teacher_Info_Table WHERE Teacher_ID=('" + teacherIdTextBox.Text + "') AND Password=('" + passwordTextBox.Text + "')";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                teacherId = reader["Teacher_ID"].ToString();
                teacherName = reader["Teacher_Name"].ToString();
                teacherDept = reader["Dept_ID"].ToString();
                password = reader["Password"].ToString();
                

            }

            connection.Close();

            if ((teacherId == teacherIdTextBox.Text) && (password == passwordTextBox.Text))
            {
                Teacher_Profile ob = new Teacher_Profile();
                ob.PassInfoToTeacherProfile(teacherId,teacherName,teacherDept);
                ob.Show();
                this.Hide();



            }
            else
            {
                MessageBox.Show("Please check ID or Password!!!!");
            }
        }
    }
}
