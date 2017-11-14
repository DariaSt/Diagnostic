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
            ClassRole._UserID = (int)User_id;
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
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is runner_menu);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                runner_menu patient = new runner_menu();
               
                patient.Show();
            }
            //runner_menu patient = new runner_menu();
            //this.Hide();
            //patient.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassRole.Role = 1;
            ClassRole._UserID = 0;
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is main_screen_of_the_system);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                main_screen_of_the_system main = new main_screen_of_the_system();
               
                main.Show();
            }
            //main_screen_of_the_system main = new main_screen_of_the_system();
            //this.Hide();
            //main.Show();
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
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is runner_menu);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                runner_menu patient = new runner_menu();
               
                patient.Show();
            }
            //runner_menu patient = new runner_menu();
            //this.Hide();
            //patient.Show();
        }
    }
}
