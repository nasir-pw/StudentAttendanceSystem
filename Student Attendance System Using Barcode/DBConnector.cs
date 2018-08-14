using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Student_Attendance_System_Using_Barcode
{
    class DBConnector
    {
        private string connectionString = @"server = (local)\SQLEXPRESS; Integrated Security = SSPI; Initial Catalog = Student_Attendance_System";

        SqlConnection connection = null;

        public DBConnector()
        {
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection Connection
        {
            get { return connection; }
        }
    }
}
