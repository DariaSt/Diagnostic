using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diagn.DiagnosticDataSet1TableAdapters;
using Excel = Microsoft.Office.Interop.Excel;

namespace Diagn
{
    public partial class runner_management : MaterialSkin.Controls.MaterialForm
    {
        public runner_management()
        {
            InitializeComponent();
        }

        private void yprav_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.ServicesService". При необходимости она может быть перемещена или удалена.
            this.servicesServiceTableAdapter1.Fill(this.diagnosticDataSet1.ServicesService);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.View_User". При необходимости она может быть перемещена или удалена.
            this.view_UserTableAdapter1.Fill(this.diagnosticDataSet1.View_User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet.View_User". При необходимости она может быть перемещена или удалена.
            this.view_UserTableAdapter.Fill(this.diagnosticDataSet.View_User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet.ServicesService". При необходимости она может быть перемещена или удалена.
            this.servicesServiceTableAdapter.Fill(this.diagnosticDataSet.ServicesService);

            metroComboBox1.SelectedIndex = -1;
            metroComboBox2.SelectedIndex = -1;


        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            find_out_more_information f = new find_out_more_information();
            this.Hide();
            f.Show();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system main = new main_screen_of_the_system();
            this.Hide();
            main.Show();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            
            var u_ta = new UserTableAdapter();
            var rs_ta = new RegistrationServiceTableAdapter(); 
            u_ta.Fill(diagnosticDataSet1.User);
            rs_ta.Fill(diagnosticDataSet1.RegistrationService);
            var q = from u in diagnosticDataSet1.User
                join rs in diagnosticDataSet1.RegistrationService on u.Id equals rs.User_id into rsr
                from rsrr in rsr.DefaultIfEmpty()
                select new
                {
                    Uid = u.Id,
                    RegServId = rsrr?.Service_id ?? 0,
                    Name=u.FirstName,
                };
            if (metroComboBox1.SelectedValue != null)
            {
                q = q.Where(x => x.RegServId == (int)metroComboBox1.SelectedValue);
            }
            

            var user_ids = q.Select(x => x.Uid).ToList();
            var ids_formatted = $"({string.Join(", ", user_ids)})";
            if (ids_formatted != "()")
            {
                viewUserBindingSource1.Filter = $"Id IN {ids_formatted}";
                if (metroComboBox2.Text != "")
                {
                    viewUserBindingSource1.Sort = $"FirstName {metroComboBox2.Text}";
                }
                
            }
            listBox1.Items.Add(dataGridView1.Rows.Count.ToString());
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            Excel.Application ExcelApp = new Excel.Application();
            Excel.Workbook ExcelWorkBook;
            Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Worksheet sheet = ExcelWorkBook.Worksheets.get_Item(1);
            sheet.Cells.get_Range("A1", "R17").Font.Bold = true;
            ExcelApp.Columns.ColumnWidth = 20;
            ExcelApp.Cells[2, 1] = "Email";
            ExcelApp.Cells[1, 1] = "ОТЧЕТ ПО КЛИЕНТАМ";
            ExcelApp.Range[ExcelApp.Cells[1, 5], ExcelApp.Cells[1, 5]].Merge(Type.Missing);
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
               
                

                    ExcelApp.Cells[i + 3, 1] = (dataGridView1.Rows[i].Cells[4].Value).ToString();
                
            }

            sheet.Cells.get_Range("A1", "R20").EntireColumn.AutoFit();
            sheet.Cells.get_Range("A1", "R20").EntireColumn.HorizontalAlignment = HorizontalAlignment.Center;
            sheet.Cells.get_Range("A1", "R20").EntireColumn.VerticalAlignment = HorizontalAlignment.Center;
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            Excel.Application ExcelApp = new Excel.Application();
            Excel.Workbook ExcelWorkBook;
            Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Worksheet sheet = ExcelWorkBook.Worksheets.get_Item(1);
            sheet.Cells.get_Range("A1", "R17").Font.Bold = true;

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                ExcelWorkSheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    ExcelWorkSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].FormattedValue.ToString();
                }

            }
            sheet.Cells.get_Range("A1", "R20").EntireColumn.AutoFit();
            sheet.Cells.get_Range("A1", "R20").EntireColumn.HorizontalAlignment = HorizontalAlignment.Center;
            sheet.Cells.get_Range("A1", "R20").EntireColumn.VerticalAlignment = HorizontalAlignment.Center;
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
    }
}
