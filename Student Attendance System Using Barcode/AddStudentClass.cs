using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student_Attendance_System_Using_Barcode
{
    public class AddStudentClass
    {
        private string stId;
        private string stName;
        private string stDept;
        private string stYear;
        private string stSemester;
        private string stMobile;
        private string stEmail;
        private string stPassword;
        
        public string StudentId
        {
            set
            { stId = value; }
            get
            { return stId; }
        }
        public string StudentName
        {
            set { stName = value; }
            get { return stName; }

        }


        public string StudentDept
        {
            set { stDept = value; }
            get { return stDept; }
        }
        public string StudentYear
        {
            set { stYear = value; }
            get { return stYear; }
        }
        public string StudentSemester
        {
            set
            { stSemester = value; }
            get
            { return stSemester; }
        }
        public string StudentMobile
        {
            set { stMobile = value; }
            get { return stMobile; }

        }

        public string StudentEmail
        {
            set { stEmail = value; }
            get { return stEmail; }
        }
        public string StudentPassword
        {
            set { stPassword = value; }
            get { return stPassword; }
        }
    }
}
