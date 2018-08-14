using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student_Attendance_System_Using_Barcode
{
    public class AddTeacherClass
    {

        private string teacherName;
        private string teacherId;
        private string teacherDesignation;
        private string deptName;
        private string passWord;

        public string TeacherName
        {
            set { teacherName = value; }
            get { return teacherName; }
        }
        public string TeacherId
        {
            set { teacherId = value; }
            get { return teacherId; }
        }
        public string TeacherDesign
        {
            set { teacherDesignation = value; }
            get { return teacherDesignation; }
        }
        public string DeptName
        {
            set { deptName = value; }
            get { return deptName; }
        }
        public string Password
        {
            set { passWord = value; }
            get { return passWord; }
        }
    }
}
