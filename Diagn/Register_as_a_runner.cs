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
    public partial class register_as_a_runner : MaterialSkin.Controls.MaterialForm
    {
        public register_as_a_runner()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system main = new main_screen_of_the_system();
            this.Hide();
            main.Show();
            
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            authorization_menu authorization = new authorization_menu();
            this.Hide();
            authorization.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            patient_registration_menu patient_Registration = new patient_registration_menu();
            this.Hide();
            patient_Registration.Show();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            authorization_menu authorization = new authorization_menu();
            this.Hide();
            authorization.Show();
        }
    }
}
