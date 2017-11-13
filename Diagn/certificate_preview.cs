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
    public partial class certificate_preview : Form
    {
        public certificate_preview()
        {
            InitializeComponent();
        }

        private void certificate_preview_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is manage_a_runner);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                manage_a_runner f = new manage_a_runner();
               
                f.Show();
            }
            //manage_a_runner f = new manage_a_runner();
            //this.Hide();
            //f.Show();
        }
    }
}
