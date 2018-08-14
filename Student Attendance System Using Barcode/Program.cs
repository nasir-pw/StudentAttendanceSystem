using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Student_Attendance_System_Using_Barcode
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Teacher_Login());
           Application.Run(new Student_AttendanceForm());
        }
    }
}
