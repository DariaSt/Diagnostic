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
    public partial class service_registration : Form
    {
        public service_registration()
        {
            InitializeComponent();
        }
        int? User_id;
        public service_registration(int? Id_User)
        {
            InitializeComponent();
            User_id = Id_User;
        }
        private void regis_Load(object sender, EventArgs e)
        {

        }

  

        private void service_registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runner_menu patient = new runner_menu();
            this.Hide();
            patient.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system main = new main_screen_of_the_system();
            this.Hide();
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
            {
                int id_Service;
                if (checkBox1.Checked)
                {
                    id_Service = 1;
                    DiagnosticDataSetTableAdapters.View_RegistrationServiceTableAdapter registrationServiceTableAdapter = new DiagnosticDataSetTableAdapters.View_RegistrationServiceTableAdapter();
                    registrationServiceTableAdapter.Insert_RegistrationService(User_id, id_Service, dateTimePicker1.Value);
                }
                if (checkBox2.Checked)
                {
                    id_Service = 2;
                    DiagnosticDataSetTableAdapters.View_RegistrationServiceTableAdapter registrationServiceTableAdapter = new DiagnosticDataSetTableAdapters.View_RegistrationServiceTableAdapter();
                    registrationServiceTableAdapter.Insert_RegistrationService(User_id, id_Service, dateTimePicker2.Value);
                }
                if (checkBox3.Checked)
                {
                    id_Service = 3;
                    DiagnosticDataSetTableAdapters.View_RegistrationServiceTableAdapter registrationServiceTableAdapter = new DiagnosticDataSetTableAdapters.View_RegistrationServiceTableAdapter();
                    registrationServiceTableAdapter.Insert_RegistrationService(User_id, id_Service, dateTimePicker3.Value);
                }
                registration_confirmation confirmation = new registration_confirmation();
                this.Hide();
                confirmation.Show();
            }
            else
            {
                MessageBox.Show("Выберите вид услуги!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            runner_menu patient = new runner_menu();
            this.Hide();
            patient.Show();
        }
    }
}
