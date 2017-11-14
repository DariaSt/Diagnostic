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
    public partial class main_screen_of_the_system : Form
    {
        public main_screen_of_the_system()
        {
            InitializeComponent();
        }
        int Role_=1;
        public main_screen_of_the_system(int RoleId)
        {
            InitializeComponent();
            // Role_=RoleId;
            Role_ = ClassRole.Role;
        }

        private void main_screen_of_the_system_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is register_as_a_runner);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                register_as_a_runner reg = new register_as_a_runner();
                
                reg.Show();
            }
            //register_as_a_runner reg = new register_as_a_runner();
            //this.Hide();
            //reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is find_out_more_information);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                find_out_more_information find_Out_ = new find_out_more_information(Role_);
                
                find_Out_.Show();
            }
            //find_out_more_information find_Out_ = new find_out_more_information(Role_);
            //this.Hide();
            //find_Out_.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ClassRole._role == 1)
            {
                this.Hide();
                authorization_menu authorization = new authorization_menu();

                authorization.Show();
            }
            else
            {
                this.Hide();
                var formToShow = Application.OpenForms.Cast<Form>()
               .FirstOrDefault(c => c is authorization_menu);
                if (formToShow != null)
                {

                    if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                    formToShow.TopMost = true;
                    formToShow.Visible = true;
                }
                else
                {
                    authorization_menu authorization = new authorization_menu();

                    authorization.Show();
                }
                //authorization_menu authorization = new authorization_menu();
                //this.Hide();
                //authorization.Show();
            }
        }
    }
}
