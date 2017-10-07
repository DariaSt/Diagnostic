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
    public partial class find_out_more_information : MaterialSkin.Controls.MaterialForm
    {
        public find_out_more_information()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system m = new main_screen_of_the_system();
            this.Hide();
            m.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            previous_race_results previous = new previous_race_results();
            this.Hide();
            previous.Show();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            about_diagnostic_2017 about = new about_diagnostic_2017();
            this.Hide();
            about.Show();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
           runner_management run = new runner_management();
            this.Hide();
            run.Show();
        }
    }
}
