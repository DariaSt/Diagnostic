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
    public partial class administrator_menu : MaterialSkin.Controls.MaterialForm
    {
        public administrator_menu()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
           main_screen_of_the_system main = new main_screen_of_the_system();
            main.ShowDialog();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Будет добавлено в будущем");
        }
    }
}
