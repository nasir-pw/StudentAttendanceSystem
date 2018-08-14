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
    public partial class Student_AttendanceForm : Form
    {
        private Gateway gateway = null;
        private AttendanceFormClass attend_ob = null;
        private AttendRoutineClass attndRtnObj = null;
        private AttendanceInputClass attndInputObj = null;

        
        public int roll;


        private int temp;// = 0;


        //----Time Calculation---- 
        private string systemDay;
        private string systemTime;
        private string systemDate;
        //private string classStartTime;
        private string year;
        private string semester;

        public Student_AttendanceForm()
        {
            InitializeComponent();
        }
       
        private void Student_AttendanceForm_Load(object sender, EventArgs e)
        {
      

            stIDTextBox.Focus();
        }

       
        private void studentLoginBtn_Click(object sender, EventArgs e)
        {
            Student_Login ob = new Student_Login();
            ob.Show();
            
        }

        private void teacherLoginBtn_Click(object sender, EventArgs e)
        {
            Teacher_Login ob = new Teacher_Login();
            ob.Show();
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            Admin_Login ob = new Admin_Login();
            ob.Show();
        }
        
       

        private void stIDTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if (stIDTextBox.TextLength == 6)
            {


                //AutoClosingMessageBox.Show("Welcome Student Attendance System", " ", 1000);
                //MessageBox.Show("Welcome Student Attendance System");
                gateway = new Gateway();
                attend_ob = new AttendanceFormClass();
                attndRtnObj = new AttendRoutineClass();
                
                DateTime now = DateTime.Now;
                systemDay = now.ToString("dddd");
                systemTime = now.ToString("HH:mm:00");
                systemDate = now.ToShortDateString();
                
                roll = Convert.ToInt32(stIDTextBox.Text);

                attend_ob = gateway.RetrieveFromStudentInfoTable(roll);
                temp = attend_ob.StudentId;
                if (temp != 0)
                {

                    year = (attend_ob.StudentYear).ToString();
                    semester = (attend_ob.StudentSemester).ToString();
                    attndRtnObj = gateway.RetrieveFromRoutineInfoTable(systemDay, year, semester, systemTime);
                    if (attndRtnObj.DeptID != 0)
                    {
                        int studentID = attend_ob.StudentId;
                        int deptId = attndRtnObj.DeptID;
                        int teacherOneID = attndRtnObj.TeacherOneID;
                        int teacherTwoID = attndRtnObj.TeacherTwoID;
                        string courseNo = attndRtnObj.CourseNo;
                        year = attndRtnObj.Year;
                        semester = attndRtnObj.Semester;

                        attndInputObj = new AttendanceInputClass();

                        attndInputObj.StudentID = studentID;
                        attndInputObj.DeptID = deptId;
                        attndInputObj.TeacherOneID = teacherOneID;
                        attndInputObj.TeacherTwoID = teacherTwoID;
                        attndInputObj.CourseNo = courseNo;
                        attndInputObj.Year = year;
                        attndInputObj.Semester = semester;
                        attndInputObj.InTime = systemTime;
                        attndInputObj.Date = systemDate;

                        int checkStudent = gateway.CheckStudent(attndInputObj);
                        if (checkStudent == 1)
                        {
                            gateway.UpdateOutTime(systemTime, studentID);
                            AutoClosingMessageBox.Show("Good Bye!!!!.", " ", 1500);
                        }
                        else if (checkStudent == studentID)
                        {
                            AutoClosingMessageBox.Show("You Already attended to this Class!!!", " ", 1500);
                        }
                        else
                        {
                            gateway.InserIntoAttendanceInfoTable(attndInputObj);
                            AutoClosingMessageBox.Show("Welcome " + attend_ob.StudentName + " !!!", " ", 1500);
                        }  
                    }
                    else
                    {
                        AutoClosingMessageBox.Show("Class is not continue at this time!!!", " ", 1500);   
                    }  
                }
                else
                {
                    AutoClosingMessageBox.Show("Student not found!!!", " ", 2000);
                    
                }
                stIDTextBox.ResetText();

            }
            

        }
        


       

    }
}
