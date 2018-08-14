using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student_Attendance_System_Using_Barcode
{
    public class AttendRoutineClass
    {
        private int deptName;
        private int teacherOneID;
        private int teacherTwoID;
        private string year;
        private string semester;
        private string courseNo;
        private string day;
        private string startTime;
        private string endTime;

        public int DeptID
        {
            set { deptName = value; }
            get { return deptName; }
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
