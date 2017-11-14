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
    public partial class registration_confirmation : Form
    {
        public registration_confirmation()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

      

        private void registration_confirmation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is service_registration);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                service_registration ser = new service_registration();
               
                ser.Show();
            }
            //service_registration ser = new service_registration();
            //this.Hide();
            //ser.Show();
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
                runner_menu runner = new runner_menu();
               
                runner.Show();
            }
            //runner_menu runner = new runner_menu();
            //this.Hide();
            //runner.Show();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
