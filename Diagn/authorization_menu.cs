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
            //if admin.....
           runner_menu menu = new runner_menu();
            this.Hide();
            menu.Show();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system main = new main_screen_of_the_system();
            this.Hide();
            main.Show();
        }
    }
}
