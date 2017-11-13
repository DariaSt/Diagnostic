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
    public partial class authorization_menu : Form
    {
        public authorization_menu()
        {
            InitializeComponent();
           textBox1.Text = "";
            textBox2.Text = "";
        }
        int RoleId;
    
        private void authorization_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is main_screen_of_the_system);
            if (formToShow != null)
            {
                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.TopMost = false;
            }
            else
            {
                main_screen_of_the_system main = new main_screen_of_the_system();
                main.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoleId = (int)view_UserTableAdapter1.Authorization(textBox1.Text, textBox2.Text);
            ClassRole.Role = RoleId;
            switch (RoleId)
            {
                case 1:
                    {
                        MessageBox.Show("Неверные данные");
                    }
                    break;
                case 2:
                    {
                        DiagnosticDataSetTableAdapters.View_UserTableAdapter _UserTableAdapter = new DiagnosticDataSetTableAdapters.View_UserTableAdapter();
                        int id=_UserTableAdapter.GetId(textBox1.Text).Value;
                        ClassRole._UserID = id;
                        runner_menu menu = new runner_menu(RoleId, id);
                        this.Hide();
                        menu.Show();
                    }
                    break;
                case 3:
                    {
                        administrator_menu adm_menu = new administrator_menu(RoleId, textBox1.Text);
                        this.Hide();
                        adm_menu.Show();
                    }
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
        }
    }
}
