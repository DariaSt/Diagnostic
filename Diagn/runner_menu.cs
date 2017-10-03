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
    public partial class runner_menu : MaterialSkin.Controls.MaterialForm
    {
        public runner_menu()
        {
            InitializeComponent();
        }

        private void Menu_pacienta_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            service_registration serv = new service_registration();
            serv.ShowDialog();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system main = new main_screen_of_the_system();
            main.ShowDialog();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system main = new main_screen_of_the_system();
            main.ShowDialog();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            my_results results = new my_results();
            results.ShowDialog();
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            edit_runner_profile edit = new edit_runner_profile();
            edit.ShowDialog();
        }
    }
}
