using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diagn.DiagnosticDataSet1TableAdapters;

namespace Diagn
{
    public partial class previous_race_results : MaterialSkin.Controls.MaterialForm
    {
        public previous_race_results()
        {
            InitializeComponent();
        }

        private void Rez_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.View_Timesheet". При необходимости она может быть перемещена или удалена.
            this.view_TimesheetTableAdapter.Fill(this.diagnosticDataSet1.View_Timesheet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.diagnosticDataSet1.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.ServicesService". При необходимости она может быть перемещена или удалена.
            this.servicesServiceTableAdapter.Fill(this.diagnosticDataSet1.ServicesService);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.View_User". При необходимости она может быть перемещена или удалена.
            this.view_UserTableAdapter.Fill(this.diagnosticDataSet1.View_User);
            
            metroComboBox1.SelectedIndex = -1;
            metroComboBox3.SelectedIndex = -1;
            dateTimePicker2.Checked = false;
            dateTimePicker1.Checked = true;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            find_out_more_information find = new find_out_more_information();
            this.Hide();
            find.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            var u_ta = new UserTableAdapter();
            var rs_ta = new RegistrationServiceTableAdapter();
            var r_ta = new RegistrationTableAdapter();
            u_ta.Fill(diagnosticDataSet1.User);
            rs_ta.Fill(diagnosticDataSet1.RegistrationService);
            r_ta.Fill(diagnosticDataSet1.Registration);
            var q = from u in diagnosticDataSet1.User
                    join rs in diagnosticDataSet1.RegistrationService on u.Id equals rs.User_id into rsr
                    from rsrr in rsr.DefaultIfEmpty()
                    join r in diagnosticDataSet1.Registration on u.Id equals r.User_Id into rr
                    from rrr in rr.DefaultIfEmpty()
                    select new
                    {
                        Uid = u.Id,
                        GenderID = u.Gender_Id,
                        RegServId = rsrr?.Service_id ?? 0,
                        UDTBirth = u.DateOfBirth,
                        RegDT = rrr?.RegistrationDateTime ?? DateTime.MinValue,
                    };
            if (metroComboBox1.SelectedValue != null)
            {
                q = q.Where(x => x.RegServId == (int)metroComboBox1.SelectedValue);
            }
            if (metroComboBox3.SelectedValue != null)
            {
                q = q.Where(x => x.GenderID == (int)metroComboBox3.SelectedValue);
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
                view_UserBindingSource.Filter = string.Format("Id IN {0}", ids_formatted);
            }
            listBox1.Items.Add(view_UserDataGridView.Rows.Count.ToString());

        }
    }
}
