using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Office.Interop;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp;
using System.Text.RegularExpressions;
using System.Configuration;




namespace Student_Attendance_System_Using_Barcode
{
    public partial class Teacher_Profile : Form
    {
        private DBConnector connector = null;
        private SqlConnection connection = null;
        private Gateway gateways = null;


        private string studentYear = null;
        private string studentSemester = null;
        private string studetnDept = null;

        private string teacherName;
        private string teacherID;
        private string teacherDept;
        private string year;
        private string semester;
        private string courseName;
        private string dept;
        private string courseNo;
        private int c;
        private int count;
        

        public Teacher_Profile()
        {
            InitializeComponent();

            connector = new DBConnector();
            connection = connector.Connection;
        }

        private void Teacher_Profile_Load(object sender, EventArgs e)
        {
            //teacherDataGridView.AutoGenerateColumns = false;
            this.Text = teacherName;
            // Tool tip for Course ComboBox
            courseComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            courseComboBox.DrawItem += courseComboBox_DrawItem;
            courseComboBox.DropDownClosed += courseComboBox_DropDownClosed;
            // Fill Dept ComboBox
            
            gateways = new Gateway();
            gateways.FillDeptComboBox();
            for (c = 0; c < gateways.countDeptRow; c++)
                deptComboBox.Items.Add(gateways.deptName[c]);

            //----------------------------
            
            
        }
        public void PassInfoToTeacherProfile(string tId,string tName,string dept)
        {
            teacherName = tName;
            teacherID = tId;
            teacherDept = dept;
        }
        private void searchStIdTextBox_TextChanged(object sender, EventArgs e)
        {
            int rowCount = teacherDataGridView.Rows.Count; // returns zero


            if (rowCount==0)
            {
                MessageBox.Show("First Show All Info");
            }
            else
            {
                (teacherDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("convert(Student_ID, 'System.String')  LIKE '{0}%'", (searchStIdTextBox.Text).ToString());
            }
        }
       
        private void deptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dept = deptComboBox.Text;
            courseComboBox.Items.Clear();
            FillCourseComboBox();
        }
        
        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseComboBox.Items.Clear();
            year = yearComboBox.Text;
            FillCourseComboBox();
        }

        private void semesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseComboBox.Items.Clear();
            semester = semesterComboBox.Text;
            FillCourseComboBox();   
        }
        private void FillCourseComboBox()
        {
            
            connection.Open();
            string queryString = "SELECT * FROM Course_Info_Table WHERE Dept_ID='" + gateways.Call_DeptID(dept) + "' AND Year='" + year + "' AND Semester='" + semester + "'";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                courseName = reader["Course_Name"].ToString();
                courseComboBox.Items.Add(courseName);

            }

            connection.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string queryString = "SELECT Dept_Full_Name FROM Dept_Info_Table WHERE Dept_ID='" + gateways.Call_DeptID(dept) + "'";
            SqlCommand cmmd = new SqlCommand(queryString, connection);
            SqlDataReader reader = cmmd.ExecuteReader();

            while (reader.Read())
            {
                studetnDept = reader["Dept_Full_Name"].ToString();
                

            }

            connection.Close();

            
            studentYear = yearComboBox.Text;
            studentSemester = semesterComboBox.Text;

            courseName = courseComboBox.Text;


            connection.Open();

            string query = "SELECT Course_No FROM Course_Info_Table WHERE Course_Name='" + courseName + "' ";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {

                courseNo = read["Course_No"].ToString();

            }

            connection.Close();

            if (courseNo != null)
            {
                count = courseNo.Length;
            }
            
            

            connection.Open();
            
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT  Student_ID,(SELECT Course_Name FROM Course_Info_Table WHERE Course_No=Attendance_Info_Table.Course_No)as Course_Name,In_Time,Out_Time,Date,(SELECT COUNT(distinct Date) FROM Attendance_Info_Table WHERE Course_No='" + courseNo + "')AS 'Total_Class(Day)' FROM Attendance_Info_Table  WHERE Dept_ID='" + gateways.Call_DeptID(dept) + "' AND (TeacherOne_ID='" + teacherID + "' OR TeacherTwo_ID='" + teacherID + "') AND Year='" + yearComboBox.Text + "'AND Semester='" + semesterComboBox.Text + "'AND Course_No='" + courseNo + "' AND (Date BETWEEN '" + startDateTimePicker.Text + "' AND '" + endDateTimePicker.Text + "') ORDER BY Student_ID ";

            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);

            //---------------------------
            dataTable.Columns.Add("Total_Present(Day)", typeof(System.Int32));
           
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i][6]=CountStudentID(dataTable.Rows[i][0].ToString());
            }
            dataTable.Columns.Add("Total_Absence(Day)", typeof(System.Int32));

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i][7] = Convert.ToInt32(dataTable.Rows[i][5]) - Convert.ToInt32( dataTable.Rows[i][6]);
            }
            dataTable.Columns.Add("% of Present", typeof(System.String));

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i][8] = ((Convert.ToInt32(dataTable.Rows[i][6])*100) / Convert.ToInt32(dataTable.Rows[i][5]));
            }
            dataTable.Columns.Add("Marks", typeof(System.String));

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i][9] =  SubjectMarks(Convert.ToInt32(dataTable.Rows[i][8]),Convert.ToInt32(courseNo[count - 1]));
            }
            teacherDataGridView.DataSource = dataTable;
            connection.Close();
            
           // MessageBox.Show(dataTable.Rows.Count.ToString());
            this.teacherDataGridView.Columns["Student_ID"].Frozen = true;
            
           
        }
        int CountStudentID(string id)
        {


            string stm = "SELECT COUNT(Student_ID) FROM Attendance_Info_Table WHERE Student_ID='" + id + "' AND Dept_ID='" + gateways.Call_DeptID(dept) + "' AND (TeacherOne_ID='" + teacherID + "' OR TeacherTwo_ID='" + teacherID + "') AND Year='" + yearComboBox.Text + "'AND Semester='" + semesterComboBox.Text + "'AND Course_No='" + courseNo + "'";
            SqlCommand cmnd = new SqlCommand(stm, connection);
            int studentID = Convert.ToInt32(cmnd.ExecuteScalar());
           
            return studentID;
        }
        int SubjectMarks(int attend,int scode)
        {
            int theory = 300;
            int lab = 100;
            if ((scode % 2)!= 0)
            {
                if (attend >= 90)
                    return (theory * 10) / 100;
                else if (attend >= 85 && attend<90)
                    return (theory * 9) / 100;
                else if (attend >= 80 && attend < 85)
                    return (theory * 8) / 100;
                else if (attend >= 75 && attend < 80)
                    return (theory * 7) / 100;
                else if (attend >= 70 && attend < 75)
                    return (theory * 6) / 100;
                else if (attend >= 65 && attend < 70)
                    return (theory * 5) / 100;
                else if (attend >= 60 && attend < 65)
                    return (theory * 4) / 100;
                else
                    return 0;

            }
            else
            {
                if (attend >= 90)
                    return (lab * 10) / 100;
                else if (attend >= 85 && attend < 90)
                    return (lab * 9) / 100;
                else if (attend >= 80 && attend < 85)
                    return (lab * 8) / 100;
                else if (attend >= 75 && attend < 80)
                    return (lab * 7) / 100;
                else if (attend >= 70 && attend < 75)
                    return (lab * 6) / 100;
                else if (attend >= 65 && attend < 70)
                    return (lab * 5) / 100;
                else if (attend >= 60 && attend < 65)
                    return (lab * 4) / 100;
                else
                    return 0;
            }
        }
        // Course Combobox toolTop..................
        ToolTip toolTip1 = new ToolTip();
        private void courseComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) { return; } // added this line thanks to Andrew's comment
            string text = courseComboBox.GetItemText(courseComboBox.Items[e.Index]);
            e.DrawBackground();
            using (SolidBrush br = new SolidBrush(e.ForeColor))
            { e.Graphics.DrawString(text, e.Font, br, e.Bounds); }
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            { toolTip1.Show(text, courseComboBox, e.Bounds.Right, e.Bounds.Bottom); }
            e.DrawFocusRectangle();
        }

        private void courseComboBox_DropDownClosed(object sender, EventArgs e)
        {
            toolTip1.Hide(courseComboBox);
        }
        //.................................................



        private void exportExcelButton_Click(object sender, EventArgs e)
        {

            ExportToExcel();
            
        }
        private void ExportToExcel()
        {
            
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
           
            excel.Columns[2].ColumnWidth = 15;
            excel.Columns[3].ColumnWidth = 40;
            excel.Columns[4].ColumnWidth = 15;
            excel.Columns[5].ColumnWidth = 15;
            excel.Columns[6].ColumnWidth = 20;
            excel.Columns[7].ColumnWidth = 20;
            excel.Columns[8].ColumnWidth = 20;
            excel.Columns[9].ColumnWidth = 20;
            excel.Columns[10].ColumnWidth = 20;
            worksheet = workbook.ActiveSheet;


            //worksheet.Range["C1"].WrapText = true;
            //  worksheet.Cells[1, 3] = versityNameTextBox.Text +" Department: "+studetnDept + ", Year: " + studentYear + ", Semester: " + studentSemester;
            //excel.Rows[1].RowHeight = 60;
            worksheet.Range[worksheet.Cells[2, 2], worksheet.Cells[2, 11]].Merge();
            worksheet.Range["B2"].Value = String.Format(versityNameTextBox.Text);
            worksheet.Cells[2, 2].Font.Bold = true;
            worksheet.Cells[2, 2].Font.Size = 20;

            worksheet.Range[worksheet.Cells[3, 2], worksheet.Cells[3, 11]].Merge();
            worksheet.Range["B3"].Value = String.Format("Department of " + studetnDept);
            worksheet.Cells[3, 2].Font.Italic = true;
            worksheet.Cells[3, 2].Font.Size = 16;

            worksheet.Range[worksheet.Cells[4, 2], worksheet.Cells[4, 11]].Merge();
            worksheet.Range["B4"].Value = String.Format(studentYear+" Year,"+studentSemester+" Semester");
            worksheet.Cells[4, 2].Font.Bold = true;
            worksheet.Cells[4, 2].Font.Size = 14;

            worksheet.Range[worksheet.Cells[5, 2], worksheet.Cells[5, 11]].Merge();
            worksheet.Range["B5"].Value = String.Format("Student Attendance Sheet");
            worksheet.Cells[5, 2].Font.Bold = true;
            worksheet.Cells[5, 2].Font.Size = 16;
         
            worksheet.Range["B2","K1000"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.WhiteSmoke);
            
            string startRange = "B2";
            string endRange = "K2";
            Microsoft.Office.Interop.Excel.Range currentRange = (Microsoft.Office.Interop.Excel.Range)worksheet.get_Range(startRange, endRange);
            currentRange.Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
          
            
            
            Microsoft.Office.Interop.Excel.Range formatRange;
            formatRange = worksheet.get_Range("B7","K7"); 
            formatRange.EntireRow.Font.Bold = true;
            
            
            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 7;
                int cellColumnIndex = 2;

                //Loop through each row and read value from each column. 
                for (int i = -1; i < teacherDataGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < teacherDataGridView.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 7)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = teacherDataGridView.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = teacherDataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 2;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Excel File Successful Created");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        }

        private void ExportPdfButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "PDF Files|*.pdf";
            dlg.FilterIndex = 0;

            string fileName = string.Empty;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;
              
                 
                Document doc = new Document(iTextSharp.text.PageSize.A3, 0, 0, 150, 20);
                doc.SetPageSize(iTextSharp.text.PageSize.A3.Rotate());
                PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
                doc.Open();

                //doc.Add(new Paragraph("This is Paragraph 1"));
               

                var boldVersityName = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
                Paragraph versityParagraph = new Paragraph(versityNameTextBox.Text, boldVersityName);
                versityParagraph.Alignment = Element.ALIGN_CENTER;
                doc.Add(versityParagraph);

                var boldDept = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                Paragraph deptParagraph = new Paragraph("Department of " + studetnDept + "\n", boldDept);
                deptParagraph.Alignment = Element.ALIGN_CENTER;
                doc.Add(deptParagraph);

                var boldYear = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                Paragraph yearParagraph = new Paragraph(studentYear+" Year , "+studentSemester+" Semester" , boldDept);
                yearParagraph.Alignment = Element.ALIGN_CENTER;
                doc.Add(yearParagraph);

                var boldSheetName = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                Paragraph sheetNameParagraph = new Paragraph("Student Attendance Sheet",boldSheetName);
                sheetNameParagraph.Alignment = Element.ALIGN_CENTER;
                doc.Add(sheetNameParagraph);

                doc.Add(new Paragraph(" "));
                
                

                PdfPTable table = new PdfPTable(teacherDataGridView.Columns.Count);
                int[] intTblWidth = new int[10];
                intTblWidth[0] = 100;
                intTblWidth[1] = 150;
                intTblWidth[2] = 100;
                intTblWidth[3] = 100;
                intTblWidth[4] = 100;
                intTblWidth[5] = 120;
                intTblWidth[6] = 130;
                intTblWidth[7] = 130;
                intTblWidth[8] = 100;
                intTblWidth[9] = 70;

                table.SetWidths(intTblWidth);
                for (int j = 0; j < teacherDataGridView.Columns.Count; j++)
                {
                    
                    table.AddCell(new Phrase(teacherDataGridView.Columns[j].HeaderText));
                }
                table.HeaderRows = 1;
                for (int i = 0; i < teacherDataGridView.Rows.Count; i++)
                {
                    for (int k = 0; k < teacherDataGridView.Columns.Count; k++)
                    {
                        if (teacherDataGridView[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(teacherDataGridView[k, i].Value.ToString()));
                        }
                    }
                }
                doc.Add(table);
                MessageBox.Show("PDF File Successfully Created ");
                doc.Close();
            }

            
        }

        private void teacherProfileButton_Click(object sender, EventArgs e)
        {
            ViewTeacherProfile ob = new ViewTeacherProfile();
            ob.GetTeacherInfoFromTeacherProfile(teacherID,teacherName);
            ob.Show();
        }


        

        

        /*
        
        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = teacherDataGridView[column, row];
            DataGridViewCell cell2 = teacherDataGridView[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void teacherDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = teacherDataGridView.AdvancedCellBorderStyle.Top;
            }  
        }

        private void teacherDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }
        */
        

      
    }
}
