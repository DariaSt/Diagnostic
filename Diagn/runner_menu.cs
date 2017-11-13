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
    public partial class runner_menu : Form
    {
        public runner_menu()
        {
            InitializeComponent();
        }
        int User_id;
        public runner_menu(int RoleId, int User)
        {
            InitializeComponent();
            //   User_id = User;
            User_id = ClassRole._UserID;
        }

        private void runner_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* authorization_menu menu = new authorization_menu();
             this.Hide();
             menu.Show();*/

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
            /*main_screen_of_the_system main = new main_screen_of_the_system();
            this.Hide();
            main.Show();*/
        }

        private void button3_Click(object sender, EventArgs e)
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
                service_registration serv = new service_registration(User_id);
                serv.Show();
            }
            /*service_registration serv = new service_registration(User_id);
            this.Hide();
            serv.Show();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is my_results);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                my_results results = new my_results(User_id);
                results.Show();
            }
          /*  my_results results = new my_results(User_id);
            this.Hide();
            results.Show();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is edit_runner_profile);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                edit_runner_profile edit = new edit_runner_profile(User_id);
                edit.Show();
            }
          /*  edit_runner_profile edit = new edit_runner_profile(User_id);
            this.Hide();
            edit.Show();*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is contact_details);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                contact_details contact = new contact_details();
                contact.Show();
            }
            /*contact_details contact = new contact_details();
            this.Hide();
            contact.Show();*/
        }

        
    }
}
