﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Diagn.DiagnosticDataSet1TableAdapters;
using Diagn.DiagnosticDataSet2TableAdapters;
using Excel = Microsoft.Office.Interop.Excel;

namespace Diagn
{
    public partial class runner_management : Form
    {
        public runner_management()
        {
            InitializeComponent();
        }

        private void yprav_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet2.ServicesService". При необходимости она может быть перемещена или удалена.
            this.servicesServiceTableAdapter2.Fill(this.diagnosticDataSet2.ServicesService);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet2.View_User". При необходимости она может быть перемещена или удалена.
            this.view_UserTableAdapter2.Fill(this.diagnosticDataSet2.View_User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.ServicesService". При необходимости она может быть перемещена или удалена.
            // this.servicesServiceTableAdapter2.Fill(this.diagnosticDataSet1.ServicesService);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.View_User". При необходимости она может быть перемещена или удалена.
            //  this.view_UserTableAdapter2.Fill(this.diagnosticDataSet1.View_User);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
          listBox2.Items.Add(dataGridView1.Rows.Count.ToString());
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is find_out_more_information);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                find_out_more_information f = new find_out_more_information();
               
                f.Show();
            }
            //find_out_more_information f = new find_out_more_information();
            //this.Hide();
            //f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassRole.Role = 1;
            ClassRole._UserID = 0;
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is main_screen_of_the_system);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                main_screen_of_the_system main = new main_screen_of_the_system();
               
                main.Show();
            }
            //main_screen_of_the_system main = new main_screen_of_the_system();
            //this.Hide();
            //main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
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
            ExcelApp.Range[ExcelApp.Cells[1, 6], ExcelApp.Cells[1, 6]].Merge(Type.Missing);
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {



                ExcelApp.Cells[i + 3, 1] = (dataGridView1.Rows[i].Cells[5].Value).ToString();

            }

            sheet.Cells.get_Range("A1", "R20").EntireColumn.AutoFit();
            sheet.Cells.get_Range("A1", "R20").EntireColumn.HorizontalAlignment = HorizontalAlignment.Center;
            sheet.Cells.get_Range("A1", "R20").EntireColumn.VerticalAlignment = HorizontalAlignment.Center;
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var u_ta = new UserTableAdapter();
            var rs_ta = new RegistrationServiceTableAdapter();
            u_ta.Fill(diagnosticDataSet2.User);
            rs_ta.Fill(diagnosticDataSet2.RegistrationService);
            var q = from u in diagnosticDataSet2.User
                    join rs in diagnosticDataSet2.RegistrationService on u.Id equals rs.User_id into rsr
                    from rsrr in rsr.DefaultIfEmpty()
                    select new
                    {
                        Uid = u.Id,
                        RegServId = rsrr?.Service_id ?? 0,
                        Name = u.FirstName,
                    };
            // вот такой конструкцией
            if (comboBox1.SelectedValue != null)
            {
                q = q.Where(x => x.RegServId == (int)comboBox1.SelectedValue);
            }


            var user_ids = q.Select(x => x.Uid).ToList();
            var ids_formatted = $"({string.Join(", ", user_ids)})";
            if (ids_formatted != "()")
            {
                bindingSource1.Filter = $"Id IN {ids_formatted}";
                if (comboBox2.Text != "")
                {
                   // bindingSource1.Sort = $"FirstName {comboBox2.Text}";
                   bindingSource1.Filter= $"FirstName='"+comboBox2.Text+"'";
                }
                listBox2.Items.Add(dataGridView1.Rows.Count.ToString());

            }

        }

        private void runner_management_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is manage_a_runner);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                manage_a_runner f = new manage_a_runner();
               
                f.Show();
            }
            //manage_a_runner f = new manage_a_runner();
            //this.Hide();
            //f.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            manage_a_runner f = new manage_a_runner();
            f.textBox5.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            f.textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f.textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f.textBox3.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f.textBox4.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            this.Hide();
            f.Show();
        }
    }
}
