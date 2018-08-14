using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student_Attendance_System_Using_Barcode
{
    public class AddRoutineClass
    {
        
        private string deptName;
        private string teacherOneName;
        private string teacherTwoName;
        private string year;
        private string semester;
        private string courseName;
        private string day;
        private string startTime;
        private string endTime;

        public string DeptName
        {
            set { deptName = value; }
            get { return deptName; }
        }
        public string TeacherOneName
        {
            set { teacherOneName = value; }
            get { return teacherOneName; }
        }
        public string TeacherTwoName
        {
            set { teacherTwoName = value; }
            get { return teacherTwoName; }
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
        public string CourseName
        {
            set { courseName = value; }
            get { return courseName; }
        }
        public string Day
        {
            set { day = value; }
            get { return day; }
        }
        public string StartTime
        {
            set { startTime = value; }
            get { return startTime; }
        }
        public string EndTime
        {
            set { endTime = value; }
            get { return endTime; }
        }
        
    }
}
