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
                    Name=u.LastName,
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
                    viewUserBindingSource1.Sort = $"LastName {metroComboBox2.Text}";
                }
                
            }
        }
    }
}
