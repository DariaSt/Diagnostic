using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet11.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.diagnosticDataSet11.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.View_Timesheet". При необходимости она может быть перемещена или удалена.
            this.view_TimesheetTableAdapter.Fill(this.diagnosticDataSet1.View_Timesheet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.diagnosticDataSet1.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.ServicesService". При необходимости она может быть перемещена или удалена.
            this.servicesServiceTableAdapter.Fill(this.diagnosticDataSet1.ServicesService);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.View_User". При необходимости она может быть перемещена или удалена.
            this.view_UserTableAdapter.Fill(this.diagnosticDataSet1.View_User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet1.View_User". При необходимости она может быть перемещена или удалена.
          
            
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            find_out_more_information find = new find_out_more_information();
            this.Hide();
            find.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
           view_UserBindingSource.Filter = string.Format("Gender = '{0}'", metroComboBox3.Text);
           
        }
    }
}
