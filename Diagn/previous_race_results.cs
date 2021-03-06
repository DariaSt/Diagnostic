﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Diagn.DiagnosticDataSet1TableAdapters;
using Diagn.DiagnosticDataSet2TableAdapters;

namespace Diagn
{
    public partial class previous_race_results : Form
    {
        public previous_race_results()
        {
            InitializeComponent();
        }

        private void Rez_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet2.View_Timesheet". При необходимости она может быть перемещена или удалена.
            this.view_TimesheetTableAdapter.Fill(this.diagnosticDataSet2.View_Timesheet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet2.View_User". При необходимости она может быть перемещена или удалена.
            this.view_UserTableAdapter.Fill(this.diagnosticDataSet2.View_User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet2.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.diagnosticDataSet2.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet2.ServicesService". При необходимости она может быть перемещена или удалена.
            this.servicesServiceTableAdapter.Fill(this.diagnosticDataSet2.ServicesService);
            /*Надя
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.View_Timesheet". При необходимости она может быть перемещена или удалена.
            this.view_TimesheetTableAdapter.Fill(this.diagnosticDataSet1.View_Timesheet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.diagnosticDataSet1.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.ServicesService". При необходимости она может быть перемещена или удалена.
            this.servicesServiceTableAdapter.Fill(this.diagnosticDataSet1.ServicesService);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.View_User". При необходимости она может быть перемещена или удалена.
            this.view_UserTableAdapter.Fill(this.diagnosticDataSet1.View_User);
            */
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dateTimePicker2.Checked = false;
            dateTimePicker1.Checked = true;
        }

       

      

        private void previous_race_results_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u_ta = new UserTableAdapter();
            var rs_ta = new RegistrationServiceTableAdapter();
            var r_ta = new RegistrationTableAdapter();
            u_ta.Fill(diagnosticDataSet2.User);
            rs_ta.Fill(diagnosticDataSet2.RegistrationService);
            r_ta.Fill(diagnosticDataSet2.Registration);
            var q = from u in diagnosticDataSet2.User
                    join rs in diagnosticDataSet2.RegistrationService on u.Id equals rs.User_id into rsr
                    from rsrr in rsr.DefaultIfEmpty()
                    join r in diagnosticDataSet2.Registration on u.Id equals r.User_Id into rr
                    from rrr in rr.DefaultIfEmpty()
                    select new
                    {
                        Uid = u.Id,
                        GenderID = u.Gender_Id,
                        RegServId = rsrr?.Service_id ?? 0,
                       UDTBirth = u.DateOfBirth,// вот тут она хранится
                        RegDT = rrr?.RegistrationDateTime ?? DateTime.MinValue,
                    };
            if (comboBox1.SelectedValue != null)
            {
                q = q.Where(x => x.RegServId == (int)comboBox1.SelectedValue);
            }
            if (comboBox2.SelectedValue != null)
            {
                q = q.Where(x => x.GenderID == (int)comboBox2.SelectedValue);
            }
            if (dateTimePicker2.Checked)
            {
                q = q.Where(x => x.RegDT == dateTimePicker2.Value);
            }
            if (dateTimePicker1.Checked)
            {
                q = q.Where(x => x.UDTBirth == dateTimePicker1.Value);
            }
            var user_ids = q.Select(x => x.Uid).ToList();
            var ids_formatted = string.Format("({0})", string.Join(", ", user_ids));
            if (ids_formatted != "()")
            {
                viewUserBindingSource.Filter = string.Format("Id IN {0}", ids_formatted);
            }
            listBox1.Items.Add(view_UserDataGridView.Rows.Count.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
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
                find_out_more_information find = new find_out_more_information();
                
                find.Show();
            }
            //find_out_more_information find = new find_out_more_information();
            //this.Hide();
            //find.Show();
        }
    }
}
