using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student_Attendance_System_Using_Barcode
{
    public class AttendanceFormClass
    {
        private int stId;
        private string stName;
        private int stDept;
        private string stYear;
        private string stSemester;
        private string stMobile;
        private string stEmail;
        

       

        public int StudentId
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
        public int StudentDept
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
        
      

    }
}
