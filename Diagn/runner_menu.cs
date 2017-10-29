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
            User_id = User;
        }
        private void Menu_pacienta_Load(object sender, EventArgs e)
        {

        }



        private void runner_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            authorization_menu menu = new authorization_menu();
            this.Hide();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system main = new main_screen_of_the_system();
            this.Hide();
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            service_registration serv = new service_registration(User_id);
            this.Hide();
            serv.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            my_results results = new my_results();
            this.Hide();
            results.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            edit_runner_profile edit = new edit_runner_profile(User_id);
            this.Hide();
            edit.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
             contact_details contact = new contact_details();
            this.Hide();
            contact.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
