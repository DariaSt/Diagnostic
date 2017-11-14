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
    public partial class manage_a_runner : Form
    {
        public manage_a_runner()
        {
            InitializeComponent();
        }

        
        private void manage_a_runner_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is runners);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                runners menu = new runners();
               
                menu.Show();
            }
            //runners menu = new runners();
            //this.Hide();
            //menu.Show();
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
                main_screen_of_the_system m = new main_screen_of_the_system();
               
                m.Show();
            }
            //authorization_menu m = new authorization_menu();
            //this.Hide();
            //m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            certificate_preview preview = new certificate_preview();
            preview.textBox1.Text = this.textBox1.Text;
            preview.textBox2.Text = this.textBox2.Text;
            this.Hide();
            preview.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            edit_runner_profile preview = new edit_runner_profile();
        
            preview.comboBox1.Text = this.textBox3.Text;
            preview.textBox1.Text = this.textBox2.Text;
            preview.textBox2.Text = this.textBox1.Text;
            preview.dateTimePicker1.Text = this.textBox4.Text;
            preview.textBox3.Text = this.textBox5.Text;
            this.Hide();
            preview.Show();
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != null)
            {
                checkBox1.Checked = true;
            }
        }
    }
}
