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
    public partial class main_screen_of_the_system : MaterialSkin.Controls.MaterialForm
    {
        public main_screen_of_the_system()
        {
            InitializeComponent();
        }

        private void Main_1_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            register_as_a_runner reg = new register_as_a_runner();         
            this.Hide();
            reg.Show();


        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            find_out_more_information find_Out_ = new find_out_more_information();
            this.Hide();
            find_Out_.Show();
            
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            authorization_menu authorization = new authorization_menu();
            this.Hide();
            authorization.Show();
            
        }
    }
}
