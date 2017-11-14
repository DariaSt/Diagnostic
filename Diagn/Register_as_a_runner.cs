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
    public partial class register_as_a_runner : Form
    {
        public register_as_a_runner()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }


        private void register_as_a_runner_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void button2_Click(object sender, EventArgs e)
        {
            authorization_menu authorization = new authorization_menu();
            this.Hide();
            authorization.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            patient_registration_menu patient_Registration = new patient_registration_menu();
            this.Hide();
            patient_Registration.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            authorization_menu authorization = new authorization_menu();
            this.Hide();
            authorization.Show();
        }
    }
}
