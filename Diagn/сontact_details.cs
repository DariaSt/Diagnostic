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
    public partial class contact_details : Form
    {
        public contact_details()
        {
            InitializeComponent();
        }

        private void сontact_details_Load(object sender, EventArgs e)
        {

        }

       

        private void contact_details_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runner_menu m = new runner_menu();
            this.Hide();
            m.Show();
        }
    }
}
