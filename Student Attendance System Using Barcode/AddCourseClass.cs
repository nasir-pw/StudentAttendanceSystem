using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student_Attendance_System_Using_Barcode
{
    public class AddCourseClass
    {
        private string courseNo;
        private string courseName;
        private string deptName;
        private string year;
        private string semester;

        public string CourseNo
        {
            set { courseNo = value; }
            get { return courseNo; }
        }
        public string CourseName
        {
            set { courseName = value; }
            get { return courseName; }
        }
        public string DeptName
        {
            set { deptName = value; }
            get { return deptName; }
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
    }
}
