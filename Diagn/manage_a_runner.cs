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
    public partial class manage_a_runner : MaterialSkin.Controls.MaterialForm
    {
        public manage_a_runner()
        {
            InitializeComponent();
        }

        private void manage_a_runner_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
           certificate_preview preview= new certificate_preview();
            this.Hide();
            preview.Show();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            runners menu = new runners();
            this.Hide();
            menu.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            authorization_menu m = new authorization_menu();
            this.Hide();
            m.Show();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            edit_runner_profile profile = new edit_runner_profile();
            this.Hide();
            profile.Show();
        }
    }
}
