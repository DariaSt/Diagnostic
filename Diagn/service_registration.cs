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
            if (materialCheckBox1.Checked == true || materialCheckBox2.Checked == true || materialCheckBox3.Checked == true)
            {
                registration_confirmation confirmation = new registration_confirmation();
                this.Hide();
                confirmation.Show();
            }
            else
            {
                MessageBox.Show("Выберите вид услуги!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            runner_menu patient = new runner_menu();
            this.Hide();
            patient.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            runner_menu patient = new runner_menu();       
            this.Hide();
            patient.Show();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system main = new main_screen_of_the_system();
            this.Hide();
            main.Show();
        }

        private void service_registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
