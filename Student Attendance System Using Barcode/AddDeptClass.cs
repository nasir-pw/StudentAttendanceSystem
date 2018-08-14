using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student_Attendance_System_Using_Barcode
{
    public class AddDeptClass
    {
        private string deptId;
        private string deptName;
        private string deptFullName;

        public string DeptID
        {
            set { deptId = value; }
            get { return deptId; }
        }
        public string DeptName
        {
            set { deptName = value; }
            get { return deptName; }
        }
        public string DeptFullName
        {
            set { deptFullName = value; }
            get { return deptFullName; }
        }
    }
}
