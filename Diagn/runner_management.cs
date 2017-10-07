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
    public partial class runner_management : MaterialSkin.Controls.MaterialForm
    {
        public runner_management()
        {
            InitializeComponent();
        }

        private void yprav_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet.View_User". При необходимости она может быть перемещена или удалена.
            this.view_UserTableAdapter.Fill(this.diagnosticDataSet.View_User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet.ServicesService". При необходимости она может быть перемещена или удалена.
            this.servicesServiceTableAdapter.Fill(this.diagnosticDataSet.ServicesService);

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
    }
}
