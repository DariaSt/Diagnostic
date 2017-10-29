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
    public partial class my_results : Form
    {
        public my_results()
        {
            InitializeComponent();
        }

        private void my_rez_Load(object sender, EventArgs e)
        {

        }

        private void my_results_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runner_menu menu = new runner_menu();
            this.Hide();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            runner_menu menu = new runner_menu();
            this.Hide();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            previous_race_results previous = new previous_race_results();
            this.Hide();
            previous.Show();
        }
    }
}
