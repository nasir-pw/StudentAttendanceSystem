using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Attendance_System_Using_Barcode
{
    public class Gateway
    {
        DBConnector connector = null;
        SqlConnection connection = null;
        AttendanceFormClass attendobj=null;
        AttendRoutineClass attndRtnObj= null;

        

        DataTable dataTable = new DataTable();

        private int teacherID;
        private int teacherID1;
        private int teacherID2;
        private string courseNo = null;

        public string[] deptName;
        private int i = 0;
        public int countDeptRow;

        private int tempStID;
        private string tempOutTime;
        public Gateway()
        {
            connector = new DBConnector();
            connection = connector.Connection;
        }

        public void FillDeptComboBox()
        {
            
            //For Count Database Row
            connection.Open();
            string stm = "SELECT COUNT(Dept_Name) FROM Dept_Info_Table";
            SqlCommand cmd = new SqlCommand(stm, connection);
            countDeptRow = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            deptName = new string[countDeptRow];

            connection.Open();
            string queryString = "SELECT Dept_Name FROM Dept_Info_Table";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            

            while (reader.Read())
            {

                deptName[i++] = reader["Dept_Name"].ToString();

            }

            connection.Close();
            
        }
        public int Call_DeptID(string deptName)
        {
            if (deptName == "CSE")
                return 40;
            else if (deptName == "CE")
                return 10;
            else if (deptName == "ME")
                return 20;
            else if (deptName == "TE")
                return 30;
            else if (deptName == "EEE")
                return 50;
            else if (deptName == "IPE")
                return 60;
            else 
                return 70;
            
        }
        public int Call_TeacherID(string teacherName)
        {
            
                connection.Open();
                string queryString = "SELECT Teacher_ID FROM Teacher_Info_Table WHERE Teacher_Name=('" + teacherName + "') ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    teacherID = Convert.ToInt32(reader["Teacher_ID"]);
                }
                connection.Close();

                return teacherID;
            


            
        }
        public string Call_CourseNo(string courseName)
        {
            connection.Open();
            string queryString = "SELECT Course_No FROM Course_Info_Table WHERE Course_Name=('" + courseName + "') ";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                courseNo = reader["Course_No"].ToString();
            }
            connection.Close();

            return courseNo;
        }


        public int InserIntoStudentInfoTable(AddStudentClass addStudentObj)
        {
            string ID=null;
            
            connection.Open();
            string queryString = "SELECT Student_ID FROM Student_Info_Table WHERE Student_ID=('" + addStudentObj.StudentId + "') ";
            SqlCommand cmd = new SqlCommand(queryString, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = reader["Student_ID"].ToString();
            }
            connection.Close();

            if (ID == addStudentObj.StudentId)
            {
               
                return 0;
                
            }
            else
            {
               
                connection.Open();
                string insertString = "INSERT INTO Student_Info_Table VALUES('" + addStudentObj.StudentId + "', '" + addStudentObj.StudentName + "', '" + Call_DeptID(addStudentObj.StudentDept) + "', '" + addStudentObj.StudentYear + "','" + addStudentObj.StudentSemester + "','" + addStudentObj.StudentMobile + "','" + addStudentObj.StudentEmail + "','" + addStudentObj.StudentPassword + "')";

                SqlCommand command = new SqlCommand(insertString, connection);
                command.ExecuteNonQuery();
                
                connection.Close();
                
                return 1;
            }
           
            
        }
        public int InserIntoTeacherInfoTable(AddTeacherClass addTeacherObj)
        {
            string ID=null;
            
            connection.Open();
            string queryString = "SELECT Teacher_ID FROM Teacher_Info_Table WHERE Teacher_ID=('" + addTeacherObj.TeacherId + "') ";
            SqlCommand cmd = new SqlCommand(queryString, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = reader["Teacher_ID"].ToString();
            }
            connection.Close();

            if (ID == addTeacherObj.TeacherId)
            {

                return 0;

            }
            else
            {
                connection.Open();
                string insertString = "INSERT INTO Teacher_Info_Table VALUES('" + addTeacherObj.TeacherId + "', '" + addTeacherObj.TeacherName + "', '" + addTeacherObj.TeacherDesign + "', '" + Call_DeptID(addTeacherObj.DeptName) + "', '" + addTeacherObj.Password + "')";

                SqlCommand command = new SqlCommand(insertString, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return 1;
            }
        }
        public int InserIntoDeptInfoTable(AddDeptClass addDeptObj)
        {
            string ID=null;
            
            connection.Open();
            string queryString = "SELECT Dept_ID FROM Dept_Info_Table WHERE Dept_ID=('" + addDeptObj.DeptID + "') ";
            SqlCommand cmd = new SqlCommand(queryString, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = reader["Dept_ID"].ToString();
            }
            connection.Close();

            if (ID == addDeptObj.DeptID)
            {

                return 0;

            }
            else
            {
                connection.Open();
                string insertString = "INSERT INTO Dept_Info_Table VALUES('" + addDeptObj.DeptID + "', '" + addDeptObj.DeptName + "','" + addDeptObj.DeptFullName + "')";

                SqlCommand command = new SqlCommand(insertString, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return 1;
            }
        }
        public int InserIntoCourseInfoTable(AddCourseClass addCourseObj)
        {
            string ID=null;
            
            connection.Open();
            string queryString = "SELECT Course_No FROM Course_Info_Table WHERE Course_No=('" + addCourseObj.CourseNo + "') AND Dept_ID=('" + Call_DeptID(addCourseObj.DeptName) + "') AND Year=('" + addCourseObj.Year + "') AND Semester=('" + addCourseObj.Semester + "') ";
            SqlCommand cmd = new SqlCommand(queryString, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = reader["Course_No"].ToString();
            }
            connection.Close();

            if (ID == addCourseObj.CourseNo)
            {

                return 0;

            }
            else
            {
                connection.Open();
                string insertString = "INSERT INTO Course_Info_Table VALUES('" + addCourseObj.CourseNo + "', '" + addCourseObj.CourseName + "','" + Call_DeptID(addCourseObj.DeptName) + "','" + addCourseObj.Year + "','" + addCourseObj.Semester + "')";

                SqlCommand command = new SqlCommand(insertString, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return 1;
            }
        }
        public int InserIntoRoutineInfoTable(AddRoutineClass routineObj)
        {
            int ID=0;
          
            connection.Open();

            string queryString = "SELECT Dept_ID FROM Routine_Info_Table WHERE Dept_ID=('" + Call_DeptID(routineObj.DeptName) + "') AND Year=('" + routineObj.Year + "') AND Semester=('" + routineObj.Semester + "')  AND Day=('" + routineObj.Day + "') AND Start_Time=('" + routineObj.StartTime + "') ";
            SqlCommand cmd = new SqlCommand(queryString, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                ID = Convert.ToInt32(reader["Dept_ID"]);
            }
            connection.Close();

            if (ID == Call_DeptID(routineObj.DeptName))
            {

                return 0;

            }
            else
            {
                teacherID1 = Call_TeacherID(routineObj.TeacherOneName);
                teacherID2 = Call_TeacherID(routineObj.TeacherTwoName);
                courseNo = Call_CourseNo(routineObj.CourseName);
                connection.Open();
                string insertString = "INSERT INTO Routine_Info_Table VALUES('" + Call_DeptID(routineObj.DeptName) + "','" + teacherID1 + "','" + teacherID2 + "', '" + routineObj.Year + "','" + routineObj.Semester + "','" + courseNo + "','" + routineObj.Day + "','" + routineObj.StartTime + "','" + routineObj.EndTime + "')";

                SqlCommand command = new SqlCommand(insertString, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return 1;
            }
        }
        public void InserIntoAttendanceInfoTable(AttendanceInputClass attndInputObj)
        {
            connection.Open();
            string insertString = "INSERT INTO Attendance_Info_Table VALUES('" + attndInputObj.StudentID + "', '" + attndInputObj.DeptID + "', '" + attndInputObj.TeacherOneID + "', '" + attndInputObj.TeacherTwoID + "','" + attndInputObj.CourseNo + "','" + attndInputObj.Year + "','" + attndInputObj.Semester + "','" + attndInputObj.InTime + "','" + "" + "','" + attndInputObj.Date + "')";

            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public AttendanceFormClass RetrieveFromStudentInfoTable(int roll)
        {
            
            attendobj = new AttendanceFormClass();
           
            connection.Open();
            string queryString = "SELECT * FROM Student_Info_Table WHERE Student_ID=('" + roll + "') ";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                
                attendobj.StudentId = Convert.ToInt32(reader["Student_ID"]);
                attendobj.StudentName = reader["St_Name"].ToString();
                attendobj.StudentDept = Convert.ToInt32(reader["Dept_ID"]);
                attendobj.StudentYear = reader["Year"].ToString();
                attendobj.StudentSemester = reader["Semester"].ToString();
  
            }
            
            connection.Close();
            return attendobj;
            

        }
        public AttendRoutineClass RetrieveFromRoutineInfoTable(string day,string year, string semester,string systemTime)
        {

            attndRtnObj = new AttendRoutineClass();

            connection.Open();
            string queryString = "SELECT * FROM Routine_Info_Table WHERE Year=('" + year + "') AND Semester=('" + semester + "') AND Day=('" + day + "') AND (('" + systemTime + "') BETWEEN Start_Time AND End_Time) ";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            

            while (reader.Read())
            {

                attndRtnObj.DeptID = Convert.ToInt32(reader["Dept_ID"]);
                attndRtnObj.CourseNo= reader["Course_No"].ToString();
                attndRtnObj.TeacherOneID = Convert.ToInt32(reader["TeacherOne_ID"]);
                attndRtnObj.TeacherTwoID = Convert.ToInt32(reader["TeacherTwo_ID"]);
                attndRtnObj.Year=reader["Year"].ToString();
                attndRtnObj.Semester=reader["Semester"].ToString();
            }

            connection.Close();
            return attndRtnObj;


        }
        

        public int CheckStudent(AttendanceInputClass attndInputObj)
        {
           
            connection.Open();
            string queryString = "SELECT Student_ID,Out_Time FROM Attendance_Info_Table WHERE Student_ID=('" + attndInputObj.StudentID + "') AND Course_No=('" + attndInputObj.CourseNo + "') AND Date='"+attndInputObj.Date+"'  ";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                 tempStID = Convert.ToInt32(reader["Student_ID"]);
                tempOutTime=reader["Out_Time"].ToString();
            }
            connection.Close();
            if (tempOutTime == "00:00:00")
                return 1;
            else
             return tempStID;
        }
        public void UpdateOutTime(string outTime,int studentID)
        {
            connection.Open();
            string insertString = "UPDATE  Attendance_Info_Table SET Out_Time='" + outTime + "' WHERE Student_ID='" + studentID + "'";

            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable RetrieveAllInfoFromStudentTable() 
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT [Student_ID],[St_Name],(SELECT Dept_Name FROM Dept_Info_Table WHERE Dept_ID=Student_Info_Table.Dept_ID) as Department ,[Year],[Semester],[Mobile],[Email] FROM Student_Info_Table ORDER BY Student_ID";

            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
           
            connection.Close();
            return dataTable;
            
        }

        public DataTable SearchFromStudentInfoTable(string data)
        {
            

                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT [Student_ID],[St_Name],(SELECT Dept_Name FROM Dept_Info_Table WHERE Dept_ID=Student_Info_Table.Dept_ID) as Department ,[Year],[Semester],[Mobile],[Email] FROM Student_Info_Table WHERE Student_ID='" + data + "'OR Dept_ID='" + data + "' ORDER BY Student_ID";

                command.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                connection.Close();
                return dataTable;
           
            
            
        }
        public string UpdateStudentInfoTable(AddStudentClass addStOb)
        {

            string ID=null;
            connection.Open();
            string insertString = "UPDATE  Student_Info_Table SET Student_ID='" + addStOb.StudentId + "', St_Name='" + addStOb.StudentName + "',Dept_ID='" + Call_DeptID(addStOb.StudentDept) + "',Year='" + addStOb.StudentYear + "',Semester='" + addStOb.StudentSemester + "', Mobile='" + addStOb.StudentMobile + "',Email='" + addStOb.StudentEmail + "',Password='"+addStOb.StudentPassword+"' WHERE Student_ID='" + addStOb.StudentId + "'";
            
            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();
            connection.Close();
           
            
            connection.Open();
            
            string queryString = "SELECT Student_ID FROM Student_Info_Table WHERE Student_ID='"+addStOb.StudentId+"'";
            SqlCommand cmd = new SqlCommand(queryString, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ID = reader["Student_ID"].ToString();
                
            }
            connection.Close();

            return ID;

        }
        public int DeleteEntireRowOfStudentTable(string studentID)
        {
            connection.Open();
            string stm = "SELECT COUNT(Student_ID) FROM Student_Info_Table";
            SqlCommand cmd = new SqlCommand(stm, connection);
            int firstCount = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            connection.Open();
            string insertString = "DELETE FROM  Student_Info_Table WHERE Student_ID='" + studentID + "'";
            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();
            connection.Close();
           
            connection.Open();
            string cstm = "SELECT COUNT(Student_ID) FROM Student_Info_Table";
            SqlCommand cmmd = new SqlCommand(cstm, connection);
            int lastCount = Convert.ToInt32(cmmd.ExecuteScalar());
            connection.Close();
           
            if (lastCount<firstCount)
            {
                return 1;
            }
            else
            {
                return 0;
            }
           
        }
        public DataTable RetrieveAllInfoFromDeptTable()
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Dept_Info_Table";

            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);

            connection.Close();
            return dataTable;

        }
        public void UpdateDeptInfoTable(AddDeptClass addDeptOb)
        {
            
            connection.Open();
            string insertString = "UPDATE  Dept_Info_Table SET  Dept_Name='" + addDeptOb.DeptName + "',Dept_Full_Name='"+addDeptOb.DeptFullName+"' WHERE Dept_ID='" + addDeptOb.DeptID + "'";

            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public int DeleteEntireRowOfDeptTable(string deptID)
        {
            try
            {
                connection.Open();
                string stm = "SELECT COUNT(Dept_ID) FROM Dept_Info_Table";
                SqlCommand cmd = new SqlCommand(stm, connection);
                int firstCount = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();

                connection.Open();
                string insertString = "DELETE FROM  Dept_Info_Table WHERE Dept_ID='" + deptID + "'";
                SqlCommand command = new SqlCommand(insertString, connection);
                command.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string cstm = "SELECT COUNT(Dept_ID) FROM Dept_Info_Table";
                SqlCommand cmmd = new SqlCommand(cstm, connection);
                int lastCount = Convert.ToInt32(cmmd.ExecuteScalar());
                connection.Close();

                if (lastCount < firstCount)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                
                return 2;
            }
        }
        public DataTable SearchFromDeptInfoTable(string dName)
        {

            
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Dept_Info_Table WHERE (Dept_Name='" + dName.ToUpper() + "')";

                command.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                connection.Close();
                return dataTable;
           


        }
        public DataTable RetrieveAllInfoFromCourseTable()
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT [Course_No],[Course_Name],(SELECT Dept_Name FROM Dept_Info_Table WHERE Dept_ID=Course_Info_Table.[Dept_ID]) as Department,[Year],[Semester] FROM Course_Info_Table";

            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);

            connection.Close();
            return dataTable;

        }
        public void UpdateCourseInfoTable(AddCourseClass addCourseOb)
        {

            connection.Open();
            string insertString = "UPDATE  Course_Info_Table SET Course_Name='" + addCourseOb.CourseName + "', Dept_ID='" + Call_DeptID(addCourseOb.DeptName)+ "',Year='" + addCourseOb.Year+ "',Semester='" + addCourseOb.Semester + "' WHERE Course_No='" + addCourseOb.CourseNo+ "'";

            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public int DeleteEntireRowOfCourseTable(string courseNo)
        {
            try
            {
                connection.Open();
                string stm = "SELECT COUNT(Course_No) FROM Course_Info_Table";
                SqlCommand cmd = new SqlCommand(stm, connection);
                int firstCount = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();

                connection.Open();
                string insertString = "DELETE FROM  Course_Info_Table WHERE Course_No='" + courseNo + "'";
                SqlCommand command = new SqlCommand(insertString, connection);
                command.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string cstm = "SELECT COUNT(Course_No) FROM Course_Info_Table";
                SqlCommand cmmd = new SqlCommand(cstm, connection);
                int lastCount = Convert.ToInt32(cmmd.ExecuteScalar());
                connection.Close();

                if (lastCount < firstCount)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {

                return 2;
            }
        }
        public DataTable SearchFromCourseInfoTable(string dName,string year, string semster)
        {


            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT [Course_No],[Course_Name],(SELECT Dept_Name FROM Dept_Info_Table WHERE Dept_ID=Course_Info_Table.[Dept_ID]) as Department,[Year],[Semester] FROM Course_Info_Table WHERE Dept_ID='" + Call_DeptID(dName) + "'AND Year='" + year + "' AND Semester='" + semster + "'";

            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);

            connection.Close();
            return dataTable;



        }
        public DataTable RetrieveAllInfoFromRoutineTable() 
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT (SELECT Dept_Name FROM Dept_Info_Table WHERE [Dept_ID]=Routine_Info_Table.Dept_ID)AS Dept,(SELECT Teacher_Name FROM Teacher_Info_Table WHERE [Teacher_ID]=[TeacherOne_ID])AS Teacher_One,(SELECT Teacher_Name FROM Teacher_Info_Table WHERE [Teacher_ID]=[TeacherTwo_ID])AS Teacher_Two,[Year],[Semester],(SELECT Course_Name FROM Course_Info_Table WHERE Course_No=Routine_Info_Table.Course_No)as Course_Name,[Day],[Start_Time],[End_Time] FROM Routine_Info_Table";

            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
           
            connection.Close();
            return dataTable;
            
        }
        public int DeleteEntireRowOfRoutineTable(string dept,string year,string semester,string courseNo,string day,string startTime,string endTime)
        {
            string course = Call_CourseNo(courseNo);
            try
            {
                connection.Open();
                string stm = "SELECT COUNT(Course_No) FROM Routine_Info_Table WHERE Dept_ID='" + Call_DeptID(dept) + "' AND Year='" + year + "'AND Semester='" + semester + "'";
                SqlCommand cmd = new SqlCommand(stm, connection);
                int firstCount = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();

                connection.Open();
                string insertString = "DELETE FROM  Routine_Info_Table WHERE Course_No='" + course + "' AND Day='" + day + "' AND Start_Time='" + startTime + "' AND End_Time='" + endTime + "'";
                SqlCommand command = new SqlCommand(insertString, connection);
                command.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string cstm = "SELECT COUNT(Course_No) FROM Routine_Info_Table WHERE Dept_ID='" + Call_DeptID(dept) + "' AND Year='" + year + "'AND Semester='" + semester + "'";
                SqlCommand cmmd = new SqlCommand(cstm, connection);
                int lastCount = Convert.ToInt32(cmmd.ExecuteScalar());
                connection.Close();

                if (lastCount < firstCount)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {

                return 2;
            }
        }

        public int UpdateRoutineInfoTable(AddRoutineClass addRtnOb)
        {
            string course=null;
            string courseNo = Call_CourseNo(addRtnOb.CourseName);
            connection.Open();

            string queryString = "SELECT Course_No FROM Routine_Info_Table WHERE Dept_ID=('" + Call_DeptID(addRtnOb.DeptName) + "') AND Year=('" + addRtnOb.Year + "') AND Semester=('" + addRtnOb.Semester + "')  AND Day=('" + addRtnOb.Day + "') AND Start_Time=('" + addRtnOb.StartTime + "') ";
            SqlCommand cmd = new SqlCommand(queryString, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                course = reader["Course_No"].ToString();
            }
            connection.Close();

            if (course != courseNo)
            {

                return 0;

            }
            else
            {
                int teacher_Id1 = Call_TeacherID(addRtnOb.TeacherOneName);
                int teacher_Id2 = Call_TeacherID(addRtnOb.TeacherTwoName);
                connection.Open();
                string insertString = "UPDATE  Routine_Info_Table SET TeacherOne_ID='" + teacher_Id1 + "', TeacherTwo_ID='" + teacher_Id2 + "',Day='" + addRtnOb.Day + "',Start_Time='" + addRtnOb.StartTime + "',End_Time='" + addRtnOb.EndTime + "' WHERE Dept_ID='" + Call_DeptID(addRtnOb.DeptName) + "' AND Year='" + addRtnOb.Year + "'AND Semester='" + addRtnOb.Semester + "' AND Course_No='" + courseNo + "'";

                SqlCommand command = new SqlCommand(insertString, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return 1;
            }
        }
        public DataTable SearchFromRoutineInfoTable(string dName, string year, string semster)
        {


            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT (SELECT Dept_Name FROM Dept_Info_Table WHERE [Dept_ID]=Routine_Info_Table.Dept_ID)AS Dept,(SELECT Teacher_Name FROM Teacher_Info_Table WHERE [Teacher_ID]=[TeacherOne_ID])AS Teacher_One,(SELECT Teacher_Name FROM Teacher_Info_Table WHERE [Teacher_ID]=[TeacherTwo_ID])AS Teacher_Two,[Year],[Semester],(SELECT Course_Name FROM Course_Info_Table WHERE Course_No=Routine_Info_Table.Course_No)as Course_Name,[Day],[Start_Time],[End_Time] FROM Routine_Info_Table WHERE Dept_ID='" + Call_DeptID(dName) + "'AND Year='" + year + "' AND Semester='" + semster + "'";

            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);

            connection.Close();
            return dataTable;



        }
        public DataTable RetrieveAllInfoFromTeacherTable()
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT Teacher_ID,Teacher_Name,Designation,(SELECT Dept_Name From Dept_Info_Table WHERE Dept_ID=Teacher_Info_Table.Dept_ID)as Dept_Name FROM Teacher_Info_Table";

            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);

            connection.Close();
            return dataTable;

        }
        public int DeleteEntireRowOfTeacherTable(string teacherID)
        {
            try
            {
                connection.Open();
                string stm = "SELECT COUNT(Teacher_ID) FROM Teacher_Info_Table";
                SqlCommand cmd = new SqlCommand(stm, connection);
                int firstCount = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();

                connection.Open();
                string insertString = "DELETE FROM  Teacher_Info_Table WHERE Teacher_ID='" + teacherID + "'";
                SqlCommand command = new SqlCommand(insertString, connection);
                command.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string cstm = "SELECT COUNT(Teacher_ID) FROM Teacher_Info_Table";
                SqlCommand cmmd = new SqlCommand(cstm, connection);
                int lastCount = Convert.ToInt32(cmmd.ExecuteScalar());
                connection.Close();

                if (lastCount < firstCount)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {

                return 2;
            }
        }
        public void UpdateTeacherInfoTable(AddTeacherClass addTeacherOb)
        {

            connection.Open();
            string insertString = "UPDATE  Teacher_Info_Table SET Teacher_Name='" + addTeacherOb.TeacherName + "', Designation='" + addTeacherOb.TeacherDesign + "',Dept_ID='" + Call_DeptID(addTeacherOb.DeptName) + "',Password='"+addTeacherOb.Password+"' WHERE Teacher_ID='"+addTeacherOb.TeacherId+"'";

            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable SearchFromTeacherInfoTable(string dept)
        {


            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT Teacher_ID,Teacher_Name,Designation,(SELECT Dept_Name From Dept_Info_Table WHERE Dept_ID=Teacher_Info_Table.Dept_ID)as Dept_Name FROM Teacher_Info_Table WHERE Dept_ID='" + Call_DeptID(dept) + "'";

            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);

            connection.Close();
            return dataTable;



        }

       
    }
}
