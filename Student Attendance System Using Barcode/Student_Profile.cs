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
    public partial class Student_Profile : Form
    {
        
        private DBConnector connector = null;
        private SqlConnection connection = null;
       

        private string studentID=null;
        private string stYear = null;
        private string stSemester = null;
        private string stName = null;
        private string stDept = null;
        private string courseName = null;
        private string courseNo = null;

        public Student_Profile()
        {
            InitializeComponent();

            connector = new DBConnector();
            connection = connector.Connection;
           
        }
        


        public void PassInfoToStudentProfile(string stID,string year,string semester,string name,string dept)
        {
            studentID = stID;
            stYear = year;
            stSemester = semester;
            stName = name;
            stDept = dept;
            
        }
        public void Student_Profile_Load(object sender, EventArgs e)
        {
            
            this.Text = "Welcome "+stName;
            
            connection.Open();
            string queryString = "SELECT * FROM Course_Info_Table WHERE Dept_ID='" + stDept + "' AND Year='" + stYear + "' AND Semester='" + stSemester + "'";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                
                courseComboBox.Items.Add(reader["Course_Name"].ToString());

            }

            connection.Close();
            
        }

        private void showAttendanceButton_Click(object sender, EventArgs e)
        {
            courseName = courseComboBox.Text;
            

            connection.Open();
           
            string queryString = "SELECT Course_No FROM Course_Info_Table WHERE Course_Name='" + courseName + "' ";
            SqlCommand cmd = new SqlCommand(queryString, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                courseNo = reader["Course_No"].ToString();

            }

            connection.Close();

            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT (SELECT Course_Name FROM Course_Info_Table WHERE Course_No='" + courseNo + "')as Course_Name,(SELECT Teacher_Name FROM Teacher_Info_Table WHERE Teacher_ID=TeacherOne_ID)+ISNULL(+' And '+(SELECT Teacher_Name FROM Teacher_Info_Table WHERE Teacher_ID=TeacherTwo_ID AND TeacherOne_ID!=TeacherTwo_ID   ),' ')as Teacher_Name,In_Time,Out_Time,Date,(SELECT COUNT(distinct Date) FROM Attendance_Info_Table WHERE Course_No='" + courseNo + "')AS 'Total_Class(Day)' FROM Attendance_Info_Table WHERE Student_ID='" + studentID + "'AND Course_No='" + courseNo + "' AND (Date BETWEEN '" + startDateTimePicker.Text + "' AND '" + endDateTimePicker.Text + "')";
            
            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            
            dataAdapter.Fill(dataTable);
            
            dataTable.Columns.Add("Total_Present(Day)", typeof(System.Int32));

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i][6] = dataTable.Rows.Count;
            }
            dataTable.Columns.Add("Total_Absence(Day)", typeof(System.Int32));

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i][7] = Convert.ToInt32(dataTable.Rows[i][5]) - Convert.ToInt32(dataTable.Rows[i][6]);
            }
            dataTable.Columns.Add("% of Present", typeof(System.String));

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i][8] = ((Convert.ToInt32(dataTable.Rows[i][6]) * 100) / Convert.ToInt32(dataTable.Rows[i][5])) + " %";
            }
            studentDataGridView.DataSource = dataTable;
            
            connection.Close();
            //this.studentDataGridView.Columns["Student_ID"].Frozen = true;
        }

        private void stProfileButton_Click(object sender, EventArgs e)
        {
            ViewStudentProfile ob = new ViewStudentProfile();
            ob.GetStudentIDFromStudentProfile(studentID,stName);
            ob.Show();
        }
       




    }
    
}
