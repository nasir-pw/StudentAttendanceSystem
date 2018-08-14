using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student_Attendance_System_Using_Barcode
{
    public class AttendanceInputClass
    {
        private int studentID;
        private int deptID;
        private int teacherOneID;
        private int teacherTwoID;
        private string year;
        private string semester;
        private string courseNo;
        private string day;
        private string inTime;
        private string outTime;
        private string date;

        public int StudentID
        {
            set { studentID = value; }
            get { return studentID; }
        }
        public int DeptID
        {
            set { deptID = value; }
            get { return deptID; }
        }
        public int TeacherOneID
        {
            set { teacherOneID = value; }
            get { return teacherOneID; }
        }
        public int TeacherTwoID
        {
            set { teacherTwoID = value; }
            get { return teacherTwoID; }
        }
        public string Year
        {
            set { year = value; }
            get { return year; }
        }
        public string Semester
        {
            set { semester = value; }
            get { return semester; }
        }
        public string CourseNo
        {
            set { courseNo = value; }
            get { return courseNo; }
        }
        public string Day
        {
            set { day = value; }
            get { return day; }
        }
        public string InTime
        {
            set { inTime = value; }
            get { return inTime; }
        }
        public string OutTime
        {
            set { outTime = value; }
            get { return outTime; }
        }
        public string Date
        {
            set { date = value; }
            get { return date; }
        }
    }
}
