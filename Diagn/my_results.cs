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
    public partial class my_results : MaterialSkin.Controls.MaterialForm
    {
        public my_results()
        {
            InitializeComponent();
        }

        private void my_rez_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
           runner_menu menu = new runner_menu();
            menu.ShowDialog();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system m = new main_screen_of_the_system();
            m.ShowDialog();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            previous_race_results previous = new previous_race_results();
            previous.ShowDialog();
        }
    }
}
