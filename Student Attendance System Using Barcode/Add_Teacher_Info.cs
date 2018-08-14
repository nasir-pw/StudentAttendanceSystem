using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Attendance_System_Using_Barcode
{
    public partial class Add_Teacher_Info : Form
    {
        private AddTeacherClass addTeacherObj=null;
        private Gateway gateways = null;
        private Gateway ob = null;
        private int i;

        public Add_Teacher_Info()
        {
            
            InitializeComponent();
        }
        private void Add_Teacher_Info_Load(object sender, EventArgs e)
        {
            ob = new Gateway();
            ob.FillDeptComboBox();
            for (i = 0; i < ob.countDeptRow; i++)
            {
                dNameComboBox.Items.Add(ob.deptName[i]);
                searchDeptComboBox.Items.Add(ob.deptName[i]);
            }

        }

        private void courseAddButton_Click(object sender, EventArgs e)
        {
            addTeacherObj = new AddTeacherClass();

            addTeacherObj.TeacherId = teacherIdTextBox.Text;
            addTeacherObj.TeacherName = teacherNameTextBox.Text;
            addTeacherObj.TeacherDesign = designationTextBox.Text;
            addTeacherObj.DeptName = dNameComboBox.Text;
            addTeacherObj.Password = passwordTextBox.Text;

            if ((teacherIdTextBox.Text == "") || (teacherNameTextBox.Text == "") || (designationTextBox.Text == "") || (dNameComboBox.Text == "") || (passwordTextBox.Text == ""))
            {
                MessageBox.Show("Please Fill-Up all field");

                this.Update();
            }
            else
            {
                gateways = new Gateway();

                if (gateways.InserIntoTeacherInfoTable(addTeacherObj)==1)
                {
                    MessageBox.Show("Information Added Successfully!!!");
                    teacherResetButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Already Added \""+teacherNameTextBox.Text+"\"");
                }
                
                

            }


        }

        private void teacherResetButton_Click(object sender, EventArgs e)
        {
            teacherIdTextBox.ResetText();
            teacherIdTextBox.Focus();

            teacherNameTextBox.ResetText();
            designationTextBox.ResetText();
            dNameComboBox.ResetText();
            passwordTextBox.ResetText();
            searchDeptComboBox.ResetText();

        }

        private void teacherViewButton_Click(object sender, EventArgs e)
        {
            gateways = new Gateway();
            teacherDataGridView.DataSource = gateways.RetrieveAllInfoFromTeacherTable();
        }

        private void teacherDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            teacherIdTextBox.Text = teacherDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            teacherNameTextBox.Text = teacherDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            designationTextBox.Text = teacherDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            dNameComboBox.Text= teacherDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            
        }

        private void teacherDeleteButton_Click(object sender, EventArgs e)
        {
            if (ob.DeleteEntireRowOfTeacherTable(teacherIdTextBox.Text) == 1)
            {
                MessageBox.Show("Deleted Successfully!");
                teacherResetButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Could not delete!");
            }
        }

        private void teacherUpdateButton_Click(object sender, EventArgs e)
        {
            addTeacherObj = new AddTeacherClass();

            addTeacherObj.TeacherId = teacherIdTextBox.Text;
            addTeacherObj.TeacherName = teacherNameTextBox.Text;
            addTeacherObj.TeacherDesign = designationTextBox.Text;
            addTeacherObj.DeptName = dNameComboBox.Text;

            
            if (teacherIdTextBox.Text == "" || teacherNameTextBox.Text == "" || designationTextBox.Text == "")
            {
                MessageBox.Show("Could not Update!");
            }
            else
            {
                gateways.UpdateTeacherInfoTable(addTeacherObj);
                MessageBox.Show("Information Updated Successfully!");
            }
            
        }

        private void teacherSearchButton_Click(object sender, EventArgs e)
        {
            gateways = new Gateway();
            teacherDataGridView.DataSource=gateways.SearchFromTeacherInfoTable(searchDeptComboBox.Text);
        }

        
    }
}
