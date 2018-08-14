using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Attendance_System_Using_Barcode
{
    public partial class Admin_Login : Form
    {
        private DBConnector connector = null;
        private SqlConnection connection = null;

        private string userName=null;
        private string password=null;
        public Admin_Login()
        {
            InitializeComponent();
            connector = new DBConnector();
            connection = connector.Connection;
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string queryString = "SELECT User_Name,Password FROM Login_Table WHERE User_Name=('" + adminUserNameTextBox.Text + "') AND Password=('" + adminPassTextBox.Text + "')";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                userName = reader["User_Name"].ToString();
                password = reader["Password"].ToString();
                

            }

            connection.Close();

            if ((userName == adminUserNameTextBox.Text) && (password == adminPassTextBox.Text))
            {
                Admin_Panel ob = new Admin_Panel();
                ob.Show();
                this.Close();



            }
            else
            {
                MessageBox.Show("Please check user name and password!!!!");
            }
        }

        
    }
}
