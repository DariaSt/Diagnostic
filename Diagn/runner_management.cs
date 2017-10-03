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

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            find_out_more_information f = new find_out_more_information();
            f.ShowDialog();
        }
    }
}
