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
    public partial class runners : MaterialSkin.Controls.MaterialForm
    {
        public runners()
        {
            InitializeComponent();
        }

        private void runners_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet.View_User". При необходимости она может быть перемещена или удалена.
            this.view_UserTableAdapter.Fill(this.diagnosticDataSet.View_User);

        }

        private void view_UserDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           manage_a_runner run = new manage_a_runner();
            this.Hide();
            run.Show();
        }

        private void runners_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
