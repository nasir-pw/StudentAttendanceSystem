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
    public partial class Admin_Panel : Form
    {
        DBConnector connector = null;
        SqlConnection connection = null;

        string id;
        int id1;
        int delete_id;

        public Admin_Panel()
        {
            InitializeComponent();
            connector = new DBConnector();
            connection = connector.Connection;
            
        }


        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            adminDataGridView.Hide();
        }
        private void addStudentInfoButton_Click(object sender, EventArgs e)
        {
            AddStudent_Info ob = new AddStudent_Info();
            ob.Show();
        }

        private void addDeptInfoButton_Click(object sender, EventArgs e)
        {
            Add_Dept_Info ob = new Add_Dept_Info();
            ob.Show();
        }

        private void addCourseInfoButton_Click(object sender, EventArgs e)
        {
            Add_Course_Info ob = new Add_Course_Info();
            ob.Show();
        }

        private void addTeacherInfoButton_Click(object sender, EventArgs e)
        {
            Add_Teacher_Info ob = new Add_Teacher_Info();
            ob.Show();
        }

        private void addRoutineInfoButton_Click(object sender, EventArgs e)
        {
            Add_Routine_Info ob = new Add_Routine_Info();
            ob.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminDataGridView.Show();
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Login_Table";

            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            adminDataGridView.DataSource = dataTable;
            connection.Close();
        }

        private void adminDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            id = adminDataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString();
            if (id == "")
            {
                id1 = 0;
            }
            else
            {
                id1 = Convert.ToInt32(adminDataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString());
            }
            if (id1 == 0)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Login_Table values('" + adminDataGridView.Rows[e.RowIndex].Cells["User_Name"].Value.ToString() + "','" + adminDataGridView.Rows[e.RowIndex].Cells["Email"].Value.ToString() + "','" + adminDataGridView.Rows[e.RowIndex].Cells["Password"].Value.ToString() + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                showToolStripMenuItem_Click(sender, e);
                

            }
            else
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Login_Table SET User_Name='" + adminDataGridView.Rows[e.RowIndex].Cells["User_Name"].Value.ToString() + "',Email='" + adminDataGridView.Rows[e.RowIndex].Cells["Email"].Value.ToString() + "',Password='" + adminDataGridView.Rows[e.RowIndex].Cells["Password"].Value.ToString() + "' WHERE ID='"+id1+"'";
                cmd.ExecuteNonQuery();
                connection.Close();
                showToolStripMenuItem_Click(sender, e);
                
            }
             

        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmmd = connection.CreateCommand();
            cmmd.CommandType = CommandType.Text;
            cmmd.CommandText = "DELETE FROM Login_Table WHERE ID='" + delete_id + "'";
            cmmd.ExecuteNonQuery();
            connection.Close();
            showToolStripMenuItem_Click(sender, e);

        }

        private void adminDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                delete_id = Convert.ToInt32(adminDataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                this.contextMenuStrip1.Show(this.adminDataGridView,e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
 
        private void adminGroupBox_MouseCaptureChanged(object sender, EventArgs e)
        {
            adminDataGridView.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student Attendance System is a barcode base attendance system. This system is specially designed for Dhaka University of Engineering & Technology (DUET).");
        }

        


        
        
 

        
    }
}
