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
    public partial class service_registration : MaterialSkin.Controls.MaterialForm
    {
        public service_registration()
        {
            InitializeComponent();
        }

        private void regis_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            registration_confirmation confirmation = new registration_confirmation();
            confirmation.ShowDialog();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system main = new main_screen_of_the_system();
            main.ShowDialog();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            patient_registration_menu patient = new patient_registration_menu();
            patient.ShowDialog();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system main = new main_screen_of_the_system();
            main.ShowDialog();
        }
    }
}
