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
    public partial class interactive_map : MaterialSkin.Controls.MaterialForm
    {
        public interactive_map()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            find_out_more_information information = new find_out_more_information();
            this.Hide();
            information.Show();
        }
    }
}
