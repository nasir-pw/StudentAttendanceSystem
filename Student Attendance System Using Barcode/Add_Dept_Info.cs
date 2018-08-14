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
    public partial class Add_Dept_Info : Form
    {
        private AddDeptClass addDeptObj = null;
        private Gateway gateways = null;

        

        public Add_Dept_Info()
        {
            InitializeComponent();
        }

        private void courseAddButton_Click(object sender, EventArgs e)
        {
            addDeptObj = new AddDeptClass();

            addDeptObj.DeptID = deptIdTextBox.Text;
            addDeptObj.DeptName = deptNameTextBox.Text;
            addDeptObj.DeptFullName = deptFullNameTextBox.Text;
           


            if ((deptNameTextBox.Text == "") || (deptIdTextBox.Text == ""))
            {
                MessageBox.Show("Please Fill-Up all fields!!");
                this.Update();
            }
            else
            {
                gateways = new Gateway();
                if (gateways.InserIntoDeptInfoTable(addDeptObj) == 1)
                {
                    MessageBox.Show("Information Added Successfully!!!");
                    deptResetButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Already Added this department!!!");
                }

                
            }


        }

        private void deptResetButton_Click(object sender, EventArgs e)
        {
            deptIdTextBox.ResetText();
            deptIdTextBox.Focus();

            deptNameTextBox.ResetText();
            searchComboBox.ResetText();
            deptFullNameTextBox.ResetText();
        }

        private void deptViewButton_Click(object sender, EventArgs e)
        {
            gateways = new Gateway();
            deptDataGridView.DataSource = gateways.RetrieveAllInfoFromDeptTable();
        }

        private void deptDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            deptIdTextBox.Text = deptDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            deptNameTextBox.Text = deptDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            deptFullNameTextBox.Text = deptDataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void deptUpdateButton_Click(object sender, EventArgs e)
        {
            gateways = new Gateway();
            addDeptObj = new AddDeptClass();

            addDeptObj.DeptID = deptIdTextBox.Text;
            addDeptObj.DeptName = deptNameTextBox.Text;
            addDeptObj.DeptFullName = deptFullNameTextBox.Text;
            if (deptIdTextBox.Text == "" || deptNameTextBox.Text == "")
            {
                MessageBox.Show("Could not Update!");
            }
            else
            {
                gateways.UpdateDeptInfoTable(addDeptObj);
                MessageBox.Show("Information Updated Successfully!");
                deptResetButton_Click(sender, e);
            }
            
           
        }

        private void deptDeleteButton_Click(object sender, EventArgs e)
        {
            gateways = new Gateway();
            if (gateways.DeleteEntireRowOfDeptTable(deptIdTextBox.Text) == 1)
            {
                MessageBox.Show("Deleted Successfully!");
                deptResetButton_Click(sender, e);
            }
            else if (gateways.DeleteEntireRowOfDeptTable(deptIdTextBox.Text) == 2)
            {
                MessageBox.Show("You will can not delete this foreign key item!");
            }
            else
            {
                MessageBox.Show("Could not delete!");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            gateways = new Gateway();
            deptDataGridView.DataSource = gateways.SearchFromDeptInfoTable(searchComboBox.Text);
            
           
        }

        private void Add_Dept_Info_Load(object sender, EventArgs e)
        {
            int i;
            gateways = new Gateway();
            gateways.FillDeptComboBox();
            for (i = 0; i < gateways.countDeptRow; i++)
                searchComboBox.Items.Add(gateways.deptName[i]);
        }

        

      
        
    }
}
