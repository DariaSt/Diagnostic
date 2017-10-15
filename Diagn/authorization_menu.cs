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
    public partial class authorization_menu : MaterialSkin.Controls.MaterialForm
    {
        public authorization_menu()
        {
            InitializeComponent();
        }
        int RoleId;
        private void Auto_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system main = new main_screen_of_the_system();
            this.Hide();
            main.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            RoleId = (int)view_UserTableAdapter1.Authorization(metroTextBox1.Text, metroTextBox2.Text);
            switch (RoleId)
            {
                case 1:
                    {
                        main_screen_of_the_system main = new main_screen_of_the_system();
            this.Hide();
            main.Show();
        } break;
                case 2: {
                        runner_menu menu = new runner_menu(RoleId);
                        this.Hide();
        menu.Show();
                    } break;
                case 3:
                    {
                        administrator_menu adm_menu = new administrator_menu(RoleId);
                        this.Hide();
                        adm_menu.Show();
                    }
                    break;
            }
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system main = new main_screen_of_the_system();
            this.Hide();
            main.Show();
        }

        private void authorization_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
