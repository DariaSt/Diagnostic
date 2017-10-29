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

        private void manage_a_runner_Load(object sender, EventArgs e)
        {

        }


        private void manage_a_runner_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runners menu = new runners();
            this.Hide();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            authorization_menu m = new authorization_menu();
            this.Hide();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            certificate_preview preview = new certificate_preview();
            this.Hide();
            preview.Show();
        }
    }
}
