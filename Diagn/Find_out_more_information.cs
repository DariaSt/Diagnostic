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
    public partial class find_out_more_information : Form
    {
        public find_out_more_information()
        {
            InitializeComponent();
        }
        int Role_ = 1;
        public find_out_more_information(int role)
        {
            InitializeComponent();
      //      Role_ = role;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Role_ = ClassRole.Role;
            if (Role_ == 3)
            {
                button2.Visible = true;
                button3.Visible = true;
            }
            else {
                button2.Visible = false;
                button3.Visible = false;
            }
        }


        private void find_out_more_information_FormClosing(object sender, FormClosingEventArgs e)
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
                main_screen_of_the_system m = new main_screen_of_the_system();
               
                m.Show();
            }
            //main_screen_of_the_system m = new main_screen_of_the_system();
            //this.Hide();
            //m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is previous_race_results);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                previous_race_results previous = new previous_race_results();
               // this.Hide();
                previous.Show();
            }*/
            previous_race_results previous = new previous_race_results();
            this.Hide();
            previous.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is runner_management);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                runner_management run = new runner_management();
               
                run.Show();
            }*/
            runner_management run = new runner_management();
            this.Hide();
            run.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is about_diagnostic_2017);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                about_diagnostic_2017 about = new about_diagnostic_2017();
               
                about.Show();
            }
            //about_diagnostic_2017 about = new about_diagnostic_2017();
            //this.Hide();
            //about.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is interactive_map);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                interactive_map map = new interactive_map();
               
                map.Show();
            }
            //interactive_map map = new interactive_map();
            //this.Hide();
            //map.Show();
        }
    }
}
