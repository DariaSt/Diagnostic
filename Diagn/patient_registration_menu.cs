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
    public partial class patient_registration_menu : MaterialSkin.Controls.MaterialForm
    {
        public patient_registration_menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if ((metroTextBox1.Text.Equals("")) || (metroTextBox2.Text.Equals("")) || (metroTextBox3.Text.Equals("")) || (metroTextBox4.Text.Equals("")) || (metroTextBox5.Text.Equals("")))
                MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                service_registration service = new service_registration();
                service.ShowDialog();
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system main = new main_screen_of_the_system();
            main.ShowDialog();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system main = new main_screen_of_the_system();
            main.ShowDialog();
        }
    }
}
